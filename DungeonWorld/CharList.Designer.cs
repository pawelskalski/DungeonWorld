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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dungeonWorldDataSet = new DungeonWorld.DungeonWorldDataSet();
            this.charactersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charactersTableAdapter = new DungeonWorld.DungeonWorldDataSetTableAdapters.CharactersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dungeonWorldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonWorldDataSet
            // 
            this.dungeonWorldDataSet.DataSetName = "DungeonWorldDataSet";
            this.dungeonWorldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charactersBindingSource
            // 
            this.charactersBindingSource.DataMember = "Characters";
            this.charactersBindingSource.DataSource = this.dungeonWorldDataSet;
            // 
            // charactersTableAdapter
            // 
            this.charactersTableAdapter.ClearBeforeFill = true;
            // 
            // FormCharList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 563);
            this.Name = "FormCharList";
            this.Text = "Lista postaci";
            this.Load += new System.EventHandler(this.FormCharList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dungeonWorldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DungeonWorldDataSet dungeonWorldDataSet;
        private System.Windows.Forms.BindingSource charactersBindingSource;
        private DungeonWorldDataSetTableAdapters.CharactersTableAdapter charactersTableAdapter;
    }
}