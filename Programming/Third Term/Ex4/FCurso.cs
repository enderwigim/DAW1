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
    public partial class FCurso : Form
    {
        public FCurso()
        {
            InitializeComponent();
        }
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        private void FCurso_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper("Cursos");
            pos = 0;

            ShowEntry(pos);

            btnSaveNew.Enabled = false;
        }

        private void btnShowFirstCourse_Click(object sender, EventArgs e)
        {
            if (DidDataChanged())
            {
                if (isDataValid())
                {
                    DialogResult wantToUpdate = MessageBox.Show("Changes detected do you want to update?", " ", MessageBoxButtons.YesNo);
                    if (wantToUpdate == DialogResult.Yes)
                    {
                        btnUpdate.Enabled = true;
                        btnUpdate.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Changes were detected, but they are not valid");
                }

            }
            pos = 0;
            ShowEntry(pos);
        }

        private void btnShowPreviousCourse_Click(object sender, EventArgs e)
        {
            if (DidDataChanged())
            {
                if (isDataValid())
                {
                    DialogResult wantToUpdate = MessageBox.Show("Changes detected do you want to update?", " ", MessageBoxButtons.YesNo);
                    if (wantToUpdate == DialogResult.Yes)
                    {
                        btnUpdate.Enabled = true;
                        btnUpdate.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Changes were detected, but they are not valid");
                }

            }
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

        private void btnShowNextCourse_Click(object sender, EventArgs e)
        {
            if (DidDataChanged())
            {
                if (isDataValid())
                {
                    DialogResult wantToUpdate = MessageBox.Show("Changes detected do you want to update?", " ", MessageBoxButtons.YesNo);
                    if (wantToUpdate == DialogResult.Yes)
                    {
                        btnUpdate.Enabled = true;
                        btnUpdate.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Changes were detected, but they are not valid");
                }

            }
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

        private void btnShowLastCourse_Click(object sender, EventArgs e)
        {
            if (DidDataChanged())
            {
                if (isDataValid())
                {
                    DialogResult wantToUpdate = MessageBox.Show("Changes detected do you want to update?", " ", MessageBoxButtons.YesNo);
                    if (wantToUpdate == DialogResult.Yes)
                    {
                        btnUpdate.Enabled = true;
                        btnUpdate.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Changes were detected, but they are not valid");
                }

            }
            pos = db.AmmountOfEntries - 1;
            ShowEntry(pos);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();


            btnSaveNew.Enabled = true;
            btnAddCourse.Enabled = false;
            isANewEntry = true;

            CheckButtons();
            CheckNavButtons();
            ManageTxts();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string nombre = txtName.Text;


            Course course = Course.CreateCourse(id, nombre);
            if (course != null)
            {
                if (db.CreateRow(course))
                {
                    btnSaveNew.Enabled = false;
                    isANewEntry = false;
                    pos = db.AmmountOfEntries - 1;
                    ShowEntry(pos);
                }
                else
                {
                    MessageBox.Show("That course is already in the database");
                }

            }
            else
                ErrorMessage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string nombre = txtName.Text;  


            Course course = Course.CreateCourse(id, nombre);
            if (course != null)
            {
                if (db.UpdateRow(course, pos))
                {
                    MessageBox.Show("Data Updated");
                } else
                {
                    MessageBox.Show("That course is alredy in the database");
                }
            }
            else
                ErrorMessage();
            ShowEntry(pos);
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
        public void CheckButtons()
        {
            btnAddCourse.Enabled = (!isANewEntry);
            btnDelete.Enabled = (db.AmmountOfEntries != 0 && !isANewEntry);
            btnSaveNew.Enabled = (isANewEntry);
            

            btnUpdate.Enabled = false;
        }

        public void ManageTxts()
        {
            txtID.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
            txtName.ReadOnly = (!(db.AmmountOfEntries >= 1) && !isANewEntry);
        }
        public void ShowEntry(int pos)
        {
            if (db.AmmountOfEntries >= 1)
            {
                Course course = (Course)db.GetEntry(pos);
                if (course == null)
                {
                    ErrorMessage();
                }
                else
                {
                    txtID.Text = course.ID.ToString();
                    txtName.Text = course.Name;
                  
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
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;

            lblEntryNumber.Text = "0 de 0";


        }
        public void ErrorMessage()
        {
            MessageBox.Show("There was an error with the data introduced: \n" +
                            "Follow the next examaple to do it properly\n" +
                            "ID: DAW  (MIN 3 CHARACTERS | MAX 4 CHARACTERS)\n" +
                            "Name: Desarrollo de Aplicaciones Web\n");
        }
        public void CheckNavButtons()
        {
            btnShowNextCourse.Enabled = (db.AmmountOfEntries != 0 && pos < db.AmmountOfEntries - 1 && !isANewEntry);
            btnShowPreviousCourse.Enabled = (db.AmmountOfEntries != 0 && pos > 0 && !isANewEntry);
            btnShowLastCourse.Enabled = (db.AmmountOfEntries != 0 && pos != db.AmmountOfEntries - 1 && !isANewEntry);
            btnShowFirstCourse.Enabled = (db.AmmountOfEntries != 0 && pos != 0 && !isANewEntry);
        }
        public bool isDataValid()
        {
            bool isValid = false;
            
            string id = txtID.Text;
            string name = txtName.Text;

            if (Course.CreateCourse(id, name) != null)
            {
                isValid = true;
            }
            return isValid;

            
        }
        public bool DidDataChanged()
        {
            bool dataChanged = true;
            Course dbCourse = (Course)db.GetEntry(pos);
            if (dbCourse.ID == txtID.Text &&
                dbCourse.Name == txtName.Text)
                dataChanged = false;
            return dataChanged;
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (isDataValid() && !isANewEntry)
            {
                btnUpdate.Enabled = true;
            } else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
            if (isDataValid() && !isANewEntry)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

    }
}
