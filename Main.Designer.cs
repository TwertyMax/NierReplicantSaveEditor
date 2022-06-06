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
            this.CharacterNameText = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.SlotComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Money = new System.Windows.Forms.Label();
            this.checkSumText = new System.Windows.Forms.TextBox();
            this.Checksum = new System.Windows.Forms.Label();
            this.NumericMoney = new System.Windows.Forms.NumericUpDown();
            this.CorruptionTextBox = new System.Windows.Forms.TextBox();
            this.CorruptionText = new System.Windows.Forms.Label();
            this.NumericLevel = new System.Windows.Forms.NumericUpDown();
            this.LevelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(39, 14);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(374, 20);
            this.PathTextBox.TabIndex = 0;
            // 
            // ChangePath
            // 
            this.ChangePath.Location = new System.Drawing.Point(419, 12);
            this.ChangePath.Name = "ChangePath";
            this.ChangePath.Size = new System.Drawing.Size(87, 22);
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
            // CharacterNameText
            // 
            this.CharacterNameText.AutoSize = true;
            this.CharacterNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharacterNameText.Location = new System.Drawing.Point(186, 106);
            this.CharacterNameText.Name = "CharacterNameText";
            this.CharacterNameText.Size = new System.Drawing.Size(125, 20);
            this.CharacterNameText.TabIndex = 4;
            this.CharacterNameText.Text = "Character Name";
            this.CharacterNameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Location = new System.Drawing.Point(190, 129);
            this.CharacterNameTextBox.MaxLength = 32;
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.CharacterNameTextBox.TabIndex = 5;
            // 
            // SlotComboBox
            // 
            this.SlotComboBox.FormattingEnabled = true;
            this.SlotComboBox.Location = new System.Drawing.Point(190, 40);
            this.SlotComboBox.Name = "SlotComboBox";
            this.SlotComboBox.Size = new System.Drawing.Size(121, 21);
            this.SlotComboBox.TabIndex = 6;
            this.SlotComboBox.SelectedIndexChanged += new System.EventHandler(this.SlotComboBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(419, 437);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Money.Location = new System.Drawing.Point(220, 160);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(56, 20);
            this.Money.TabIndex = 8;
            this.Money.Text = "Money";
            this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkSumText
            // 
            this.checkSumText.Location = new System.Drawing.Point(190, 352);
            this.checkSumText.Name = "checkSumText";
            this.checkSumText.ReadOnly = true;
            this.checkSumText.Size = new System.Drawing.Size(121, 20);
            this.checkSumText.TabIndex = 11;
            // 
            // Checksum
            // 
            this.Checksum.AutoSize = true;
            this.Checksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Checksum.Location = new System.Drawing.Point(190, 329);
            this.Checksum.Name = "Checksum";
            this.Checksum.Size = new System.Drawing.Size(84, 20);
            this.Checksum.TabIndex = 10;
            this.Checksum.Text = "Checksum";
            this.Checksum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericMoney
            // 
            this.NumericMoney.Location = new System.Drawing.Point(190, 183);
            this.NumericMoney.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumericMoney.Name = "NumericMoney";
            this.NumericMoney.Size = new System.Drawing.Size(121, 20);
            this.NumericMoney.TabIndex = 12;
            // 
            // CorruptionTextBox
            // 
            this.CorruptionTextBox.Location = new System.Drawing.Point(190, 293);
            this.CorruptionTextBox.Name = "CorruptionTextBox";
            this.CorruptionTextBox.ReadOnly = true;
            this.CorruptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.CorruptionTextBox.TabIndex = 14;
            // 
            // CorruptionText
            // 
            this.CorruptionText.AutoSize = true;
            this.CorruptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorruptionText.Location = new System.Drawing.Point(190, 270);
            this.CorruptionText.Name = "CorruptionText";
            this.CorruptionText.Size = new System.Drawing.Size(83, 20);
            this.CorruptionText.TabIndex = 13;
            this.CorruptionText.Text = "Corruption";
            this.CorruptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericLevel
            // 
            this.NumericLevel.Location = new System.Drawing.Point(190, 238);
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
            this.LevelText.Location = new System.Drawing.Point(220, 215);
            this.LevelText.Name = "LevelText";
            this.LevelText.Size = new System.Drawing.Size(46, 20);
            this.LevelText.TabIndex = 15;
            this.LevelText.Text = "Level";
            this.LevelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 472);
            this.Controls.Add(this.NumericLevel);
            this.Controls.Add(this.LevelText);
            this.Controls.Add(this.CorruptionTextBox);
            this.Controls.Add(this.CorruptionText);
            this.Controls.Add(this.NumericMoney);
            this.Controls.Add(this.checkSumText);
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
            this.Name = "Main";
            this.Text = "NieR Replicant Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NumericMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button ChangePath;
        private System.Windows.Forms.Label PathText;
        private System.Windows.Forms.Label CharacterNameText;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.ComboBox SlotComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.TextBox checkSumText;
        private System.Windows.Forms.Label Checksum;
        private System.Windows.Forms.NumericUpDown NumericMoney;
        private System.Windows.Forms.TextBox CorruptionTextBox;
        private System.Windows.Forms.Label CorruptionText;
        private System.Windows.Forms.NumericUpDown NumericLevel;
        private System.Windows.Forms.Label LevelText;
    }
}

