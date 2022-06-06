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
        private Save save;

        public Main()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeSave();
            UpdateGUI();
            UpdateCharacterGUI();
        }

        private void InitializeSave()
        {
            if (GetSavePath() != String.Empty)
            {
                SetSave();
            }
            else
            {
                OpenDialog();
            }
        }

        private void SetSave()
        {
            Save.SavePath = GetSavePath();
            save = new Save(SlotComboBox.SelectedIndex);
        }

        private void UpdateCharacterGUI()
        {
            CharacterNameTextBox.Text = save.Name;
            NumericMoney.Value = save.Money;
            NumericLevel.Value = save.Level;
            checkSumText.Text = save.Checksum.ToString();
            CorruptionTextBox.Text = save.Corruption.ToString();
        }

        private void InitializeComboBox()
        {
            string[] slots = new string[] { "Slot 1", "Slot 2", "Slot 3" };
            SlotComboBox.Items.AddRange(slots);
            SlotComboBox.SelectedIndex = 0;
        }

        private void UpdateGUI()
        {
            PathTextBox.Text = Save.SavePath;
            SaveButton.Enabled = Save.IsLoaded;
        }

        private string GetSavePath()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"My Games\NieR Replicant ver.1.22474487139\Steam");
            path = Directory.GetDirectories(path, "*")[0] + @"\GAMEDATA";
            if (!File.Exists(path))
                return String.Empty;
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
                    if (fileDialog.OpenFile().Length != Save.SaveSize)
                    {
                        MessageBox.Show("Cannot open save. Save may be corrupt!");
                        return;
                    }
                    Save.SavePath = fileDialog.FileName;
                    save = new Save(SlotComboBox.SelectedIndex);
                    UpdateGUI();
                    UpdateCharacterGUI();
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
            {
                save = new Save(SlotComboBox.SelectedIndex);
                UpdateCharacterGUI();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Save.IsLoaded)
            {
                save.SaveSlot(CharacterNameTextBox.Text, (int)NumericMoney.Value, (int)NumericLevel.Value);
                UpdateCharacterGUI();
            }
        }
    }
}
