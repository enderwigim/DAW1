using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        // Global Variables

        // Create a classArray and a classPosition to navigate through
        string[] classArray = {
            "Paladin",
            "DeathKnight",
            "Priest",
            "Mage",
            "Warlock",
            "Warrior",
            "Rogue",
            "Hunter"
            };
        int classPosition = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'characterDataSet.character' Puede moverla o quitarla según sea necesario.
            this.characterTableAdapter.Fill(this.characterDataSet.character);
            ShowData();

        }

        private void btnShowNext_Click(object sender, EventArgs e)
        {
            if (CustomRegex.RegexLevel(txtLevel.Text))
            {
                try
                {
                    charCrud.MoveNext();
                    ShowData();
                }
                catch (ConstraintException ex)
                {
                    charCrud.ResetItem(0);
                    MessageBox.Show("An error ocurred while updating data: \n" + ex.Message);
                }
            } 
            else
            {
                MessageBox.Show("That level is not in the correct format. It must be between 1 - 80");
            }
        }

        private void btnShowFirst_Click(object sender, EventArgs e)
        {
            if (CustomRegex.RegexLevel(txtLevel.Text))
            {
                try
                {
                    charCrud.MoveFirst();
                    ShowData();
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show("An error ocurred while updating data: \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("That level is not in the correct format. It must be between 1 - 80");
            }
        }
        private void btnShowPrevious_Click(object sender, EventArgs e)
        {
            if (CustomRegex.RegexLevel(txtLevel.Text))
            {
                try
                {
                    charCrud.MovePrevious();
                    ShowData();
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show("An error ocurred while updating data: \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("That level is not in the correct format. It must be between 1 - 80");
            }
        }

        private void btnShowLast_Click(object sender, EventArgs e)
        {
            if (CustomRegex.RegexLevel(txtLevel.Text))
            {
                try
                {
                    charCrud.MoveLast();
                    ShowData();
                }
                catch (ConstraintException ex)
                {
                    MessageBox.Show("An error ocurred while updating data: \n" + ex.Message);
                };
            }
            else
            {
                MessageBox.Show("That level is not in the correct format. It must be between 1 - 80");
            }
        }
        public void ShowData()
        {
            ManageClassButtons();
            ManageClassLbl();
            ManageEntryLbl();
        }
        public void ManageEntryLbl()
        {
            lblEntryNumber.Text = (charCrud.Position + 1) + " de " + charCrud.Count;
        }
        public void ManageClassLbl()
        {
            lblClassSelector.Text = classArray[classPosition];
        }

        private void btnAddNewCharacter_Click(object sender, EventArgs e)
        {
            charCrud.AddNew();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            charCrud.EndEdit();

            characterTableAdapter.Update(characterDataSet.character);
            ShowData();
        }

        private void btnNextClass_Click(object sender, EventArgs e)
        {
            if (classPosition < classArray.Length - 1)
            {
                classPosition++;
            }
            ShowData();
        }

        private void btnPreviousClass_Click(object sender, EventArgs e)
        {
            classPosition--;
            ShowData();
        }
        public void ManageClassButtons()
        {
            btnNextClass.Enabled = (classPosition < classArray.Length - 1);
            btnPreviousClass.Enabled = (classPosition > 0);
        }
    }
}
