﻿using System;
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
            //CheckButtons();
            CheckNavButtons();
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
    }
}
