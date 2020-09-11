namespace DungeonWorld
{
    partial class FormCharList
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
            this.ListCharactersShow = new System.Windows.Forms.ListView();
            this.colCharacterNameLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCharacterIdLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCharacterRaceLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCharacterClassLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListCharactersShow
            // 
            this.ListCharactersShow.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListCharactersShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCharacterNameLabel,
            this.colCharacterRaceLabel,
            this.colCharacterClassLabel,
            this.colCharacterIdLabel});
            this.ListCharactersShow.FullRowSelect = true;
            this.ListCharactersShow.GridLines = true;
            this.ListCharactersShow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListCharactersShow.HideSelection = false;
            this.ListCharactersShow.Location = new System.Drawing.Point(118, 12);
            this.ListCharactersShow.MultiSelect = false;
            this.ListCharactersShow.Name = "ListCharactersShow";
            this.ListCharactersShow.Size = new System.Drawing.Size(554, 359);
            this.ListCharactersShow.TabIndex = 0;
            this.ListCharactersShow.UseCompatibleStateImageBehavior = false;
            this.ListCharactersShow.View = System.Windows.Forms.View.Details;
            // 
            // colCharacterNameLabel
            // 
            this.colCharacterNameLabel.Text = "Imię postaci";
            this.colCharacterNameLabel.Width = 250;
            // 
            // colCharacterIdLabel
            // 
            this.colCharacterIdLabel.DisplayIndex = 1;
            this.colCharacterIdLabel.Text = "";
            this.colCharacterIdLabel.Width = 0;
            // 
            // Id
            // 
            this.Id.Width = 0;
            // 
            // colCharacterRaceLabel
            // 
            this.colCharacterRaceLabel.DisplayIndex = 2;
            this.colCharacterRaceLabel.Text = "Rasa";
            this.colCharacterRaceLabel.Width = 150;
            // 
            // colCharacterClassLabel
            // 
            this.colCharacterClassLabel.DisplayIndex = 3;
            this.colCharacterClassLabel.Text = "Klasa";
            this.colCharacterClassLabel.Width = 150;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.Location = new System.Drawing.Point(12, 415);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.Location = new System.Drawing.Point(713, 415);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Graj";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Location = new System.Drawing.Point(632, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Location = new System.Drawing.Point(551, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormCharList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ListCharactersShow);
            this.Name = "FormCharList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista postaci";
            this.Load += new System.EventHandler(this.FormCharList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListCharactersShow;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader colCharacterIdLabel;
        private System.Windows.Forms.ColumnHeader colCharacterNameLabel;
        private System.Windows.Forms.ColumnHeader colCharacterRaceLabel;
        private System.Windows.Forms.ColumnHeader colCharacterClassLabel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}