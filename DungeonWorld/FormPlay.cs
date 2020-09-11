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
    public partial class FormPlay : Form
    {
        private Character character;
        public DWModel context = new DWModel();

        //todo wyłączyć formularze tak by nie dało się w nie kliknąć albo zmienic na labele, wygląd, rzucanie koścmi
        public FormPlay(Character character)
        {
            InitializeComponent();
            this.character = character;
            this.txtName.Text = character.Name;
            this.txtRace.Text = DataAccesObject.GetRaceById(character.IDRace).Race_Name.ToString();
            this.txtClass.Text = DataAccesObject.GetClassById(character.IDClass).Class_Name.ToString();
            this.txtHpMax.Text = character.MaxHealth.ToString();
            this.btnStr.Text = character.Strength.ToString();
            this.btnDex.Text = character.Dexterity.ToString();
            this.btnCon.Text = character.Constitution.ToString();
            this.btnInt.Text = character.Inteligence.ToString();
            this.btnWis.Text = character.Lore.ToString();
            this.btnChar.Text = character.Charisma.ToString();
            this.txtHealthInput.Maximum = character.MaxHealth;
            this.btnDmg.Text = character.Damage;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz anulować rozgrywkę?", "Uwaga", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                FormCharList formCharList = new FormCharList();
                formCharList.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.character.CurrentHealth = Decimal.ToInt32(this.txtHealthInput.Value);
            context.Characters.AddOrUpdate(this.character);
            context.SaveChanges();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
            this.Close();
        }


        private void btnStr_Click(object sender, EventArgs e)
        {
            int mod = checkMod(character.Strength);
            this.txtMod.Text = mod.ToString();
            this.txtDice.Text = DiceRoll(12).ToString();
            this.txtResult.Text = (mod + int.Parse(this.txtDice.Text)).ToString();
        }

        

        private void btnDex_Click(object sender, EventArgs e)
        {
            int mod = checkMod(character.Dexterity);
            this.txtMod.Text = mod.ToString();
            this.txtDice.Text = DiceRoll(12).ToString();
            this.txtResult.Text = (mod + int.Parse(this.txtDice.Text)).ToString();

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            int mod = checkMod(character.Constitution);
            this.txtMod.Text = mod.ToString();
            this.txtDice.Text = DiceRoll(12).ToString();
            this.txtResult.Text = (mod + int.Parse(this.txtDice.Text)).ToString();

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int mod = checkMod(character.Inteligence);
            this.txtMod.Text = mod.ToString();
            this.txtDice.Text = DiceRoll(12).ToString();
            this.txtResult.Text = (mod + int.Parse(this.txtDice.Text)).ToString();

        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            int mod = checkMod(character.Lore);
            this.txtMod.Text = mod.ToString();
            this.txtDice.Text = DiceRoll(12).ToString();
            this.txtResult.Text = (mod + int.Parse(this.txtDice.Text)).ToString();
        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            int mod = checkMod(character.Charisma);
            this.txtMod.Text = mod.ToString();
            this.txtDice.Text = DiceRoll(12).ToString();
            this.txtResult.Text = (mod + int.Parse(this.txtDice.Text)).ToString();

        }

        private void btnDmg_Click(object sender, EventArgs e)
        {
            int numericDamage = Convert.ToInt32(int.Parse(character.Damage.Substring(1)));
            this.txtMod.Text = "nn";
            this.txtDice.Text = DiceRoll(numericDamage).ToString();
            this.txtResult.Text = (int.Parse(this.txtDice.Text)).ToString();
        }
        private int DiceRoll(int DiceSides)
        {
            Random random = new Random();
            return random.Next(1, DiceSides + 1);

        }
        private int checkMod(int number)
        {
            if (number >= 16)
            {
                return 2;
            }
            if (number >= 13 && number < 16)
            {
                return 1;
            }
            if (number > 8 && number <= 12)
            {
                return 0;
            }

            else
            {
                return -1;
            }

        }
    }
}
