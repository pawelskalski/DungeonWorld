namespace DungeonWorld
{
    partial class FormCreateChar
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
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtNameLabel = new System.Windows.Forms.TextBox();
            this.txtRaceLabel = new System.Windows.Forms.TextBox();
            this.ListRaceInput = new System.Windows.Forms.ComboBox();
            this.txtClassLabel = new System.Windows.Forms.TextBox();
            this.ListClassInput = new System.Windows.Forms.ComboBox();
            this.txtHealthLabel = new System.Windows.Forms.TextBox();
            this.txtDamageLabel = new System.Windows.Forms.TextBox();
            this.ListDmgInput = new System.Windows.Forms.ComboBox();
            this.txtStrLabel = new System.Windows.Forms.TextBox();
            this.txtDexLabel = new System.Windows.Forms.TextBox();
            this.txtConLabel = new System.Windows.Forms.TextBox();
            this.txtIntLabel = new System.Windows.Forms.TextBox();
            this.txtWisLabel = new System.Windows.Forms.TextBox();
            this.txtCharLabel = new System.Windows.Forms.TextBox();
            this.ListStrAtr = new System.Windows.Forms.ComboBox();
            this.ListDexAtr = new System.Windows.Forms.ComboBox();
            this.ListConAtr = new System.Windows.Forms.ComboBox();
            this.ListIntAtr = new System.Windows.Forms.ComboBox();
            this.ListWisAtr = new System.Windows.Forms.ComboBox();
            this.ListCharAtr = new System.Windows.Forms.ComboBox();
            this.btnCreateChar = new System.Windows.Forms.Button();
            this.txtHealthInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHealthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(70, 72);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(220, 269);
            this.imgAvatar.TabIndex = 0;
            this.imgAvatar.TabStop = false;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(363, 72);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(121, 20);
            this.txtNameInput.TabIndex = 1;
            // 
            // txtNameLabel
            // 
            this.txtNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNameLabel.Location = new System.Drawing.Point(363, 54);
            this.txtNameLabel.Name = "txtNameLabel";
            this.txtNameLabel.ReadOnly = true;
            this.txtNameLabel.Size = new System.Drawing.Size(100, 13);
            this.txtNameLabel.TabIndex = 2;
            this.txtNameLabel.Text = "Imię";
            // 
            // txtRaceLabel
            // 
            this.txtRaceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtRaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRaceLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRaceLabel.Location = new System.Drawing.Point(570, 54);
            this.txtRaceLabel.Name = "txtRaceLabel";
            this.txtRaceLabel.ReadOnly = true;
            this.txtRaceLabel.Size = new System.Drawing.Size(100, 13);
            this.txtRaceLabel.TabIndex = 3;
            this.txtRaceLabel.Text = "Rasa";
            // 
            // ListRaceInput
            // 
            this.ListRaceInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListRaceInput.FormattingEnabled = true;
            this.ListRaceInput.Location = new System.Drawing.Point(570, 72);
            this.ListRaceInput.Name = "ListRaceInput";
            this.ListRaceInput.Size = new System.Drawing.Size(121, 21);
            this.ListRaceInput.TabIndex = 5;
            // 
            // txtClassLabel
            // 
            this.txtClassLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClassLabel.Location = new System.Drawing.Point(363, 110);
            this.txtClassLabel.Name = "txtClassLabel";
            this.txtClassLabel.ReadOnly = true;
            this.txtClassLabel.Size = new System.Drawing.Size(100, 13);
            this.txtClassLabel.TabIndex = 6;
            this.txtClassLabel.Text = "Klasa";
            // 
            // ListClassInput
            // 
            this.ListClassInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListClassInput.FormattingEnabled = true;
            this.ListClassInput.Location = new System.Drawing.Point(363, 129);
            this.ListClassInput.Name = "ListClassInput";
            this.ListClassInput.Size = new System.Drawing.Size(121, 21);
            this.ListClassInput.TabIndex = 7;
            // 
            // txtHealthLabel
            // 
            this.txtHealthLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtHealthLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHealthLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHealthLabel.Location = new System.Drawing.Point(570, 167);
            this.txtHealthLabel.Name = "txtHealthLabel";
            this.txtHealthLabel.ReadOnly = true;
            this.txtHealthLabel.Size = new System.Drawing.Size(121, 13);
            this.txtHealthLabel.TabIndex = 8;
            this.txtHealthLabel.Text = "Punkty życia";
            // 
            // txtDamageLabel
            // 
            this.txtDamageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtDamageLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDamageLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDamageLabel.Location = new System.Drawing.Point(363, 167);
            this.txtDamageLabel.Name = "txtDamageLabel";
            this.txtDamageLabel.ReadOnly = true;
            this.txtDamageLabel.Size = new System.Drawing.Size(100, 13);
            this.txtDamageLabel.TabIndex = 11;
            this.txtDamageLabel.Text = "Obrażenia";
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
            this.ListDmgInput.Location = new System.Drawing.Point(363, 186);
            this.ListDmgInput.Name = "ListDmgInput";
            this.ListDmgInput.Size = new System.Drawing.Size(121, 21);
            this.ListDmgInput.TabIndex = 12;
            // 
            // txtStrLabel
            // 
            this.txtStrLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStrLabel.Location = new System.Drawing.Point(363, 264);
            this.txtStrLabel.Name = "txtStrLabel";
            this.txtStrLabel.ReadOnly = true;
            this.txtStrLabel.Size = new System.Drawing.Size(100, 13);
            this.txtStrLabel.TabIndex = 13;
            this.txtStrLabel.Text = "Siła";
            // 
            // txtDexLabel
            // 
            this.txtDexLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtDexLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDexLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDexLabel.Location = new System.Drawing.Point(469, 264);
            this.txtDexLabel.Name = "txtDexLabel";
            this.txtDexLabel.ReadOnly = true;
            this.txtDexLabel.Size = new System.Drawing.Size(100, 13);
            this.txtDexLabel.TabIndex = 14;
            this.txtDexLabel.Text = "Zręczność";
            // 
            // txtConLabel
            // 
            this.txtConLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtConLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConLabel.Location = new System.Drawing.Point(575, 264);
            this.txtConLabel.Name = "txtConLabel";
            this.txtConLabel.ReadOnly = true;
            this.txtConLabel.Size = new System.Drawing.Size(100, 13);
            this.txtConLabel.TabIndex = 15;
            this.txtConLabel.Text = "Wytrzymałość";
            // 
            // txtIntLabel
            // 
            this.txtIntLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtIntLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIntLabel.Location = new System.Drawing.Point(363, 341);
            this.txtIntLabel.Name = "txtIntLabel";
            this.txtIntLabel.ReadOnly = true;
            this.txtIntLabel.Size = new System.Drawing.Size(100, 13);
            this.txtIntLabel.TabIndex = 16;
            this.txtIntLabel.Text = "Inteligencja";
            // 
            // txtWisLabel
            // 
            this.txtWisLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtWisLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWisLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWisLabel.Location = new System.Drawing.Point(469, 341);
            this.txtWisLabel.Name = "txtWisLabel";
            this.txtWisLabel.ReadOnly = true;
            this.txtWisLabel.Size = new System.Drawing.Size(100, 13);
            this.txtWisLabel.TabIndex = 17;
            this.txtWisLabel.Text = "Wiedza";
            // 
            // txtCharLabel
            // 
            this.txtCharLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtCharLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCharLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCharLabel.Location = new System.Drawing.Point(575, 341);
            this.txtCharLabel.Name = "txtCharLabel";
            this.txtCharLabel.ReadOnly = true;
            this.txtCharLabel.Size = new System.Drawing.Size(100, 13);
            this.txtCharLabel.TabIndex = 18;
            this.txtCharLabel.Text = "Charyzma";
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
            this.ListStrAtr.Location = new System.Drawing.Point(363, 283);
            this.ListStrAtr.Name = "ListStrAtr";
            this.ListStrAtr.Size = new System.Drawing.Size(54, 21);
            this.ListStrAtr.TabIndex = 19;
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
            this.ListDexAtr.Location = new System.Drawing.Point(469, 283);
            this.ListDexAtr.Name = "ListDexAtr";
            this.ListDexAtr.Size = new System.Drawing.Size(54, 21);
            this.ListDexAtr.TabIndex = 20;
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
            this.ListConAtr.Location = new System.Drawing.Point(575, 283);
            this.ListConAtr.Name = "ListConAtr";
            this.ListConAtr.Size = new System.Drawing.Size(54, 21);
            this.ListConAtr.TabIndex = 21;
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
            this.ListIntAtr.Location = new System.Drawing.Point(363, 360);
            this.ListIntAtr.Name = "ListIntAtr";
            this.ListIntAtr.Size = new System.Drawing.Size(54, 21);
            this.ListIntAtr.TabIndex = 22;
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
            this.ListWisAtr.Location = new System.Drawing.Point(469, 360);
            this.ListWisAtr.Name = "ListWisAtr";
            this.ListWisAtr.Size = new System.Drawing.Size(54, 21);
            this.ListWisAtr.TabIndex = 23;
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
            this.ListCharAtr.Location = new System.Drawing.Point(575, 360);
            this.ListCharAtr.Name = "ListCharAtr";
            this.ListCharAtr.Size = new System.Drawing.Size(54, 21);
            this.ListCharAtr.TabIndex = 24;
            // 
            // btnCreateChar
            // 
            this.btnCreateChar.Location = new System.Drawing.Point(713, 415);
            this.btnCreateChar.Name = "btnCreateChar";
            this.btnCreateChar.Size = new System.Drawing.Size(75, 23);
            this.btnCreateChar.TabIndex = 25;
            this.btnCreateChar.Text = "Utwórz";
            this.btnCreateChar.UseVisualStyleBackColor = true;
            this.btnCreateChar.Click += new System.EventHandler(this.btnCreateChar_Click);
            // 
            // txtHealthInput
            // 
            this.txtHealthInput.Location = new System.Drawing.Point(570, 187);
            this.txtHealthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHealthInput.Name = "txtHealthInput";
            this.txtHealthInput.Size = new System.Drawing.Size(120, 20);
            this.txtHealthInput.TabIndex = 26;
            this.txtHealthInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormCreateChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHealthInput);
            this.Controls.Add(this.btnCreateChar);
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
            this.Name = "FormCreateChar";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHealthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtNameLabel;
        private System.Windows.Forms.TextBox txtRaceLabel;
        private System.Windows.Forms.ComboBox ListRaceInput;
        private System.Windows.Forms.TextBox txtClassLabel;
        private System.Windows.Forms.ComboBox ListClassInput;
        private System.Windows.Forms.TextBox txtHealthLabel;
        private System.Windows.Forms.TextBox txtDamageLabel;
        private System.Windows.Forms.ComboBox ListDmgInput;
        private System.Windows.Forms.TextBox txtStrLabel;
        private System.Windows.Forms.TextBox txtDexLabel;
        private System.Windows.Forms.TextBox txtConLabel;
        private System.Windows.Forms.TextBox txtIntLabel;
        private System.Windows.Forms.TextBox txtWisLabel;
        private System.Windows.Forms.TextBox txtCharLabel;
        private System.Windows.Forms.ComboBox ListStrAtr;
        private System.Windows.Forms.ComboBox ListDexAtr;
        private System.Windows.Forms.ComboBox ListConAtr;
        private System.Windows.Forms.ComboBox ListIntAtr;
        private System.Windows.Forms.ComboBox ListWisAtr;
        private System.Windows.Forms.ComboBox ListCharAtr;
        private System.Windows.Forms.Button btnCreateChar;
        private System.Windows.Forms.NumericUpDown txtHealthInput;
    }
}