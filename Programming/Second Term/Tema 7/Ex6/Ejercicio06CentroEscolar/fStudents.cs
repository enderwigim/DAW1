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
    public partial class fStudents : Form
    {
        public fStudents()
        {
            InitializeComponent();
        }
        public CourseList courseList;
        public StudentList studentList;

        public fStudents(CourseList courseList, StudentList studentList)
        {
            InitializeComponent();
            this.courseList = courseList;
            this.studentList = studentList;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student new_student = new Student();
            string name = Interaction.InputBox("Add a name to the student please");
            if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
            {
                string dni = Interaction.InputBox("Add an ID to the student please");
                if (dni.Length == 10 || dni.Length == 9)
                {
                    string phoneNumber = Interaction.InputBox("Add a phone number to the student");
                    if (phoneNumber.Length >= 9 && phoneNumber.Length <= 13)
                    {
                        string courseCode = Interaction.InputBox("Add the student into a course").ToUpper();
                        if (courseList.GetIndexByCode(courseCode) != -1)
                        {
                            new_student.Name = name;
                            new_student.Dni = dni;
                            new_student.PhoneNumber = phoneNumber;
                            new_student.CourseCode = courseCode.ToUpper();
                            studentList.AddStudentToList(new_student);
                            MessageBox.Show("Student was added");
                        } else
                        {
                            MessageBox.Show("That course doesn't exist.");
                        }
                    } else
                    {
                        MessageBox.Show("A phone number must have between 9 and 13 chars.");
                    }
                } else
                {
                    MessageBox.Show("That's not a DNI/NIE");
                }
            } else
            {
                MessageBox.Show("That name isn't correct.");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (studentList.IsEmpty())
            {
                string dni = Interaction.InputBox("Write the student's DNI/NIE.");
                int index = studentList.GetIndexByDNI(dni);
                if (index != -1)
                {
                    studentList.RemoveStudentFromList(index);
                    MessageBox.Show("Student removed.");
                }
                MessageBox.Show("That student doesn't exist.");
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentData_Click(object sender, EventArgs e)
        {
            if (studentList.IsEmpty())
            {
                string studentInfo = "That student doesn't exist";
                string dni = Interaction.InputBox("Write the student's DNI/NIE.");
                int index = studentList.GetIndexByDNI(dni);
                if (index != -1)
                {
                    studentInfo = studentList.ShowStudentAtIndex(index);
                }
                MessageBox.Show(studentInfo);
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentList_Click(object sender, EventArgs e)
        {
            if (studentList.IsEmpty())
            {
                string studentsText = studentList.ShowEveryStudent();
                MessageBox.Show(studentsText);
            } else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentsFromCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
