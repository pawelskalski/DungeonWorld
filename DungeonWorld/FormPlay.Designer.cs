namespace DungeonWorld
{
    partial class FormPlay
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
            this.txtHealthInput = new System.Windows.Forms.NumericUpDown();
            this.btnWis = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnDex = new System.Windows.Forms.Button();
            this.btnStr = new System.Windows.Forms.Button();
            this.btnDmg = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.Label();
            this.txtHpMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDice = new System.Windows.Forms.Label();
            this.txtMod = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtHealthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHealthInput
            // 
            this.txtHealthInput.Location = new System.Drawing.Point(526, 41);
            this.txtHealthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHealthInput.Name = "txtHealthInput";
            this.txtHealthInput.Size = new System.Drawing.Size(120, 20);
            this.txtHealthInput.TabIndex = 74;
            this.txtHealthInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnWis
            // 
            this.btnWis.Location = new System.Drawing.Point(153, 184);
            this.btnWis.Name = "btnWis";
            this.btnWis.Size = new System.Drawing.Size(75, 23);
            this.btnWis.TabIndex = 80;
            this.btnWis.Text = "button1";
            this.btnWis.UseVisualStyleBackColor = true;
            this.btnWis.Click += new System.EventHandler(this.btnWis_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(153, 239);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(75, 23);
            this.btnChar.TabIndex = 81;
            this.btnChar.Text = "button2";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(153, 128);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(75, 23);
            this.btnInt.TabIndex = 82;
            this.btnInt.Text = "button3";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(12, 239);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 83;
            this.btnCon.Text = "button4";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnDex
            // 
            this.btnDex.Location = new System.Drawing.Point(12, 184);
            this.btnDex.Name = "btnDex";
            this.btnDex.Size = new System.Drawing.Size(75, 23);
            this.btnDex.TabIndex = 84;
            this.btnDex.Text = "button5";
            this.btnDex.UseVisualStyleBackColor = true;
            this.btnDex.Click += new System.EventHandler(this.btnDex_Click);
            // 
            // btnStr
            // 
            this.btnStr.Location = new System.Drawing.Point(12, 128);
            this.btnStr.Name = "btnStr";
            this.btnStr.Size = new System.Drawing.Size(75, 23);
            this.btnStr.TabIndex = 85;
            this.btnStr.Text = "button6";
            this.btnStr.UseVisualStyleBackColor = true;
            this.btnStr.Click += new System.EventHandler(this.btnStr_Click);
            // 
            // btnDmg
            // 
            this.btnDmg.Location = new System.Drawing.Point(295, 131);
            this.btnDmg.Name = "btnDmg";
            this.btnDmg.Size = new System.Drawing.Size(75, 23);
            this.btnDmg.TabIndex = 87;
            this.btnDmg.Text = "button2";
            this.btnDmg.UseVisualStyleBackColor = true;
            this.btnDmg.Click += new System.EventHandler(this.btnDmg_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 23);
            this.btnReturn.TabIndex = 88;
            this.btnReturn.Text = "Anuluj rozgrywke";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Location = new System.Drawing.Point(531, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 23);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Zapisz rozgrywke";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(12, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 90;
            this.txtName.Text = "label1";
            // 
            // txtRace
            // 
            this.txtRace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRace.Location = new System.Drawing.Point(153, 42);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(120, 20);
            this.txtRace.TabIndex = 91;
            this.txtRace.Text = "label2";
            // 
            // txtClass
            // 
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClass.Location = new System.Drawing.Point(295, 42);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(120, 20);
            this.txtClass.TabIndex = 92;
            this.txtClass.Text = "label3";
            // 
            // txtHpMax
            // 
            this.txtHpMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHpMax.Location = new System.Drawing.Point(667, 42);
            this.txtHpMax.Name = "txtHpMax";
            this.txtHpMax.Size = new System.Drawing.Size(120, 20);
            this.txtHpMax.TabIndex = 93;
            this.txtHpMax.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Rasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Klasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 97;
            this.label4.Text = "Punkty życia maksymalne";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Punkty życia aktualne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Siła";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Zręczność";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Wytrzymałość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "Inteligencja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Wiedza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "Charyzma";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 106;
            this.label12.Text = "Obrażenia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(528, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 107;
            this.label13.Text = "Rzut";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(610, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 108;
            this.label14.Text = "Modyfikator";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(692, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 111;
            this.label15.Text = "Wynik";
            // 
            // txtDice
            // 
            this.txtDice.BackColor = System.Drawing.Color.White;
            this.txtDice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDice.Location = new System.Drawing.Point(526, 184);
            this.txtDice.Name = "txtDice";
            this.txtDice.Size = new System.Drawing.Size(50, 50);
            this.txtDice.TabIndex = 112;
            this.txtDice.Text = "12";
            this.txtDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMod
            // 
            this.txtMod.BackColor = System.Drawing.Color.White;
            this.txtMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMod.Location = new System.Drawing.Point(613, 183);
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(50, 50);
            this.txtMod.TabIndex = 113;
            this.txtMod.Text = "12";
            this.txtMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResult.Location = new System.Drawing.Point(695, 183);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(50, 50);
            this.txtResult.TabIndex = 114;
            this.txtResult.Text = "12";
            this.txtResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtDice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHpMax);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDmg);
            this.Controls.Add(this.btnStr);
            this.Controls.Add(this.btnDex);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnWis);
            this.Controls.Add(this.txtHealthInput);
            this.Name = "FormPlay";
            this.Text = "Rozgrywka";
            ((System.ComponentModel.ISupportInitialize)(this.txtHealthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtHealthInput;
        private System.Windows.Forms.Button btnWis;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnDex;
        private System.Windows.Forms.Button btnStr;
        private System.Windows.Forms.Button btnDmg;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtRace;
        private System.Windows.Forms.Label txtClass;
        private System.Windows.Forms.Label txtHpMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtDice;
        private System.Windows.Forms.Label txtMod;
        private System.Windows.Forms.Label txtResult;
    }
}