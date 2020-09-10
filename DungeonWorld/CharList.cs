using System;
using System.Windows.Forms;


namespace DungeonWorld
{
    public partial class FormCharList : Form
    {
        public FormCharList()
        {
            InitializeComponent();
        }

        private void FormCharList_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dungeonWorldDataSet.Characters' . Możesz go przenieść lub usunąć.
            this.charactersTableAdapter.Fill(this.dungeonWorldDataSet.Characters);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
