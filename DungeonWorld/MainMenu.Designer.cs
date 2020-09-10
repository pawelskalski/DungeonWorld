namespace DungeonWorld
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMyCharacters = new System.Windows.Forms.Button();
            this.btnCreateNewCharacter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyCharacters
            // 
            this.btnMyCharacters.Location = new System.Drawing.Point(305, 190);
            this.btnMyCharacters.Name = "btnMyCharacters";
            this.btnMyCharacters.Size = new System.Drawing.Size(184, 23);
            this.btnMyCharacters.TabIndex = 0;
            this.btnMyCharacters.Text = "Moje karty postaci";
            this.btnMyCharacters.UseVisualStyleBackColor = true;
            this.btnMyCharacters.Click += new System.EventHandler(this.btnMyCharacters_Click);
            // 
            // btnCreateNewCharacter
            // 
            this.btnCreateNewCharacter.Location = new System.Drawing.Point(305, 142);
            this.btnCreateNewCharacter.Name = "btnCreateNewCharacter";
            this.btnCreateNewCharacter.Size = new System.Drawing.Size(184, 23);
            this.btnCreateNewCharacter.TabIndex = 1;
            this.btnCreateNewCharacter.Text = "Stwórz nową postać";
            this.btnCreateNewCharacter.UseVisualStyleBackColor = true;
            this.btnCreateNewCharacter.Click += new System.EventHandler(this.btnCreateNewCharacter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateNewCharacter);
            this.Controls.Add(this.btnMyCharacters);
            this.Name = "FormMainMenu";
            this.Text = "DungeonWorld";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyCharacters;
        private System.Windows.Forms.Button btnCreateNewCharacter;
        private System.Windows.Forms.Button btnExit;
    }
}

