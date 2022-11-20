namespace NieR_Replicant_Save_Editor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ChangePath = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.Label();
            this.SlotComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Checksum = new System.Windows.Forms.Label();
            this.NumericMoney = new System.Windows.Forms.NumericUpDown();
            this.CorruptionText = new System.Windows.Forms.Label();
            this.NumericLevel = new System.Windows.Forms.NumericUpDown();
            this.LevelText = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.Label();
            this.CharacterNameText = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.Money = new System.Windows.Forms.Label();
            this.SaveText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WeaponsText = new System.Windows.Forms.Label();
            this.OneHandedSwordsComboBox = new System.Windows.Forms.ComboBox();
            this.OneHandedSwordsText = new System.Windows.Forms.Label();
            this.TwoHandedSwordsText = new System.Windows.Forms.Label();
            this.TwoHandedSwordsComboBox = new System.Windows.Forms.ComboBox();
            this.SpearWeaponsText = new System.Windows.Forms.Label();
            this.SpearWeaponsComboBox = new System.Windows.Forms.ComboBox();
            this.AddOneHandedWeapons = new System.Windows.Forms.Button();
            this.AddTwoHandedSwords = new System.Windows.Forms.Button();
            this.AddSpearWeapons = new System.Windows.Forms.Button();
            this.OneHandedWeaponsLevelComboBox = new System.Windows.Forms.ComboBox();
            this.TwoHandedSwordsLevelComboBox = new System.Windows.Forms.ComboBox();
            this.SpearWeaponsLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RecoverysComboBox = new System.Windows.Forms.ComboBox();
            this.RecoverysValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.RecoverysText = new System.Windows.Forms.Label();
            this.RecoverysValueText = new System.Windows.Forms.Label();
            this.SetRecoverys = new System.Windows.Forms.Button();
            this.CorruptionTextBox = new System.Windows.Forms.TextBox();
            this.ChecksumTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecoverysValueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(39, 14);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(435, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // ChangePath
            // 
            this.ChangePath.Location = new System.Drawing.Point(480, 14);
            this.ChangePath.Name = "ChangePath";
            this.ChangePath.Size = new System.Drawing.Size(90, 22);
            this.ChangePath.TabIndex = 1;
            this.ChangePath.Text = "Change Path";
            this.ChangePath.UseVisualStyleBackColor = true;
            this.ChangePath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // PathText
            // 
            this.PathText.AutoSize = true;
            this.PathText.Location = new System.Drawing.Point(4, 17);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(29, 13);
            this.PathText.TabIndex = 2;
            this.PathText.Text = "Path";
            this.PathText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SlotComboBox
            // 
            this.SlotComboBox.FormattingEnabled = true;
            this.SlotComboBox.Location = new System.Drawing.Point(166, 122);
            this.SlotComboBox.Name = "SlotComboBox";
            this.SlotComboBox.Size = new System.Drawing.Size(121, 21);
            this.SlotComboBox.TabIndex = 6;
            this.SlotComboBox.Text = "NC";
            this.SlotComboBox.SelectedIndexChanged += new System.EventHandler(this.SlotComboBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(248, 436);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(90, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Checksum
            // 
            this.Checksum.AutoSize = true;
            this.Checksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Checksum.Location = new System.Drawing.Point(182, 203);
            this.Checksum.Name = "Checksum";
            this.Checksum.Size = new System.Drawing.Size(84, 20);
            this.Checksum.TabIndex = 10;
            this.Checksum.Text = "Checksum";
            this.Checksum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericMoney
            // 
            this.NumericMoney.Location = new System.Drawing.Point(29, 174);
            this.NumericMoney.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumericMoney.Name = "NumericMoney";
            this.NumericMoney.Size = new System.Drawing.Size(121, 20);
            this.NumericMoney.TabIndex = 12;
            // 
            // CorruptionText
            // 
            this.CorruptionText.AutoSize = true;
            this.CorruptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorruptionText.Location = new System.Drawing.Point(183, 153);
            this.CorruptionText.Name = "CorruptionText";
            this.CorruptionText.Size = new System.Drawing.Size(83, 20);
            this.CorruptionText.TabIndex = 13;
            this.CorruptionText.Text = "Corruption";
            this.CorruptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericLevel
            // 
            this.NumericLevel.Location = new System.Drawing.Point(29, 226);
            this.NumericLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumericLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericLevel.Name = "NumericLevel";
            this.NumericLevel.Size = new System.Drawing.Size(121, 20);
            this.NumericLevel.TabIndex = 16;
            this.NumericLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LevelText
            // 
            this.LevelText.AutoSize = true;
            this.LevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelText.Location = new System.Drawing.Point(59, 203);
            this.LevelText.Name = "LevelText";
            this.LevelText.Size = new System.Drawing.Size(46, 20);
            this.LevelText.TabIndex = 15;
            this.LevelText.Text = "Level";
            this.LevelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Character
            // 
            this.Character.AutoSize = true;
            this.Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Character.Location = new System.Drawing.Point(46, 65);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(79, 20);
            this.Character.TabIndex = 17;
            this.Character.Text = "Character";
            this.Character.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterNameText
            // 
            this.CharacterNameText.AutoSize = true;
            this.CharacterNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharacterNameText.Location = new System.Drawing.Point(59, 100);
            this.CharacterNameText.Name = "CharacterNameText";
            this.CharacterNameText.Size = new System.Drawing.Size(51, 20);
            this.CharacterNameText.TabIndex = 4;
            this.CharacterNameText.Text = "Name";
            this.CharacterNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(29, 123);
            this.CharacterNameTextBox.MaxLength = 10;
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.CharacterNameTextBox.TabIndex = 5;
            this.CharacterNameTextBox.Text = "---";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Money.Location = new System.Drawing.Point(59, 151);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(56, 20);
            this.Money.TabIndex = 8;
            this.Money.Text = "Money";
            this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveText
            // 
            this.SaveText.AutoSize = true;
            this.SaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveText.Location = new System.Drawing.Point(189, 65);
            this.SaveText.Name = "SaveText";
            this.SaveText.Size = new System.Drawing.Size(77, 20);
            this.SaveText.TabIndex = 18;
            this.SaveText.Text = "Save Info";
            this.SaveText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(207, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Slot";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeaponsText
            // 
            this.WeaponsText.AutoSize = true;
            this.WeaponsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeaponsText.Location = new System.Drawing.Point(322, 67);
            this.WeaponsText.Name = "WeaponsText";
            this.WeaponsText.Size = new System.Drawing.Size(77, 20);
            this.WeaponsText.TabIndex = 24;
            this.WeaponsText.Text = "Weapons";
            this.WeaponsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OneHandedSwordsComboBox
            // 
            this.OneHandedSwordsComboBox.FormattingEnabled = true;
            this.OneHandedSwordsComboBox.Location = new System.Drawing.Point(301, 123);
            this.OneHandedSwordsComboBox.Name = "OneHandedSwordsComboBox";
            this.OneHandedSwordsComboBox.Size = new System.Drawing.Size(121, 21);
            this.OneHandedSwordsComboBox.TabIndex = 25;
            this.OneHandedSwordsComboBox.Text = "NC";
            this.OneHandedSwordsComboBox.SelectedIndexChanged += new System.EventHandler(this.OneHandedSwordsComboBox_SelectedIndexChanged);
            // 
            // OneHandedSwordsText
            // 
            this.OneHandedSwordsText.AutoSize = true;
            this.OneHandedSwordsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneHandedSwordsText.Location = new System.Drawing.Point(284, 102);
            this.OneHandedSwordsText.Name = "OneHandedSwordsText";
            this.OneHandedSwordsText.Size = new System.Drawing.Size(157, 20);
            this.OneHandedSwordsText.TabIndex = 26;
            this.OneHandedSwordsText.Text = "One Handed Swords";
            this.OneHandedSwordsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoHandedSwordsText
            // 
            this.TwoHandedSwordsText.AutoSize = true;
            this.TwoHandedSwordsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoHandedSwordsText.Location = new System.Drawing.Point(284, 155);
            this.TwoHandedSwordsText.Name = "TwoHandedSwordsText";
            this.TwoHandedSwordsText.Size = new System.Drawing.Size(156, 20);
            this.TwoHandedSwordsText.TabIndex = 28;
            this.TwoHandedSwordsText.Text = "Two Handed Swords";
            this.TwoHandedSwordsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoHandedSwordsComboBox
            // 
            this.TwoHandedSwordsComboBox.FormattingEnabled = true;
            this.TwoHandedSwordsComboBox.Location = new System.Drawing.Point(301, 175);
            this.TwoHandedSwordsComboBox.Name = "TwoHandedSwordsComboBox";
            this.TwoHandedSwordsComboBox.Size = new System.Drawing.Size(121, 21);
            this.TwoHandedSwordsComboBox.TabIndex = 27;
            this.TwoHandedSwordsComboBox.Text = "NC";
            this.TwoHandedSwordsComboBox.SelectedIndexChanged += new System.EventHandler(this.TwoHandedSwordsComboBox_SelectedIndexChanged);
            // 
            // SpearWeaponsText
            // 
            this.SpearWeaponsText.AutoSize = true;
            this.SpearWeaponsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpearWeaponsText.Location = new System.Drawing.Point(302, 205);
            this.SpearWeaponsText.Name = "SpearWeaponsText";
            this.SpearWeaponsText.Size = new System.Drawing.Size(124, 20);
            this.SpearWeaponsText.TabIndex = 30;
            this.SpearWeaponsText.Text = "Spear Weapons";
            this.SpearWeaponsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpearWeaponsComboBox
            // 
            this.SpearWeaponsComboBox.FormattingEnabled = true;
            this.SpearWeaponsComboBox.Location = new System.Drawing.Point(301, 227);
            this.SpearWeaponsComboBox.Name = "SpearWeaponsComboBox";
            this.SpearWeaponsComboBox.Size = new System.Drawing.Size(121, 21);
            this.SpearWeaponsComboBox.TabIndex = 29;
            this.SpearWeaponsComboBox.Text = "NC";
            this.SpearWeaponsComboBox.SelectedIndexChanged += new System.EventHandler(this.SpearWeaponsComboBox_SelectedIndexChanged);
            // 
            // AddOneHandedWeapons
            // 
            this.AddOneHandedWeapons.Enabled = false;
            this.AddOneHandedWeapons.Location = new System.Drawing.Point(480, 122);
            this.AddOneHandedWeapons.Name = "AddOneHandedWeapons";
            this.AddOneHandedWeapons.Size = new System.Drawing.Size(90, 23);
            this.AddOneHandedWeapons.TabIndex = 31;
            this.AddOneHandedWeapons.Text = "Set";
            this.AddOneHandedWeapons.UseVisualStyleBackColor = true;
            this.AddOneHandedWeapons.Click += new System.EventHandler(this.AddOneHandedWeapons_Click);
            // 
            // AddTwoHandedSwords
            // 
            this.AddTwoHandedSwords.Enabled = false;
            this.AddTwoHandedSwords.Location = new System.Drawing.Point(480, 174);
            this.AddTwoHandedSwords.Name = "AddTwoHandedSwords";
            this.AddTwoHandedSwords.Size = new System.Drawing.Size(90, 23);
            this.AddTwoHandedSwords.TabIndex = 32;
            this.AddTwoHandedSwords.Text = "Set";
            this.AddTwoHandedSwords.UseVisualStyleBackColor = true;
            this.AddTwoHandedSwords.Click += new System.EventHandler(this.AddTwoHandedSwords_Click);
            // 
            // AddSpearWeapons
            // 
            this.AddSpearWeapons.Enabled = false;
            this.AddSpearWeapons.Location = new System.Drawing.Point(480, 226);
            this.AddSpearWeapons.Name = "AddSpearWeapons";
            this.AddSpearWeapons.Size = new System.Drawing.Size(90, 23);
            this.AddSpearWeapons.TabIndex = 33;
            this.AddSpearWeapons.Text = "Set";
            this.AddSpearWeapons.UseVisualStyleBackColor = true;
            this.AddSpearWeapons.Click += new System.EventHandler(this.AddSpearWeapons_Click);
            // 
            // OneHandedWeaponsLevelComboBox
            // 
            this.OneHandedWeaponsLevelComboBox.FormattingEnabled = true;
            this.OneHandedWeaponsLevelComboBox.Location = new System.Drawing.Point(428, 123);
            this.OneHandedWeaponsLevelComboBox.Name = "OneHandedWeaponsLevelComboBox";
            this.OneHandedWeaponsLevelComboBox.Size = new System.Drawing.Size(46, 21);
            this.OneHandedWeaponsLevelComboBox.TabIndex = 34;
            this.OneHandedWeaponsLevelComboBox.Text = "NC";
            // 
            // TwoHandedSwordsLevelComboBox
            // 
            this.TwoHandedSwordsLevelComboBox.FormattingEnabled = true;
            this.TwoHandedSwordsLevelComboBox.Location = new System.Drawing.Point(428, 175);
            this.TwoHandedSwordsLevelComboBox.Name = "TwoHandedSwordsLevelComboBox";
            this.TwoHandedSwordsLevelComboBox.Size = new System.Drawing.Size(46, 21);
            this.TwoHandedSwordsLevelComboBox.TabIndex = 35;
            this.TwoHandedSwordsLevelComboBox.Text = "NC";
            // 
            // SpearWeaponsLevelComboBox
            // 
            this.SpearWeaponsLevelComboBox.FormattingEnabled = true;
            this.SpearWeaponsLevelComboBox.Location = new System.Drawing.Point(428, 227);
            this.SpearWeaponsLevelComboBox.Name = "SpearWeaponsLevelComboBox";
            this.SpearWeaponsLevelComboBox.Size = new System.Drawing.Size(46, 21);
            this.SpearWeaponsLevelComboBox.TabIndex = 36;
            this.SpearWeaponsLevelComboBox.Text = "NC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(256, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Inventory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecoverysComboBox
            // 
            this.RecoverysComboBox.FormattingEnabled = true;
            this.RecoverysComboBox.Location = new System.Drawing.Point(235, 308);
            this.RecoverysComboBox.Name = "RecoverysComboBox";
            this.RecoverysComboBox.Size = new System.Drawing.Size(121, 21);
            this.RecoverysComboBox.TabIndex = 38;
            this.RecoverysComboBox.Text = "NC";
            this.RecoverysComboBox.SelectedIndexChanged += new System.EventHandler(this.RecoverysComboBox_SelectedIndexChanged);
            // 
            // RecoverysValueNumeric
            // 
            this.RecoverysValueNumeric.Location = new System.Drawing.Point(235, 364);
            this.RecoverysValueNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RecoverysValueNumeric.Name = "RecoverysValueNumeric";
            this.RecoverysValueNumeric.Size = new System.Drawing.Size(121, 20);
            this.RecoverysValueNumeric.TabIndex = 39;
            // 
            // RecoverysText
            // 
            this.RecoverysText.AutoSize = true;
            this.RecoverysText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecoverysText.Location = new System.Drawing.Point(252, 285);
            this.RecoverysText.Name = "RecoverysText";
            this.RecoverysText.Size = new System.Drawing.Size(83, 20);
            this.RecoverysText.TabIndex = 40;
            this.RecoverysText.Text = "Recoverys";
            this.RecoverysText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecoverysValueText
            // 
            this.RecoverysValueText.AutoSize = true;
            this.RecoverysValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecoverysValueText.Location = new System.Drawing.Point(266, 341);
            this.RecoverysValueText.Name = "RecoverysValueText";
            this.RecoverysValueText.Size = new System.Drawing.Size(50, 20);
            this.RecoverysValueText.TabIndex = 41;
            this.RecoverysValueText.Text = "Value";
            this.RecoverysValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetRecoverys
            // 
            this.SetRecoverys.Enabled = false;
            this.SetRecoverys.Location = new System.Drawing.Point(248, 391);
            this.SetRecoverys.Name = "SetRecoverys";
            this.SetRecoverys.Size = new System.Drawing.Size(90, 23);
            this.SetRecoverys.TabIndex = 42;
            this.SetRecoverys.Text = "Set";
            this.SetRecoverys.UseVisualStyleBackColor = true;
            this.SetRecoverys.Click += new System.EventHandler(this.SetRecoverys_Click);
            // 
            // CorruptionTextBox
            // 
            this.CorruptionTextBox.Location = new System.Drawing.Point(166, 175);
            this.CorruptionTextBox.MaxLength = 10;
            this.CorruptionTextBox.Name = "CorruptionTextBox";
            this.CorruptionTextBox.ReadOnly = true;
            this.CorruptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.CorruptionTextBox.TabIndex = 43;
            this.CorruptionTextBox.Text = "---";
            // 
            // ChecksumTextBox
            // 
            this.ChecksumTextBox.Location = new System.Drawing.Point(166, 227);
            this.ChecksumTextBox.MaxLength = 10;
            this.ChecksumTextBox.Name = "ChecksumTextBox";
            this.ChecksumTextBox.ReadOnly = true;
            this.ChecksumTextBox.Size = new System.Drawing.Size(121, 20);
            this.ChecksumTextBox.TabIndex = 44;
            this.ChecksumTextBox.Text = "---";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 471);
            this.Controls.Add(this.ChecksumTextBox);
            this.Controls.Add(this.CorruptionTextBox);
            this.Controls.Add(this.SetRecoverys);
            this.Controls.Add(this.RecoverysValueText);
            this.Controls.Add(this.RecoverysText);
            this.Controls.Add(this.RecoverysValueNumeric);
            this.Controls.Add(this.RecoverysComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpearWeaponsLevelComboBox);
            this.Controls.Add(this.TwoHandedSwordsLevelComboBox);
            this.Controls.Add(this.OneHandedWeaponsLevelComboBox);
            this.Controls.Add(this.AddSpearWeapons);
            this.Controls.Add(this.AddTwoHandedSwords);
            this.Controls.Add(this.AddOneHandedWeapons);
            this.Controls.Add(this.SpearWeaponsText);
            this.Controls.Add(this.SpearWeaponsComboBox);
            this.Controls.Add(this.TwoHandedSwordsText);
            this.Controls.Add(this.TwoHandedSwordsComboBox);
            this.Controls.Add(this.OneHandedSwordsText);
            this.Controls.Add(this.OneHandedSwordsComboBox);
            this.Controls.Add(this.WeaponsText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveText);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.NumericLevel);
            this.Controls.Add(this.LevelText);
            this.Controls.Add(this.CorruptionText);
            this.Controls.Add(this.NumericMoney);
            this.Controls.Add(this.Checksum);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SlotComboBox);
            this.Controls.Add(this.CharacterNameTextBox);
            this.Controls.Add(this.CharacterNameText);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.ChangePath);
            this.Controls.Add(this.PathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "NieR Replicant Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NumericMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecoverysValueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button ChangePath;
        private System.Windows.Forms.Label PathText;
        private System.Windows.Forms.ComboBox SlotComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Checksum;
        private System.Windows.Forms.NumericUpDown NumericMoney;
        private System.Windows.Forms.Label CorruptionText;
        private System.Windows.Forms.NumericUpDown NumericLevel;
        private System.Windows.Forms.Label LevelText;
        private System.Windows.Forms.Label Character;
        private System.Windows.Forms.Label CharacterNameText;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label SaveText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WeaponsText;
        private System.Windows.Forms.ComboBox OneHandedSwordsComboBox;
        private System.Windows.Forms.Label OneHandedSwordsText;
        private System.Windows.Forms.Label TwoHandedSwordsText;
        private System.Windows.Forms.ComboBox TwoHandedSwordsComboBox;
        private System.Windows.Forms.Label SpearWeaponsText;
        private System.Windows.Forms.ComboBox SpearWeaponsComboBox;
        private System.Windows.Forms.Button AddOneHandedWeapons;
        private System.Windows.Forms.Button AddTwoHandedSwords;
        private System.Windows.Forms.Button AddSpearWeapons;
        private System.Windows.Forms.ComboBox OneHandedWeaponsLevelComboBox;
        private System.Windows.Forms.ComboBox TwoHandedSwordsLevelComboBox;
        private System.Windows.Forms.ComboBox SpearWeaponsLevelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox RecoverysComboBox;
        private System.Windows.Forms.NumericUpDown RecoverysValueNumeric;
        private System.Windows.Forms.Label RecoverysText;
        private System.Windows.Forms.Label RecoverysValueText;
        private System.Windows.Forms.Button SetRecoverys;
        private System.Windows.Forms.TextBox CorruptionTextBox;
        private System.Windows.Forms.TextBox ChecksumTextBox;
    }
}

