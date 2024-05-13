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

namespace Ex4
{
    public partial class FTeacher : Form
    {
        public FTeacher()
        {
            InitializeComponent();
        }
        // Global Variables
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        private void FTeacher_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper("Profesores");
            pos = 0;

            ShowEntry(pos);

            btnSaveNew.Enabled = false;
        }
        

        private void btnShowNextTeacher_Click(object sender, EventArgs e)
        {
            if (pos != db.AmmountOfEntries - 1)
            {
                pos++;
            }
            else
            {
                pos = 0;
            }
            ShowEntry(pos);
        }

        private void btnShowPreviousTeacher_Click(object sender, EventArgs e)
        {
            if (pos != 0)
            {
                pos--;
            }
            else
            {
                pos = db.AmmountOfEntries - 1;
            }
            ShowEntry(pos);
            
        }

        private void btnShowLastTeacher_Click(object sender, EventArgs e)
        {
            pos = db.AmmountOfEntries - 1;
            ShowEntry(pos);
        }

        private void btnShowFirstTeacher_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowEntry(pos);
        }
        public void ShowEntry(int pos)
        {
            if (db.AmmountOfEntries >= 1)
            {
                Teacher teacher = (Teacher)db.GetEntry(pos);
                if (teacher == null)
                {
                    ErrorMessage();
                }
                else
                {
                    txtDNI.Text = teacher.DNI;
                    txtNombre.Text = teacher.Name;
                    txtApellidos.Text = teacher.Surname;
                    txtTlf.Text = teacher.Tlf;
                    txteMail.Text = teacher.eMail;
                }
                // lblEntryNumbers management.
                lblEntryNumber.Text = (int)((pos + 1)) + " de " + db.AmmountOfEntries;
                

            } else
            {
                ShowEmpty();
            }
            CheckButtons();
            CheckNavButtons();
            ManageTxts();
        }
        public void ShowEmpty()
        {
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTlf.Text = string.Empty;
            txteMail.Text = string.Empty;

            lblEntryNumber.Text = "0 de 0";

            
        }
        public void ErrorMessage()
        {
            MessageBox.Show("There was an error with the data introduced: \n" +
                            "Follow the next to do it properly\n" +
                            "DNI: A12345678B || 12345678A\n" +
                            "Nombre: Can't be empty\n" +
                            "Apellido: Can't be empty\n" +
                            "Telefono: 666666666\n" +
                            "Email: x@teacher.com");
        }
        public void CheckNavButtons()
        {
            btnShowNextTeacher.Enabled = (db.AmmountOfEntries != 0 && pos < db.AmmountOfEntries - 1 && !isANewEntry);
            btnShowPreviousTeacher.Enabled = (db.AmmountOfEntries != 0 && pos > 0 && !isANewEntry);
            btnShowLastTeacher.Enabled = (db.AmmountOfEntries != 0 && pos != db.AmmountOfEntries - 1 && !isANewEntry);
            btnShowFirstTeacher.Enabled = (db.AmmountOfEntries != 0 && pos != 0 && !isANewEntry);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTlf.Clear();
            txteMail.Clear();

            btnSaveNew.Enabled = true;
            btnAddTeacher.Enabled = false;
            isANewEntry = true;

            CheckButtons();
            CheckNavButtons();
            ManageTxts();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string surname = txtApellidos.Text;
            string tlf = txtTlf.Text;
            string email = txteMail.Text;

            Teacher profesor = Teacher.CreateTeacher(dni, nombre, surname, tlf, email);
            if (profesor != null)
            {
                db.CreateRow(profesor);
                btnSaveNew.Enabled = false;
                isANewEntry = false;
                pos = db.AmmountOfEntries - 1;
                ShowEntry(pos);

            }
            else
                ErrorMessage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string surname = txtApellidos.Text;
            string tlf = txtTlf.Text;
            string email = txteMail.Text;

            Teacher profesor = Teacher.CreateTeacher(dni, nombre, surname, tlf, email);
            if (profesor != null)
                db.UpdateRow(profesor, pos);
            else
                ErrorMessage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult wantToDelete;
            wantToDelete = MessageBox.Show("Are you sure that you want to delete this teacher?", " ", MessageBoxButtons.YesNo);
            if (wantToDelete == DialogResult.Yes)
            {
                db.DeleteRow(pos);
                if (db.AmmountOfEntries >= 1)
                {
                    // We will show the previous teacher.
                    pos--;

                    ShowEntry(pos);
                    MessageBox.Show("Character Deleted");
                }
                else
                {
                    ShowEntry(pos);
                }
            }
        }

        private void btnShowEveryTeacher_Click(object sender, EventArgs e)
        {
            string everyName = db.GetEveryName();
            if (everyName != "")
            {
                MessageBox.Show("The teachers in the database are: \n" + everyName);
            } 
            else
            {
                MessageBox.Show("There's no teachers in the database");
            }
        }

        private void btnLookBySurname_Click(object sender, EventArgs e)
        {
            string surname = Interaction.InputBox("What surname do you want to look for?");
            int foundedPos = db.LookBySurname(surname);
            if (foundedPos != -1)
                pos = foundedPos;
            else
                MessageBox.Show("That teacher wasn't founded");
            ShowEntry(pos);
        }
        public void CheckButtons()
        {
            btnAddTeacher.Enabled = (!isANewEntry);
            btnDelete.Enabled = (db.AmmountOfEntries != 0 && !isANewEntry);
            btnSaveNew.Enabled = (isANewEntry);
            btnLookBySurname.Enabled = (db.AmmountOfEntries > 0 && !isANewEntry);
            btnShowEveryTeacher.Enabled = (db.AmmountOfEntries > 0 && !isANewEntry);

            btnUpdate.Enabled = false; 
        }

        public void ManageTxts()
        {
            txtDNI.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtNombre.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtApellidos.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtTlf.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txteMail.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
        }
        
    }
}
