using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NieR_Replicant_Save_Editor
{
    enum WeaponTypes
    {
        OneHanded,
        TwoHanded,
        Spear
    }

    class Save
    {
        public static Save instance { get; private set; }

        private byte[] save;

        private int slotIndex;

        private const int maxNameLength = 10;

        private static int[] corruptionAddresses = { 0x08160, 0x113C0, 0x1A620 }; // Адрес для каждого слота сохранения. Байт. Нужен для определения игрой - поврежден ли слот сохранения. Нормальное значение - 200
        private static int[] checkSumAddresses = { 0x113B0, 0x1A610, 0x23870 }; // Адрес для каждого слота сохранения. 4 Байта. По этим адресам находятся контрольная сумма слотов сохранения
        private static int[] nameAddresses = { 0x0818C, 0x113EC, 0x1A64C }; // Адрес для каждого слота сохранения. 10 байт. Здесь хранится имя персонажа
        private static int[] moneyAddresses = { 0x0821C, 0x1147C, 0x1A6DC }; // Адрес для каждого слота сохранения. 4 байта. Здесь хранится количество денег персонажа
        private static int[] expAddresses = { 0x081D0, 0x11430, 0x1A690 }; // Адрес для каждого слота сохранения. 4 байта. Здесь хранится количество опыту персонажа
        private static int[] recoverysStartAddresses = { 0x08220, 0x11480, 0x1A6E0 }; //Адрес для каждого слота сохранения. 4 Байта. Здесь хранятся восстонавлющие предметы.;

        private static int[,] weaponAddresses = { { 0x0860C, 0x1186C, 0x1AACC }, { 0x08620, 0x11880, 0x1AAE0 }, { 0x08634, 0x11894, 0x1AAF4 } }; //Адреса начала оружии каждого типа. 1 - One Handed, 2 - Two Handed, 3 - Spears

        public static string[] slots = { "Slot 1", "Slot 2", "Slot 3" };
        public static string[] weaponsLevel = { "NO", "Lvl.1", "Lvl.2", "Lvl.3", "Lvl.4" };

        public static string[] maps =
        {
          "NO_IMAGE_AREA_00", "B_CASTLE_FIELD_01", "B_CASTLE_FIELD_011_D", "B_CASTLE_FIELD_02", "B_CASTLE_FIELD_021_D",
          "B_CASTLE_FIELD_03", "B_CASTLE_FIELD_04", "B_CASTLE_FIELD_041_D", "B_CASTLE_FIELD_10", "B_CENTER_LIBRARY_01",
          "B_CENTER_LIBRARY_011_D", "A_CENTER_VILLAGE_01", "B_CENTER_VILLAGE_01", "A_CENTER_VILLAGE_21", "A_CLIFF_VILLAGE_01",
          "B_CLIFF_VILLAGE_01", "E_CLIFF_VILLAGE_01", "B_CLIFF_VILLAGE_02", "B_CLIFF_VILLAGE_21", "A_DESERT_FIELD_01",
          "B_DESERT_FIELD_01", "A_DESERT_FIELD_02", "B_DESERT_FIELD_02", "A_DESERT_TEMPLE_01", "B_DESERT_TEMPLE_01",
          "B_DESERT_TEMPLE_011_D", "B_DESERT_TEMPLE_012_D", "B_DESERT_TEMPLE_013_D", "B_DESERT_TEMPLE_014_D", "A_DESERT_TEMPLE_02",
          "B_DESERT_TEMPLE_02", "A_DESERT_TOWN_01", "B_DESERT_TOWN_01", "B_DESERT_TOWN_011_D", "A_EAST_FIELD_01",
          "B_EAST_FIELD_01", "A_FOREST_FIELD_01", "B_FOREST_FIELD_01", "C_FOREST_FIELD_01", "D_FOREST_FIELD_01",
          "E_FOREST_FIELD_01", "E_FOREST_FIELD_02", "E_FOREST_FIELD_03", "E_FOREST_FIELD_04", "B_MERMAID_FIELD_01",
          "B_MERMAID_FIELD_02", "B_MERMAID_FIELD_03", "A_MOUNT_FIELD_01", "B_MOUNT_FIELD_01","A_MOUNT_ROBOT_01",
          "B_MOUNT_ROBOT_01", "A_MOUNT_ROBOT_01_1", "A_MOUNT_ROBOT_01_2", "A_MOUNT_ROBOT_02", "B_MOUNT_ROBOT_02",
          "A_MOUNT_ROBOT_03", "B_MOUNT_ROBOT_03", "A_MOUNT_ROBOT_04", "B_MOUNT_ROBOT_04", "B_MOUNT_ROBOT_041_D",
          "A_MOUNT_ROBOT_10", "B_MOUNT_ROBOT_10", "B_MOUNT_ROBOT_101_D", "A_MOUNT_ROBOT_10_1", "A_MOUNT_ROBOT_10_2",
          "A_MOUNT_ROBOT_10_3", "A_NORTH_FIELD_01", "B_NORTH_FIELD_01", "E_NORTH_FIELD_01", "A_NORTH_FIELD_21",
          "A_SEASIDE_TOWN_01", "B_SEASIDE_TOWN_01", "B_SEASIDE_TOWN_011_D", "A_SOUTH_FIELD_01", "B_SOUTH_FIELD_01",
          "B_SOUTH_FIELD_011_D", "A_SOUTH_FIELD_21", "A_SOUTH_MANSION_01", "B_SOUTH_MANSION_01", "A_SOUTH_MANSION_02",
          "B_SOUTH_MANSION_02", "B_SOUTH_MANSION_021_D", "B_SOUTH_UNDERGROUND_01", "B_SOUTH_UNDERGROUND_01_1", "B_SOUTH_UNDERGROUND_01_2",
          "B_SOUTH_UNDERGROUND_01_3", "B_SOUTH_UNDERGROUND_02", "B_SOUTH_UNDERGROUND_021_D", "A_STONE_FIELD_01", "B_STONE_FIELD_01",
          "A_STONE_FIELD_01_1", "A_STONE_FIELD_01_2", "A_STONE_FIELD_02", "B_STONE_FIELD_02","B_STONE_FIELD_021_D",
          "A_STONE_TEMPLE_01", "B_STONE_TEMPLE_01", "A_STONE_TEMPLE_01_1", "A_STONE_TEMPLE_01_2", "A_STONE_TEMPLE_01_3",
          "C_TOKYO_FIELD_01"
        };

        private static int[] levelToExp =
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

        public static string[] oneHandedWeapons =
        {
            "Nameless Blade", "Phoenix Dagger", "Beastbain", "Labyrinth's Whisper", "Fool's Embrace",
            "Ancient Overlord", "Rebirth", "Earth Wyrm's Claw", "Nirvana Dagger", "Moonrise",
            "Blade of Treachery", "Lily-Leaf Sword", "Faith", "Iron Pipe", "Kainé's Sword",
            "Virtuous Contract", "Cruel Oath"
        };

        public static string[] twoHandedWeapons =
        {
            "Kusanagi", "Phoenix Sword", "Beastlord", "Labyrinth's Song", "Fool's Lament",
            "Fang of the Twins", "Axe of Beheading", "Vile Axe", "Iron Will", "Virtuous Treaty",
        };

        public static string[] spearWeapons =
        {
            "Transience", "Phoenix Spear", "Beastcurse", "Labyrinth's Shout", "Fool's Accord",
            "The Devil Queen", "Sunrise", "Spear of the Usurper", "Dragoon Lance", "Captain's Holy Spear",
            "Virtuous Dignity",
        };

        public static string[] recoverys =
        {
            "Medicinal Herb", "Health Salve", "Recovery Potion", "Strength Drop", "Strength Capsule",
            "Magic Drop", "Magic Capsule", "Defense Drop", "Defense Capsule", "Spirit Drop",
            "Spirit Capsule", "Antidotal Weed", "Smelling Salts",
        };  // skip 18 bytes after 3, 2 bytes after 11, 1 bytes after 12

    public const int SaveSize = 0x48200; 

        public static string SavePath { get; private set; }
        public static bool IsLoaded { get; private set; }

        public byte Corruption { get; private set; }
        public uint Checksum { get; private set; }
        public string Name { get; private set; }
        public int Money { get; private set; }
        public int Level { get; private set; }

        public Save(int slotIndex, string savePath = null)
        {
            if (String.IsNullOrEmpty(SavePath) && String.IsNullOrEmpty(savePath))
                throw new ArgumentException();
            instance = this;

            if (savePath != null)
                SavePath = savePath;
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
                    SetSaveVar(ms, br);
                }
            }
        }

        private void SetSaveVar(MemoryStream ms, BinaryReader br)
        {
            Name = GetName(br, ms);
            Money = GetMoney(br, ms);
            Level = GetLevel(br, ms);
            Corruption = GetCorruption(br, ms);
            Checksum = GetChecksum(br, ms);
        }

        public void LoadSave()
        {
            if (!IsLoaded)
            {
                try
                {
                    File.Copy(SavePath, SavePath + "_backup");
                }
                catch(IOException)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(SavePath));
                    FileInfo[] backups = directoryInfo.GetFiles("*" + "_backup" + "*.*");
                    if (backups.Count() != 0)
                        File.Copy(SavePath, SavePath + $"_backup{backups.Count()+1}");
                }
            }
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

        public void SaveWeaponLevel(WeaponTypes weaponType, int index, byte level)
        {
            using (MemoryStream ms = new MemoryStream(save))
            {
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    ms.Seek((weaponType == WeaponTypes.Spear ? weaponAddresses[2, slotIndex] : (weaponType == WeaponTypes.TwoHanded ? weaponAddresses[1, slotIndex] : weaponAddresses[0, slotIndex])) + index, SeekOrigin.Begin);
                    bw.Write(level == 0 ? 0xFF : level-1);
                }
            }
        }

        public void SaveRecoverys(int index, byte value)
        {
            using (MemoryStream ms = new MemoryStream(save))
            {
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    ms.Seek(index <= 2 ? recoverysStartAddresses[slotIndex] + index : (index > 2 && index <= 10 ? recoverysStartAddresses[slotIndex] + 18 + index : (index < 12 ? recoverysStartAddresses[slotIndex] + 18 + 2 + index : recoverysStartAddresses[slotIndex] + 18 + 2 + 1 + index)), SeekOrigin.Begin);
                    bw.Write(value);
                }
            }
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
                    level = Array.IndexOf(levelToExp, exp);
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

        public byte GetRecoveryItemValue(int index)
        {
            byte value;
            using (MemoryStream ms = new MemoryStream(save))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    ms.Seek(index <= 2 ? recoverysStartAddresses[slotIndex] + index : (index > 2 && index <= 10 ? recoverysStartAddresses[slotIndex] + 18 + index: (index < 12 ? recoverysStartAddresses[slotIndex] + 18 + 2 + index: recoverysStartAddresses[slotIndex] + 18 + 2 + 1 + index)), SeekOrigin.Begin);
                    value = br.ReadByte();
                }
            }
            return value;
        }

        public byte IsWeaponOwned(WeaponTypes weaponType, int index)
        {
            byte weaponLvl;
            using (MemoryStream ms = new MemoryStream(save))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    ms.Seek((weaponType == WeaponTypes.Spear ? weaponAddresses[2, slotIndex] : (weaponType == WeaponTypes.TwoHanded ? weaponAddresses[1, slotIndex] : weaponAddresses[0, slotIndex])) + index, SeekOrigin.Begin);
                    weaponLvl = br.ReadByte();
                }
            }
            return (byte)(weaponLvl == 0xFF ? 0 : weaponLvl + 1);
        }
    }
}
