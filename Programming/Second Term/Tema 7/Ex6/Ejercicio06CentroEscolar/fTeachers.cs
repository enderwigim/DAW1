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

namespace Ejercicio06CentroEscolar
{
    public partial class fTeachers : Form
    {
        public fTeachers()
        {
            InitializeComponent();
        }
        public TeachersList teachers;
        public CourseList courses;
        public fTeachers(TeachersList teachers, CourseList courses)
        {
            InitializeComponent();
            this.teachers = teachers;
            this.courses = courses;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string name, dni, phoneNumber, courseCode;
            name = Interaction.InputBox("What's the teacher name?");
            if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
            {
                dni = Interaction.InputBox("What's the teacher DNI/NIE?");
                if (dni.Length >= 9 && dni.Length <= 10)
                {
                    phoneNumber = Interaction.InputBox("What's the teacher phone number");
                    if (phoneNumber.Length >= 9 && phoneNumber.Length <= 13)
                    {
                        courseCode = Interaction.InputBox("What's the teacher course code");
                        if (courses.GetIndexByCode(courseCode.ToUpper()) != -1)
                        {
                            teachers.AddTeacherToList(name, dni, phoneNumber, courseCode);
                        } else
                        {
                            MessageBox.Show("That course doesn't exist");
                        }
                    } else
                    {
                        MessageBox.Show("That's not the correct format for a phone number");
                    }
                } else
                {
                    MessageBox.Show("That's not a DNI/NIE");
                }
            } else
            {
                MessageBox.Show("Introduce the name properly");
            }

        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                MessageBox.Show(teachers.ShowTeachers());
            } else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");
                teachers.DeleteTeacherFromList(dni);
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }

        private void btnTeacherData_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");
                MessageBox.Show(teachers.ShowATeacher(dni));
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }

        private void btnOrderTeachers_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                teachers.OrderByName();
                MessageBox.Show("Teachers Ordered");
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }
    }
}
