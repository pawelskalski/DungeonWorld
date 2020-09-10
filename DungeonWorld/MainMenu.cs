using System;
using System.Windows.Forms;

namespace DungeonWorld
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnCreateNewCharacter_Click(object sender, EventArgs e)
        {
            FormCreateChar createChar = new FormCreateChar();
            createChar.Show();
            this.Hide();

        }

        private void btnMyCharacters_Click(object sender, EventArgs e)
        {
            FormCharList charList = new FormCharList();
            charList.Show();
            this.Hide();
        }
    }
}
