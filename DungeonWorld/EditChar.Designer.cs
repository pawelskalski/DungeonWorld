namespace DungeonWorld
{
    partial class FormEditChar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtHealthInput = new System.Windows.Forms.NumericUpDown();
            this.btnSaveChar = new System.Windows.Forms.Button();
            this.ListCharAtr = new System.Windows.Forms.ComboBox();
            this.ListWisAtr = new System.Windows.Forms.ComboBox();
            this.ListIntAtr = new System.Windows.Forms.ComboBox();
            this.ListConAtr = new System.Windows.Forms.ComboBox();
            this.ListDexAtr = new System.Windows.Forms.ComboBox();
            this.ListStrAtr = new System.Windows.Forms.ComboBox();
            this.txtCharLabel = new System.Windows.Forms.TextBox();
            this.txtWisLabel = new System.Windows.Forms.TextBox();
            this.txtIntLabel = new System.Windows.Forms.TextBox();
            this.txtConLabel = new System.Windows.Forms.TextBox();
            this.txtDexLabel = new System.Windows.Forms.TextBox();
            this.txtStrLabel = new System.Windows.Forms.TextBox();
            this.ListDmgInput = new System.Windows.Forms.ComboBox();
            this.txtDamageLabel = new System.Windows.Forms.TextBox();
            this.txtHealthLabel = new System.Windows.Forms.TextBox();
            this.ListClassInput = new System.Windows.Forms.ComboBox();
            this.txtClassLabel = new System.Windows.Forms.TextBox();
            this.ListRaceInput = new System.Windows.Forms.ComboBox();
            this.txtRaceLabel = new System.Windows.Forms.TextBox();
            this.txtNameLabel = new System.Windows.Forms.TextBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtHealthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 52;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtHealthInput
            // 
            this.txtHealthInput.Location = new System.Drawing.Point(566, 187);
            this.txtHealthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHealthInput.Name = "txtHealthInput";
            this.txtHealthInput.Size = new System.Drawing.Size(120, 20);
            this.txtHealthInput.TabIndex = 51;
            this.txtHealthInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveChar
            // 
            this.btnSaveChar.Location = new System.Drawing.Point(713, 415);
            this.btnSaveChar.Name = "btnSaveChar";
            this.btnSaveChar.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChar.TabIndex = 50;
            this.btnSaveChar.Text = "Zapisz";
            this.btnSaveChar.UseVisualStyleBackColor = true;
            this.btnSaveChar.Click += new System.EventHandler(this.btnSaveChar_Click);
            // 
            // ListCharAtr
            // 
            this.ListCharAtr.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListCharAtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListCharAtr.FormattingEnabled = true;
            this.ListCharAtr.Location = new System.Drawing.Point(572, 360);
            this.ListCharAtr.Name = "ListCharAtr";
            this.ListCharAtr.Size = new System.Drawing.Size(54, 21);
            this.ListCharAtr.TabIndex = 49;
            // 
            // ListWisAtr
            // 
            this.ListWisAtr.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListWisAtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListWisAtr.FormattingEnabled = true;
            this.ListWisAtr.Location = new System.Drawing.Point(466, 360);
            this.ListWisAtr.Name = "ListWisAtr";
            this.ListWisAtr.Size = new System.Drawing.Size(54, 21);
            this.ListWisAtr.TabIndex = 48;
            // 
            // ListIntAtr
            // 
            this.ListIntAtr.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListIntAtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListIntAtr.FormattingEnabled = true;
            this.ListIntAtr.Location = new System.Drawing.Point(360, 360);
            this.ListIntAtr.Name = "ListIntAtr";
            this.ListIntAtr.Size = new System.Drawing.Size(54, 21);
            this.ListIntAtr.TabIndex = 47;
            // 
            // ListConAtr
            // 
            this.ListConAtr.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListConAtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListConAtr.FormattingEnabled = true;
            this.ListConAtr.Location = new System.Drawing.Point(572, 283);
            this.ListConAtr.Name = "ListConAtr";
            this.ListConAtr.Size = new System.Drawing.Size(54, 21);
            this.ListConAtr.TabIndex = 46;
            // 
            // ListDexAtr
            // 
            this.ListDexAtr.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListDexAtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListDexAtr.FormattingEnabled = true;
            this.ListDexAtr.Location = new System.Drawing.Point(466, 283);
            this.ListDexAtr.Name = "ListDexAtr";
            this.ListDexAtr.Size = new System.Drawing.Size(54, 21);
            this.ListDexAtr.TabIndex = 45;
            // 
            // ListStrAtr
            // 
            this.ListStrAtr.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListStrAtr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListStrAtr.FormattingEnabled = true;
            this.ListStrAtr.Location = new System.Drawing.Point(360, 283);
            this.ListStrAtr.Name = "ListStrAtr";
            this.ListStrAtr.Size = new System.Drawing.Size(54, 21);
            this.ListStrAtr.TabIndex = 44;
            // 
            // txtCharLabel
            // 
            this.txtCharLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtCharLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCharLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCharLabel.Location = new System.Drawing.Point(572, 341);
            this.txtCharLabel.Name = "txtCharLabel";
            this.txtCharLabel.ReadOnly = true;
            this.txtCharLabel.Size = new System.Drawing.Size(100, 13);
            this.txtCharLabel.TabIndex = 43;
            this.txtCharLabel.Text = "Charyzma";
            // 
            // txtWisLabel
            // 
            this.txtWisLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtWisLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWisLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWisLabel.Location = new System.Drawing.Point(466, 341);
            this.txtWisLabel.Name = "txtWisLabel";
            this.txtWisLabel.ReadOnly = true;
            this.txtWisLabel.Size = new System.Drawing.Size(100, 13);
            this.txtWisLabel.TabIndex = 42;
            this.txtWisLabel.Text = "Wiedza";
            // 
            // txtIntLabel
            // 
            this.txtIntLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtIntLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIntLabel.Location = new System.Drawing.Point(360, 341);
            this.txtIntLabel.Name = "txtIntLabel";
            this.txtIntLabel.ReadOnly = true;
            this.txtIntLabel.Size = new System.Drawing.Size(100, 13);
            this.txtIntLabel.TabIndex = 41;
            this.txtIntLabel.Text = "Inteligencja";
            // 
            // txtConLabel
            // 
            this.txtConLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtConLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConLabel.Location = new System.Drawing.Point(572, 264);
            this.txtConLabel.Name = "txtConLabel";
            this.txtConLabel.ReadOnly = true;
            this.txtConLabel.Size = new System.Drawing.Size(100, 13);
            this.txtConLabel.TabIndex = 40;
            this.txtConLabel.Text = "Wytrzymałość";
            // 
            // txtDexLabel
            // 
            this.txtDexLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtDexLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDexLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDexLabel.Location = new System.Drawing.Point(466, 264);
            this.txtDexLabel.Name = "txtDexLabel";
            this.txtDexLabel.ReadOnly = true;
            this.txtDexLabel.Size = new System.Drawing.Size(100, 13);
            this.txtDexLabel.TabIndex = 39;
            this.txtDexLabel.Text = "Zręczność";
            // 
            // txtStrLabel
            // 
            this.txtStrLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStrLabel.Location = new System.Drawing.Point(360, 264);
            this.txtStrLabel.Name = "txtStrLabel";
            this.txtStrLabel.ReadOnly = true;
            this.txtStrLabel.Size = new System.Drawing.Size(100, 13);
            this.txtStrLabel.TabIndex = 38;
            this.txtStrLabel.Text = "Siła";
            // 
            // ListDmgInput
            // 
            this.ListDmgInput.AutoCompleteCustomSource.AddRange(new string[] {
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.ListDmgInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListDmgInput.FormattingEnabled = true;
            this.ListDmgInput.Location = new System.Drawing.Point(360, 186);
            this.ListDmgInput.Name = "ListDmgInput";
            this.ListDmgInput.Size = new System.Drawing.Size(121, 21);
            this.ListDmgInput.TabIndex = 37;
            // 
            // txtDamageLabel
            // 
            this.txtDamageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtDamageLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDamageLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDamageLabel.Location = new System.Drawing.Point(360, 167);
            this.txtDamageLabel.Name = "txtDamageLabel";
            this.txtDamageLabel.ReadOnly = true;
            this.txtDamageLabel.Size = new System.Drawing.Size(100, 13);
            this.txtDamageLabel.TabIndex = 36;
            this.txtDamageLabel.Text = "Obrażenia";
            // 
            // txtHealthLabel
            // 
            this.txtHealthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHealthLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHealthLabel.Location = new System.Drawing.Point(566, 167);
            this.txtHealthLabel.Name = "txtHealthLabel";
            this.txtHealthLabel.ReadOnly = true;
            this.txtHealthLabel.Size = new System.Drawing.Size(121, 13);
            this.txtHealthLabel.TabIndex = 35;
            this.txtHealthLabel.Text = "Punkty życia";
            // 
            // ListClassInput
            // 
            this.ListClassInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListClassInput.FormattingEnabled = true;
            this.ListClassInput.Location = new System.Drawing.Point(360, 129);
            this.ListClassInput.Name = "ListClassInput";
            this.ListClassInput.Size = new System.Drawing.Size(121, 21);
            this.ListClassInput.TabIndex = 34;
            // 
            // txtClassLabel
            // 
            this.txtClassLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClassLabel.Location = new System.Drawing.Point(360, 110);
            this.txtClassLabel.Name = "txtClassLabel";
            this.txtClassLabel.ReadOnly = true;
            this.txtClassLabel.Size = new System.Drawing.Size(100, 13);
            this.txtClassLabel.TabIndex = 33;
            this.txtClassLabel.Text = "Klasa";
            // 
            // ListRaceInput
            // 
            this.ListRaceInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListRaceInput.FormattingEnabled = true;
            this.ListRaceInput.Location = new System.Drawing.Point(567, 72);
            this.ListRaceInput.Name = "ListRaceInput";
            this.ListRaceInput.Size = new System.Drawing.Size(121, 21);
            this.ListRaceInput.TabIndex = 32;
            // 
            // txtRaceLabel
            // 
            this.txtRaceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtRaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRaceLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRaceLabel.Location = new System.Drawing.Point(567, 54);
            this.txtRaceLabel.Name = "txtRaceLabel";
            this.txtRaceLabel.ReadOnly = true;
            this.txtRaceLabel.Size = new System.Drawing.Size(100, 13);
            this.txtRaceLabel.TabIndex = 31;
            this.txtRaceLabel.Text = "Rasa";
            // 
            // txtNameLabel
            // 
            this.txtNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNameLabel.Location = new System.Drawing.Point(360, 54);
            this.txtNameLabel.Name = "txtNameLabel";
            this.txtNameLabel.ReadOnly = true;
            this.txtNameLabel.Size = new System.Drawing.Size(100, 13);
            this.txtNameLabel.TabIndex = 30;
            this.txtNameLabel.Text = "Imię";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(360, 72);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(121, 20);
            this.txtNameInput.TabIndex = 29;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(67, 72);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(220, 269);
            this.imgAvatar.TabIndex = 28;
            this.imgAvatar.TabStop = false;
            // 
            // FormEditChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtHealthInput);
            this.Controls.Add(this.btnSaveChar);
            this.Controls.Add(this.ListCharAtr);
            this.Controls.Add(this.ListWisAtr);
            this.Controls.Add(this.ListIntAtr);
            this.Controls.Add(this.ListConAtr);
            this.Controls.Add(this.ListDexAtr);
            this.Controls.Add(this.ListStrAtr);
            this.Controls.Add(this.txtCharLabel);
            this.Controls.Add(this.txtWisLabel);
            this.Controls.Add(this.txtIntLabel);
            this.Controls.Add(this.txtConLabel);
            this.Controls.Add(this.txtDexLabel);
            this.Controls.Add(this.txtStrLabel);
            this.Controls.Add(this.ListDmgInput);
            this.Controls.Add(this.txtDamageLabel);
            this.Controls.Add(this.txtHealthLabel);
            this.Controls.Add(this.ListClassInput);
            this.Controls.Add(this.txtClassLabel);
            this.Controls.Add(this.ListRaceInput);
            this.Controls.Add(this.txtRaceLabel);
            this.Controls.Add(this.txtNameLabel);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.imgAvatar);
            this.Name = "FormEditChar";
            this.Text = "Edycja";
            ((System.ComponentModel.ISupportInitialize)(this.txtHealthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown txtHealthInput;
        private System.Windows.Forms.Button btnSaveChar;
        private System.Windows.Forms.ComboBox ListCharAtr;
        private System.Windows.Forms.ComboBox ListWisAtr;
        private System.Windows.Forms.ComboBox ListIntAtr;
        private System.Windows.Forms.ComboBox ListConAtr;
        private System.Windows.Forms.ComboBox ListDexAtr;
        private System.Windows.Forms.ComboBox ListStrAtr;
        private System.Windows.Forms.TextBox txtCharLabel;
        private System.Windows.Forms.TextBox txtWisLabel;
        private System.Windows.Forms.TextBox txtIntLabel;
        private System.Windows.Forms.TextBox txtConLabel;
        private System.Windows.Forms.TextBox txtDexLabel;
        private System.Windows.Forms.TextBox txtStrLabel;
        private System.Windows.Forms.ComboBox ListDmgInput;
        private System.Windows.Forms.TextBox txtDamageLabel;
        private System.Windows.Forms.TextBox txtHealthLabel;
        private System.Windows.Forms.ComboBox ListClassInput;
        private System.Windows.Forms.TextBox txtClassLabel;
        private System.Windows.Forms.ComboBox ListRaceInput;
        private System.Windows.Forms.TextBox txtRaceLabel;
        private System.Windows.Forms.TextBox txtNameLabel;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.PictureBox imgAvatar;
    }
}