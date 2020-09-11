using DungeonWorld.DAO;
using DungeonWorld.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonWorld
{
    public partial class FormEditChar : Form
    {
        public DWModel context = new DWModel();
        private Character character;

        public FormEditChar(Character character)
        {
            this.character = character;
            InitializeComponent();
            SetListRaceInputItems();
            SetListClassInputItems();
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
            txtNameInput.Text = character.Name;           
            ListRaceInput.SelectedIndex = ListRaceInput.FindStringExact(DataAccesObject.GetRaceById(character.IDRace).Race_Name);
            ListClassInput.SelectedIndex = ListClassInput.FindStringExact(DataAccesObject.GetClassById(character.IDClass).Class_Name);
            ListDmgInput.SelectedIndex = ListDmgInput.FindStringExact(character.Damage.ToString());
            txtHealthInput.Value = character.MaxHealth;
            ListStrAtr.SelectedIndex = ListStrAtr.FindStringExact(character.Strength.ToString());
            ListDexAtr.SelectedIndex = ListDexAtr.FindStringExact(character.Dexterity.ToString());
            ListConAtr.SelectedIndex = ListConAtr.FindStringExact(character.Constitution.ToString());
            ListIntAtr.SelectedIndex = ListStrAtr.FindStringExact(character.Inteligence.ToString());
            ListWisAtr.SelectedIndex = ListWisAtr.FindStringExact(character.Lore.ToString());
            ListCharAtr.SelectedIndex = ListCharAtr.FindStringExact(character.Charisma.ToString());
        }

        private void btnSaveChar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameInput.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być uzupełnione", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Edycja zakończona sukcesem", "Sukces", MessageBoxButtons.OK);
                this.character.Name = txtNameInput.Text;
                this.character.IDRace = DataAccesObject.GetRaceByName(ListRaceInput.SelectedItem.ToString()).IDRace;
                this.character.IDClass = DataAccesObject.GetClassByName(ListClassInput.SelectedItem.ToString()).IDClass;
                this.character.Damage = ListDmgInput.Text;
                this.character.MaxHealth = Decimal.ToInt32(txtHealthInput.Value);
                this.character.CurrentHealth = Decimal.ToInt32(txtHealthInput.Value);
                this.character.Strength = int.Parse(ListStrAtr.Text);
                this.character.Dexterity = int.Parse(ListDexAtr.Text);
                this.character.Constitution = int.Parse(ListConAtr.Text);
                this.character.Inteligence = int.Parse(ListIntAtr.Text);
                this.character.Lore = int.Parse(ListWisAtr.Text);
                this.character.Charisma = int.Parse(ListCharAtr.Text);               
                context.Characters.AddOrUpdate(character);
                context.SaveChanges();
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Close();
            }
        }
     
        private void SetListClassInputItems()
        {
            foreach (var item in DataAccesObject.GetClassNames())
            {
                this.ListClassInput.Items.Add(item);
            }


        }
        private void SetListRaceInputItems()
        {

            foreach (var item in DataAccesObject.GetRaceNames())
            {
                this.ListRaceInput.Items.Add(item);
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            FormCharList form = new FormCharList();
            form.Show();
            this.Close();
        }
        
    }
}


