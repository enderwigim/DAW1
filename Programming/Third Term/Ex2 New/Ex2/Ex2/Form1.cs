using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex2.Models;
using Microsoft.VisualBasic;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global Variables
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper();
            pos = 0;
            
            ShowEntry(pos);

            btnSaveNew.Enabled = false;

        }

        private void btnShowNextTeacher_Click(object sender, EventArgs e)
        {
            if (pos != db.AmmountOfTeachers - 1)
            {
                pos++;
            }
            else
            {
                pos = 0;
            }
            ShowEntry(pos);
        }

        private void btnShowLastTeacher_Click(object sender, EventArgs e)
        {
            pos = db.AmmountOfTeachers - 1;
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
                pos = db.AmmountOfTeachers - 1;
            }
            ShowEntry(pos);
        }

        private void btnShowFirstTeacher_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowEntry(pos);
        }

        public void ShowEntry(int pos)
        {
            Teacher profesor = db.GetProfesor(pos);


            txtDNI.Text = profesor.dni;
            txtNombre.Text = profesor.Name;
            txtApellidos.Text = profesor.Surname;
            txtTlf.Text = profesor.Tlf;
            txteMail.Text = profesor.eMail;

            // lblEntryNumbers management.
            lblEntryNumber.Text = (int)((pos + 1)) + " de " + db.AmmountOfTeachers;
            CheckButtons();
            CheckNavButtons();
        }
        public void ShowEmpty()
        {
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTlf.Text = string.Empty;
            txteMail.Text = string.Empty;

            lblEntryNumber.Text = "0 de 0";

            CheckButtons();
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
                pos = db.AmmountOfTeachers - 1;
                ShowEntry(pos);

            }
             else
                ErrorMessage();

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

        }
        public void CheckNavButtons()
        {
            if (pos == db.AmmountOfTeachers - 1)
            {
                btnShowNextTeacher.Enabled = false;
                btnShowLastTeacher.Enabled = false;

            }
            else
            {
                btnShowNextTeacher.Enabled = true;
                btnShowLastTeacher.Enabled = true;
            }
            if (pos == 0)
            {
                btnShowPreviousTeacher.Enabled = false;
                btnShowFirstTeacher.Enabled = false;
            }
            else
            {
                btnShowPreviousTeacher.Enabled = true;
                btnShowFirstTeacher.Enabled = true;
            }
        }
        public void CheckButtons()
        {
            // In case, the ammount of teachers isn't more than 1.
            if (db.AmmountOfTeachers >= 1)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnShowEveryTeacher.Enabled = true;
                btnSaveNew.Enabled = false;
                btnLookBySurname.Enabled = true;
                btnAddTeacher.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnSaveNew.Enabled = false;
                btnShowEveryTeacher.Enabled = false;
                btnLookBySurname.Enabled = false;
                btnShowNextTeacher.Enabled = false;
                btnShowLastTeacher.Enabled = false;
            }
            // We set the btnUpdate.Enable to false always so we can activate and deactivate it when a change was done.
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult wantToDelete;
            wantToDelete = MessageBox.Show("Are you sure that you want to delete this teacher?", " ", MessageBoxButtons.YesNo);
            if (wantToDelete == DialogResult.Yes)
            {
                db.DeleteRow(pos);
                if (db.AmmountOfTeachers >= 1)
                {
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;

                    ShowEntry(pos);
                    MessageBox.Show("Student Deleted");
                }
                else
                {
                    ShowEmpty();
                }
            }
        }

        // TextBox were changed
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid() != null)
                {
                    btnUpdate.Enabled = true;
                }
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid() != null)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtTlf_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid() != null)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid() != null)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txteMail_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid() != null)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }
        public Teacher EntryIsValid()
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string surname = txtApellidos.Text;
            string tlf = txtTlf.Text;
            string email = txteMail.Text;

            Teacher profesor = Teacher.CreateTeacher(dni, nombre, surname, tlf, email);
            return profesor;
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

        private void btnShowEveryTeacher_Click(object sender, EventArgs e)
        {
            string text = db.GetEveryTeacher();
            MessageBox.Show("Teacher List:\n" + text);
        }
    }
}
