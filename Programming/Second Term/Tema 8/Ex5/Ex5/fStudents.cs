using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                    addMoreStudents = MessageBox.Show("Do you want to add another student?", " ", MessageBoxButtons.YesNo);
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
            // TODO: Check if there's teachers in the list
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

        private void btnOrderByName_Click(object sender, EventArgs e)
        {
            if (!people.IsEmpty())
            {
                people.OrderStudents();
                MessageBox.Show("List Ordered");
            }
            else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentData_Click(object sender, EventArgs e)
        {
            if (!people.IsEmpty())
            {
                string name = Interaction.InputBox("What's the student Name?");
                MessageBox.Show(people.ShowOneStudentByName(name));
                
            }
            else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnShowStudentsFromCourse_Click(object sender, EventArgs e)
        {
            if (!courses.IsEmpty())
            {
                string studentsInCourse = "The course doesn't exist";
                string courseCode = Interaction.InputBox("What course's students do you want to see?");
                int index = courses.GetIndexByCode(courseCode);

                if (index != -1)
                {
                    if (people.ShowEveryStudentInCourse(courseCode) != "")
                    {
                        studentsInCourse = "The students in " + courseCode.ToUpper() + " are: \n";
                        studentsInCourse += people.ShowEveryStudentInCourse(courseCode);

                    }
                    else
                    {
                        studentsInCourse = "The course is empty";
                    }
                }
                MessageBox.Show(studentsInCourse);
            }
            else
            {
                MessageBox.Show("No courses were added yet.");
            }
        }

        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            if (!people.IsEmpty())
            {
                DialogResult addMoreGrades = DialogResult.Yes;
                DialogResult addGradeToSameStudents = DialogResult.No;
                while (addMoreGrades == DialogResult.Yes)
                {
                    string dni = null;
                    if (addGradeToSameStudents == DialogResult.No)
                    {
                        dni = Interaction.InputBox("What's the student dni?");
                    }
                    int newGrade = int.Parse(Interaction.InputBox("What grade?"));
                    int result = people.AddGradeToStudent(dni, newGrade);
                    if (result == -1)
                    {
                        MessageBox.Show("That student is not in the list");
                    }
                    else if (result == -2)
                    {
                        MessageBox.Show("That dni is not from a student");
                    }
                    else
                    {
                        MessageBox.Show("Grade added!");
                    }
                    addGradeToSameStudents = MessageBox.Show("Do you want to add another grade to the same student?", " ", MessageBoxButtons.YesNo);
                    if (addGradeToSameStudents == DialogResult.No)
                    {
                        addMoreGrades = MessageBox.Show("And to another student?", " ", MessageBoxButtons.YesNo);
                    }
                }
            }
            else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }
    private void btnDeleteGrades_Click(object sender, EventArgs e)
        {
                if (!people.IsEmpty())
                {
                    string dni = Interaction.InputBox("What's the student dni?");
                    int result = people.RemoveGradeToStudent(dni);
                    if (result == -1)
                    {
                        MessageBox.Show("That student is not in the list");
                    }
                    else if (result == -2)
                    {
                        MessageBox.Show("That dni is not from a student");
                    }
                    else
                    {
                        MessageBox.Show("Grade added!");
                    }

                }
                else
                {
                    MessageBox.Show("There's no students in the list yet.");
                }

        }

        private void btnShowStudentsWithAVGUpperThan5_Click(object sender, EventArgs e)
        {
            if (!people.IsEmpty())
            {
                string students = people.ShowStudentsAVGMore5();
                if (students == "")
                {
                    MessageBox.Show("There's no students with an AVG more than 5");
                } else
                {
                    MessageBox.Show("The students with an AVG more than 5 are: \n" + students);
                }
            }
            else
            {
                MessageBox.Show("The list is empty yet.");
            }
        }
        

        private void btnShowStudentsWithAVGLessThan5_Click(object sender, EventArgs e)
        {
            if (!people.IsEmpty())
            {
                if (people.CountStudentsAVGLess5() > 0)
                {
                    string students = people.ShowStudentsAVGLess5();
                    MessageBox.Show("The students with an AVG less than 5 are: \n" + students);
                } else
                {
                    MessageBox.Show("There's no students with an AVG less than 5");
                }
            }
            else
            {
                MessageBox.Show("The list is empty yet.");
            }
        }
    }
}

