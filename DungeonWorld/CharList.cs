using DungeonWorld.DAO;
using DungeonWorld.Model;
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
            foreach (Character character in DataAccesObject.GetAllCharacters())
            {
                ListViewItem item = new ListViewItem(character.Name);
                var racename = DataAccesObject.GetRaceById(character.IDRace);
                var classname = DataAccesObject.GetClassById(character.IDClass);
                item.SubItems.Add(racename.Race_Name);
                item.SubItems.Add(classname.Class_Name);
                item.SubItems.Add(character.IDCharacter.ToString());
                this.ListCharactersShow.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.ListCharactersShow.SelectedItems.Count != 0)
            {
                var selectedID = this.ListCharactersShow.SelectedItems[0].SubItems[3].Text;
                DataAccesObject.DeleteCharacterById(int.Parse(selectedID.ToString()));
                this.ListCharactersShow.SelectedItems[0].Remove();
                this.Update();
            }
            else
            {
                MessageBox.Show("Wybierz postać którą chcesz usunąć", "Błąd", MessageBoxButtons.OK);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.ListCharactersShow.SelectedItems.Count != 0)
            {
                FormEditChar form = new FormEditChar(DataAccesObject.GetCharacterById(int.Parse(this.ListCharactersShow.SelectedItems[0].SubItems[3].Text.ToString())));
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wybierz postać którą chcesz edytować", "Błąd", MessageBoxButtons.OK);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (this.ListCharactersShow.SelectedItems.Count != 0)
            {
                FormPlay form = new FormPlay(DataAccesObject.GetCharacterById(int.Parse(this.ListCharactersShow.SelectedItems[0].SubItems[3].Text.ToString())));
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wybierz postać dla której chcesz rozpocząć rozgrywke", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}

