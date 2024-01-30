using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Person person = new Person();
        public void AddInfo()
        {

            person.PName = Interaction.InputBox("Add Name");
            person.PAge = int.Parse(Interaction.InputBox("How old?"));
            person.PPhone = Interaction.InputBox("Add Phone");
            person.PGender = char.Parse(Interaction.InputBox("Add Gender"));

            DialogResult marry = MessageBox.Show("Marry?", "?", MessageBoxButtons.YesNo);
            if (marry == DialogResult.Yes)
            {
                person.PMarry = true;
            }
            else
            {
                person.PMarry = false;
            }

        }



        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddInfo();
        }

        private void btnShowPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.GetPerson());
        }
    }
}
