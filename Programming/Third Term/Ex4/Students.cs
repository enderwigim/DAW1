﻿using Microsoft.VisualBasic;
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
    public partial class FStudents : Form
    {
        public FStudents()
        {
            InitializeComponent();
        }
        // Global Variables
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        private void Students_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper("Cursos");
            pos = 0;

            ShowEntry(pos);

            btnSaveNew.Enabled = false;
        }

        private void btnShowFirstStudent_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowEntry(pos);
        }

        private void btnShowPreviousStudent_Click(object sender, EventArgs e)
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

        private void btnShowNextStudent_Click(object sender, EventArgs e)
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

        private void btnShowLastStudent_Click(object sender, EventArgs e)
        {

            pos = db.AmmountOfEntries - 1;
            ShowEntry(pos);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTlf.Clear();
            txtAddress.Clear();

            btnSaveNew.Enabled = true;
            btnAddStudent.Enabled = false;
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
            string address = txtAddress.Text;

            Student student = Student.CreateStudent(dni, nombre, surname, address, tlf);
            if (student != null)
            {
                if (db.CreateRow(student))
                {
                    btnSaveNew.Enabled = false;
                    isANewEntry = false;
                    pos = db.AmmountOfEntries - 1;
                    ShowEntry(pos);
                }
                else
                {
                    MessageBox.Show("That student is already in the database");
                }

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
            string address = txtAddress.Text;

            Student student = Student.CreateStudent(dni, nombre, surname, tlf, address);
            if (student != null)
                db.UpdateRow(student, pos);
            else
                ErrorMessage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult wantToDelete;
            wantToDelete = MessageBox.Show("Are you sure that you want to delete this student?", " ", MessageBoxButtons.YesNo);
            if (wantToDelete == DialogResult.Yes)
            {
                db.DeleteRow(pos);
                if (db.AmmountOfEntries >= 1)
                {
                    if (pos > 0)
                    {
                        // We will show the previous student.
                        pos--;
                    }
                    // Else we show that position student
                    ShowEntry(pos);
                    MessageBox.Show("Student Deleted");
                }
                else
                {
                    ShowEntry(pos);
                }
            }
        }

        private void btnLookBySurname_Click(object sender, EventArgs e)
        {
            string surname = Interaction.InputBox("What surname do you want to look for?");
            int foundedPos = db.LookBySurname(surname);
            if (foundedPos != -1)
                pos = foundedPos;
            else
                MessageBox.Show("That student wasn't founded");
            ShowEntry(pos);
        }

        private void btnShowEveryStudent_Click(object sender, EventArgs e)
        {
            string everyName = db.GetEveryName();
            if (everyName != "")
            {
                MessageBox.Show("The students in the database are: \n" + everyName);
            }
            else
            {
                MessageBox.Show("There's no students in the database");
            }
        }
        public void CheckButtons()
        {
            btnAddStudent.Enabled = (!isANewEntry);
            btnDelete.Enabled = (db.AmmountOfEntries != 0 && !isANewEntry);
            btnSaveNew.Enabled = (isANewEntry);
            btnLookBySurname.Enabled = (db.AmmountOfEntries > 1 && !isANewEntry);
            btnShowEveryStudent.Enabled = (db.AmmountOfEntries > 1 && !isANewEntry);

            btnUpdate.Enabled = false;
        }

        public void ManageTxts()
        {
            txtDNI.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtNombre.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtApellidos.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtTlf.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtAddress.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
        }
        public void ShowEntry(int pos)
        {
            if (db.AmmountOfEntries >= 1)
            {
                Student student = (Student)db.GetEntry(pos);
                if (student == null)
                {
                    ErrorMessage();
                }
                else
                {
                    txtDNI.Text = student.DNI;
                    txtNombre.Text = student.Name;
                    txtApellidos.Text = student.Surname;
                    txtTlf.Text = student.Tlf;
                    txtAddress.Text = student.Address;
                }
                // lblEntryNumbers management.
                lblEntryNumber.Text = (int)((pos + 1)) + " de " + db.AmmountOfEntries;


            }
            else
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
            txtAddress.Text = string.Empty;

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
                            "Address: Yapeyu 493");
        }
        public void CheckNavButtons()
        {
            btnShowNextStudent.Enabled = (db.AmmountOfEntries != 0 && pos < db.AmmountOfEntries - 1 && !isANewEntry);
            btnShowPreviousStudent.Enabled = (db.AmmountOfEntries != 0 && pos > 0 && !isANewEntry);
            btnShowLastStudent.Enabled = (db.AmmountOfEntries != 0 && pos != db.AmmountOfEntries - 1 && !isANewEntry);
            btnShowFirstStudent.Enabled = (db.AmmountOfEntries != 0 && pos != 0 && !isANewEntry);
        }
    }
}
