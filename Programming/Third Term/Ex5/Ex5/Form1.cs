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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'characterDataSet.character' Puede moverla o quitarla según sea necesario.
            this.characterTableAdapter.Fill(this.characterDataSet.character);
            ManageEntryLbl();

        }

        private void btnShowNext_Click(object sender, EventArgs e)
        {
            if (CustomRegex.RegexLevel(txtLevel.Text))
            {
                try
                {
                    charCrud.MoveNext();
                    ManageEntryLbl();
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
                    ManageEntryLbl();
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
                    ManageEntryLbl();
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
                    ManageEntryLbl();
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
        public void ManageEntryLbl()
        {
            lblEntryNumber.Text = (charCrud.Position + 1) + " de " + charCrud.Count;
        }
        
    }
}
