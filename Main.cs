using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NieR_Replicant_Save_Editor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (!String.IsNullOrEmpty(GetSavePath()))
                InitializeSave();
            UpdateGUI();
            UpdateSaveGUI();
        }

        private void InitializeSave(string savePath = null)
        {
            if (!Save.IsLoaded)
                InitializeComboBoxs();
            new Save(SlotComboBox.SelectedIndex == -1 ? 0 : SlotComboBox.SelectedIndex, !String.IsNullOrEmpty(savePath) ? savePath : (GetSavePath() != String.Empty ? GetSavePath() : null));
            UpdateGUI();
            UpdateSaveGUI();
        }

        public void UpdateSaveGUI()
        {
            CharacterNameTextBox.Enabled = Save.IsLoaded;
            NumericMoney.Enabled = Save.IsLoaded;
            NumericLevel.Enabled = Save.IsLoaded;
            ChecksumTextBox.Enabled = Save.IsLoaded;
            CorruptionTextBox.Enabled = Save.IsLoaded;

            OneHandedSwordsComboBox.Enabled = Save.IsLoaded;
            TwoHandedSwordsComboBox.Enabled = Save.IsLoaded;
            SpearWeaponsComboBox.Enabled = Save.IsLoaded;

            OneHandedWeaponsLevelComboBox.Enabled = Save.IsLoaded;
            TwoHandedSwordsLevelComboBox.Enabled = Save.IsLoaded;
            SpearWeaponsLevelComboBox.Enabled = Save.IsLoaded;

            RecoverysComboBox.Enabled = Save.IsLoaded;
            RecoverysValueNumeric.Enabled = Save.IsLoaded;
            SetRecoverys.Enabled = Save.IsLoaded;
            if (Save.IsLoaded)
            {
                CharacterNameTextBox.Text = Save.instance.Name;
                NumericMoney.Value = Save.instance.Money;
                NumericLevel.Value = Save.instance.Level;
                CorruptionTextBox.Text = Save.instance.Corruption.ToString();
                ChecksumTextBox.Text = Save.instance.Checksum.ToString();

                RecoverysComboBox.SelectedIndex = 0;

                OneHandedSwordsComboBox.SelectedIndex = 0;
                TwoHandedSwordsComboBox.SelectedIndex = 0;
                SpearWeaponsComboBox.SelectedIndex = 0;

                OneHandedWeaponsLevelComboBox.SelectedIndex = Save.instance.IsWeaponOwned(WeaponTypes.OneHanded, OneHandedSwordsComboBox.SelectedIndex);
                TwoHandedSwordsLevelComboBox.SelectedIndex = Save.instance.IsWeaponOwned(WeaponTypes.TwoHanded, TwoHandedSwordsComboBox.SelectedIndex);
                SpearWeaponsLevelComboBox.SelectedIndex = Save.instance.IsWeaponOwned(WeaponTypes.Spear, SpearWeaponsComboBox.SelectedIndex);

                RecoverysValueNumeric.Value = Save.instance.GetRecoveryItemValue(RecoverysComboBox.SelectedIndex);
            }
        }

        public void InitializeComboBoxs()
        {
            SlotComboBox.Items.AddRange(Save.slots);
            SlotComboBox.SelectedIndex = 0;

            OneHandedSwordsComboBox.Items.AddRange(Save.oneHandedWeapons);
            TwoHandedSwordsComboBox.Items.AddRange(Save.twoHandedWeapons);
            SpearWeaponsComboBox.Items.AddRange(Save.spearWeapons);

            OneHandedWeaponsLevelComboBox.Items.AddRange(Save.weaponsLevel);
            TwoHandedSwordsLevelComboBox.Items.AddRange(Save.weaponsLevel);
            SpearWeaponsLevelComboBox.Items.AddRange(Save.weaponsLevel);

            RecoverysComboBox.Items.AddRange(Save.recoverys);
        }

        public void UpdateGUI()
        {
            PathTextBox.Text = Save.SavePath;
            SaveButton.Enabled = Save.IsLoaded;
            SlotComboBox.Enabled = Save.IsLoaded;

            AddOneHandedWeapons.Enabled = Save.IsLoaded;
            AddTwoHandedSwords.Enabled = Save.IsLoaded;
            AddSpearWeapons.Enabled = Save.IsLoaded;
        }

        private string GetSavePath()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"My Games\NieR Replicant ver.1.22474487139\Steam");
            try
            {
                path = Directory.GetDirectories(path, "*")[0] + @"\GAMEDATA";
                if (!File.Exists(path))
                    throw new FileNotFoundException();
            }
            catch
            {
                return String.Empty;
            }
            return path;
        }

        private void OpenDialog()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                fileDialog.Filter = "All files (*.*)|*.*";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (new FileInfo(fileDialog.FileName).Length != Save.SaveSize)
                    {
                        MessageBox.Show("File length does not match. Save may be corrupt!");
                        return;
                    }
                    InitializeSave(fileDialog.FileName);
                }
            }
        }

        private void ChangePath_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        private void SlotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Save.IsLoaded)
                InitializeSave();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Save.IsLoaded)
            {
                Save.instance.SaveSlot(CharacterNameTextBox.Text, (int)NumericMoney.Value, (int)NumericLevel.Value);
                InitializeSave();
            }
        }

        private void OneHandedSwordsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OneHandedWeaponsLevelComboBox.SelectedIndex = Save.instance.IsWeaponOwned(WeaponTypes.OneHanded, OneHandedSwordsComboBox.SelectedIndex);
        }

        private void TwoHandedSwordsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TwoHandedSwordsLevelComboBox.SelectedIndex = Save.instance.IsWeaponOwned(WeaponTypes.TwoHanded, TwoHandedSwordsComboBox.SelectedIndex);
        }

        private void SpearWeaponsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpearWeaponsLevelComboBox.SelectedIndex = Save.instance.IsWeaponOwned(WeaponTypes.Spear, SpearWeaponsComboBox.SelectedIndex);
        }

        private void AddOneHandedWeapons_Click(object sender, EventArgs e)
        {
            Save.instance.SaveWeaponLevel(WeaponTypes.OneHanded, OneHandedSwordsComboBox.SelectedIndex, (byte)OneHandedWeaponsLevelComboBox.SelectedIndex);
        }

        private void AddTwoHandedSwords_Click(object sender, EventArgs e)
        {
            Save.instance.SaveWeaponLevel(WeaponTypes.TwoHanded, TwoHandedSwordsComboBox.SelectedIndex, (byte)TwoHandedSwordsLevelComboBox.SelectedIndex);
        }

        private void AddSpearWeapons_Click(object sender, EventArgs e)
        {
            Save.instance.SaveWeaponLevel(WeaponTypes.Spear, SpearWeaponsComboBox.SelectedIndex, (byte)SpearWeaponsLevelComboBox.SelectedIndex);
        }

        private void RecoverysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecoverysValueNumeric.Value = Save.instance.GetRecoveryItemValue(RecoverysComboBox.SelectedIndex);
        }

        private void SetRecoverys_Click(object sender, EventArgs e)
        {
            Save.instance.SaveRecoverys(RecoverysComboBox.SelectedIndex, (byte)RecoverysValueNumeric.Value);
        }
    }
}
