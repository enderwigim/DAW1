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

namespace Ex5
{
    public partial class fStudents : Form
    {
        private PersonList people;
        private CourseList courses;
        public fStudents(PersonList people, CourseList courses)
        {
            InitializeComponent();
            this.people = people;
            this.courses = courses;

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DialogResult addMoreStudents = DialogResult.Yes;
            while (addMoreStudents == DialogResult.Yes)
            {
                bool wasAdded = false;
                
                string name = Interaction.InputBox("Add a name to the student please");
                if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
                {
                    string dni = Interaction.InputBox("Add an ID to the student please");
                    if ((dni.Length == 10 || dni.Length == 9) && !people.IsIDInList(dni))
                    {
                        string phoneNumber = Interaction.InputBox("Add a phone number to the student");
                        if (phoneNumber.Length >= 9 && phoneNumber.Length <= 13)
                        {
                            string courseCode = Interaction.InputBox("Add the student into a course").ToUpper();
                            if (courses.GetIndexByCode(courseCode) != -1)
                            {
                                
                                Student new_student = new Student(courseCode, name, dni, phoneNumber);
                                people.AddStudent(new_student);
                                wasAdded = true;
                                MessageBox.Show("Student was added");

                            }
                            else
                            {
                                MessageBox.Show("That course doesn't exist.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("A phone number must have between 9 and 13 chars.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("That student's DNI/NIE already exist or format is not correct.");
                    }
                }
                else
                {
                    MessageBox.Show("That name isn't correct.");
                }
                if (wasAdded)
                {
                    addMoreStudents = MessageBox.Show("Do you want to add anothe student?", " ", MessageBoxButtons.YesNo);
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            }
        }

        private void btnShowStudentList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(people.ShowEveryStudent());
            
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (!people.IsEmpty())
            {
                string dni = Interaction.InputBox("Write the student's DNI/NIE.").ToUpper();
                int index = people.GetIndexByDNI(dni);
                if (index != -1)
                {
                    if (people.GetTypeByIndex(index) == 1)
                    {
                        people.DeleteByIndex(index);
                        MessageBox.Show("Student deleted");
                    } else
                    {
                        MessageBox.Show("That person isn't a student");
                    }
                }
                else
                {
                    MessageBox.Show("That student doesn't exist.");
                }
            }
            else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }
    }
}
