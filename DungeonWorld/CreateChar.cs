using DungeonWorld.DAO;
using DungeonWorld.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;


namespace DungeonWorld
{
    public partial class FormCreateChar : Form
    {



        public DWModel context = new DWModel();

        public FormCreateChar()
        {
            InitializeComponent();
            
        }
        private void SetListClassInputItems()
        {
            foreach(var item in   DataAccesObject.GetClassNames())
            {
                this.ListClassInput.Items.Add(item);
            }
            
  
        }
        private void SetListRaceInputItems()
        {
            
                foreach (var item in  DataAccesObject.GetRaceNames())
                {
                    this.ListRaceInput.Items.Add(item);
                }

            
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {

            if (CreateCharValidate())
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Postać została stworzona", "Sukces", MessageBoxButtons.OK);

                var character = new Character
                {

                    Name = txtNameInput.Text,
                    RaceId = DataAccesObject.GetRaceIdByName(ListRaceInput.SelectedItem.ToString()).RaceId,
                    ClassId = DataAccesObject.GetClassIdByName(ListClassInput.SelectedItem.ToString()).IDClass,
                    Damage = ListDmgInput.Text,
                    MaxHealth = Decimal.ToInt32(txtHealthInput.Value),
                    CurrentHealth = Decimal.ToInt32(txtHealthInput.Value),
                    Strength = int.Parse(ListStrAtr.Text),
                    Dexterity = int.Parse(ListDexAtr.Text),
                    Constitution = int.Parse(ListConAtr.Text),
                    Inteligence = int.Parse(ListIntAtr.Text),
                    Lore = int.Parse(ListWisAtr.Text),
                    Charisma = int.Parse(ListCharAtr.Text)
                };
                context.Characters.Add(character);
                context.SaveChanges();

                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Close();
            }

        }

        private bool CreateCharValidate()
        {
            object[] inputList = new object[] { ListRaceInput, ListStrAtr, ListDexAtr, ListConAtr, ListIntAtr, ListWisAtr, ListCharAtr, ListClassInput };
            foreach (ComboBox input in inputList)
            {
                if (string.IsNullOrWhiteSpace(input.Text))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;

        }

        private void FormCreateChar_Load(object sender, EventArgs e)
        {
            this.ListDmgInput.Items.AddRange(new object[] {"d4","d6",
                        "d8",
                        "d10",
                        "d12",
                        "d20",
                        });
            object[] attributeList = new object[] { 16, 15, 13, 12, 9, 8 };
            this.ListStrAtr.Items.AddRange(attributeList);
            this.ListDexAtr.Items.AddRange(attributeList);
            this.ListConAtr.Items.AddRange(attributeList);
            this.ListIntAtr.Items.AddRange(attributeList);
            this.ListWisAtr.Items.AddRange(attributeList);
            this.ListCharAtr.Items.AddRange(attributeList);
            SetListClassInputItems();
            SetListRaceInputItems();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
