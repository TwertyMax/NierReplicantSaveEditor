using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NieR_Replicant_Save_Editor
{
    class Save
    {
        private byte[] save; 

        private int slotIndex; //Индекс слота сохранения

        private const int maxNameLength = 32;

        private static int[] corruptionAddresses = { 0x08160, 0x113C0, 0x1A620 }; // Адрес для каждого слота сохранения. Байт. Нужен для определения игрой - поврежден ли слот сохранения. Нормальное значение - 200
        private static int[] checkSumAddresses = { 0x113B0, 0x1A610, 0x23870 }; // Адрес для каждого слота сохранения. 4 Байта. По этим адресам находятся контрольная сумма слотов сохранения
        private static int[] nameAddresses = { 0x0818C, 0x113EC, 0x1A64C }; // Адрес для каждого слота сохранения. 10 байт. Здесь хранится имя персонажа
        private static int[] moneyAddresses = { 0x0821C, 0x1147C, 0x1A6DC }; // Адрес для каждого слота сохранения. 4 байта. Здесь хранится количество денег персонажа
        private static int[] expAddresses = { 0x081D0, 0x11430, 0x1A690 };

        private static List<int> levelToExp = new List<int>()
        {
            0, 30, 240, 850, 2060, 4070, 7080, 11290, 16900, 24110, 33120, 44130, 57340,
            72950, 91160, 112170, 136180, 163390, 194000, 228210, 266220, 308230, 354440,
            405050, 460260, 520270, 585280, 655490, 731100, 812310, 899320, 987380,
            1076525, 1166790, 1258210, 1350820, 1444655, 1539750, 1636140, 1733860,
            1832945, 1933430, 2035350, 2138740, 2243635, 2350070, 2458080, 2567700,
            2678965, 2791910, 2906570, 3022980, 3141175, 3261190, 3383060, 3506820,
            3632505, 3760150, 3889790, 4021460, 4155195, 4289596, 4424674, 4560440,
            4696906, 4834082, 4971979, 5110609, 5249983, 5390112, 5531006, 5672677,
            5815137, 5958395, 6102464, 6247355, 6393078, 6539644, 6687065, 6835352,
            6984516, 7134568, 7285518, 7437380, 7590162, 7743877, 7898535, 8054148,
            8210726, 8368281, 8526824, 8686367, 8846919, 9008492, 9171098, 9334747,
            9499451, 9665220, 9832066,
        };

        public const int SaveSize = 0x48200; //Размер файла сохранения

        public static string SavePath { get; set; }
        public static bool IsLoaded { get; set; }

        public byte Corruption { get; set; }
        public uint Checksum { get; set; }

        public string Name { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }

        public Save(int slotIndex)
        {
            this.slotIndex = slotIndex;

            LoadSave();
            InitializeSave();
        }

        private uint CalculateCheckSum(BinaryReader br, MemoryStream ms)
        {
            uint[] result = new uint[4] { 0, 0, 0, 0 };
            for (int i = corruptionAddresses[slotIndex]; i < corruptionAddresses[slotIndex] + 0xC20; i += 8)
            {
                for (int j = 0, k = 4; j < 4 && k < 8; j++, k++)
                {
                    ms.Seek(i + j, SeekOrigin.Begin);
                    byte byteJ = br.ReadByte();
                    ms.Seek(i + k, SeekOrigin.Begin);
                    byte byteK = br.ReadByte();
                    result[j] += (uint)byteJ + byteK;
                }
            }
            result[0] += result[2];
            result[1] += result[3];
            return result[0] + result[1];
        }

        private void InitializeSave()
        {
            using(MemoryStream ms = new MemoryStream(save))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    Name = GetName(br, ms);
                    Money = GetMoney(br, ms);
                    Level = GetLevel(br, ms);
                    Corruption = GetCorruption(br, ms);
                    Checksum = GetChecksum(br, ms);
                }
            }
        }

        public void LoadSave()
        {
            save = File.ReadAllBytes(SavePath);
            if (save != null)
                IsLoaded = true;
        }

        public void SaveSlot(string name, int money, int level)
        {
            using (MemoryStream ms = new MemoryStream(save))
            {
                using (BinaryWriter bw = new BinaryWriter(ms, Encoding.ASCII))
                {
                    SaveName(bw, ms, name);
                    SaveMoney(bw, ms, money);
                    SaveLevel(bw, ms, level);
                    using (BinaryReader br = new BinaryReader(ms))
                    {
                        Checksum = CalculateCheckSum(br, ms);
                        SaveChecksum(bw, ms);
                    }
                }
                SaveFile(ms);
            }
            InitializeSave();
        }

        private void SaveFile(MemoryStream ms)
        {
            File.WriteAllBytes(SavePath, ms.ToArray());
        }

        private void SaveName(BinaryWriter bw, MemoryStream ms, string name)
        {
            ms.Seek(nameAddresses[slotIndex], SeekOrigin.Begin);
            for (int i = 0; i < name.Length; i++)
            {
                bw.Write(name[i]);
            }
            if ((maxNameLength - name.Length) > 0)
            {
                for (int i = 0; i < (maxNameLength - name.Length); i++)
                {
                    bw.Write(Byte.MinValue);
                }
            }
        }

        private void SaveLevel(BinaryWriter bw, MemoryStream ms, int level)
        {
            ms.Seek(expAddresses[slotIndex], SeekOrigin.Begin);
            bw.Write(levelToExp[level-1]);
        }

        private void SaveMoney(BinaryWriter bw, MemoryStream ms, int money)
        {
            ms.Seek(moneyAddresses[slotIndex], SeekOrigin.Begin);
            bw.Write(money);
        }

        private void SaveChecksum(BinaryWriter bw, MemoryStream ms)
        {
            ms.Seek(checkSumAddresses[slotIndex], SeekOrigin.Begin);
            bw.Write(Checksum);
        }

        private int GetLevel(BinaryReader br, MemoryStream ms)
        {
            ms.Seek(expAddresses[slotIndex], SeekOrigin.Begin);
            int level = 0;
            int levelExp = br.ReadInt32();
            foreach (int exp in levelToExp)
            {
                if (levelExp < exp)
                {
                    level = levelToExp.IndexOf(exp);
                    break;
                }
            }
            if (level == 0)
                level = 99;
            return level;
        }

        private int GetMoney(BinaryReader br, MemoryStream ms)
        {
            ms.Seek(moneyAddresses[slotIndex], SeekOrigin.Begin);
            return br.ReadInt32();
        }

        private string GetName(BinaryReader br, MemoryStream ms)
        {
            ms.Seek(nameAddresses[slotIndex], SeekOrigin.Begin);
            return new string(br.ReadChars(maxNameLength)).Trim('\0');
        }

        private byte GetCorruption(BinaryReader br, MemoryStream ms)
        {
            ms.Seek(corruptionAddresses[slotIndex], SeekOrigin.Begin);
            return br.ReadByte();
        }

        private uint GetChecksum(BinaryReader br, MemoryStream ms)
        {
            ms.Seek(checkSumAddresses[slotIndex], SeekOrigin.Begin);
            return br.ReadUInt32();
        }
    }
}
