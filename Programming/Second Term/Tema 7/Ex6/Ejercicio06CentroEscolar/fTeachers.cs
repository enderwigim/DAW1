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
using System.Xml.Linq;

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
            DialogResult isTutor, moreTearchers;
            moreTearchers = DialogResult.Yes;
            

            while (moreTearchers == DialogResult.Yes)
            {
                bool wasAdded = false;
                name = Interaction.InputBox("What's the teacher name?");
                if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
                {
                    name = CustomFunctions.FirstLetterToCapital(name);
                    dni = Interaction.InputBox("What's the teacher DNI/NIE?");
                    if (dni.Length >= 9 && dni.Length <= 10 && teachers.GetIndexByDni(dni) == -1)
                    {
                        phoneNumber = Interaction.InputBox("What's the teacher phone number");
                        if (phoneNumber.Length >= 9 && phoneNumber.Length <= 13)
                        {
                            isTutor = MessageBox.Show("Is the teacher a tutor?", " ", MessageBoxButtons.YesNo);
                            if (isTutor == DialogResult.Yes)
                            {
                                courseCode = Interaction.InputBox("What's the teacher course code");
                                if (courses.GetIndexByCode(courseCode.ToUpper()) != -1)
                                {
                                    teachers.AddTutor(name, dni, phoneNumber, courseCode);
                                    wasAdded = true;
                                } else
                                {
                                    MessageBox.Show("That course doesn't exist");
                                }

                            } else
                            {
                                teachers.AddTeacher(name, dni, phoneNumber);
                                wasAdded = true;
                            }
                        } else
                        {
                            MessageBox.Show("That's not the correct format for a phone number");
                        }
                    } else
                    {
                        MessageBox.Show("Check if the format is Okay, or if that DNI already exist in the list");
                    }
                } else
                {
                    MessageBox.Show("Introduce the name properly");
                }
                if (wasAdded)
                {
                    moreTearchers = MessageBox.Show("Do you want to add another one?", " ", MessageBoxButtons.YesNo);
                } else
                {
                    MessageBox.Show("Try Again");
                }

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
                if (teachers.OrderByName())
                    MessageBox.Show("Teachers Ordered"); 
                else
                {
                    MessageBox.Show("There's just one teacher in the list");
                }
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }

        private void btnAddSubjectToTeacher_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");
                string subjectName = Interaction.InputBox("What subject do you want to add?");
                if (!subjectName.Any(char.IsDigit) || !string.IsNullOrWhiteSpace(subjectName))
                {
                    subjectName = CustomFunctions.FirstLetterToCapital(subjectName); ;
                    if(teachers.AddTeachersSubject(dni, subjectName))
                    {
                        MessageBox.Show("Subject added");
                    } else
                    {
                        MessageBox.Show("That teacher doesn't exist.");
                    }
                } else
                {
                    MessageBox.Show("That's no the name of a subject.");
                }
                

            } else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }

        private void btnDeleteSubjectsFromTeacher_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");


                if (teachers.DeleteTeachersSubject(dni))
                {
                    MessageBox.Show("Subjects deleted");
                }
                else
                {
                    MessageBox.Show("Check if the teacher has subjects or if exists");
                }
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }

        }

        private void btnShowTeachersBySubject_Click(object sender, EventArgs e)
        {
            if (!teachers.IsEmpty())
            {
                string teachersText = "There's no teachers teaching that subject";
                string subject = Interaction.InputBox("What subject are you looking for?");
                subject = CustomFunctions.FirstLetterToCapital(subject);
                if (teachers.ShowTeachersBySubject(subject) != "")
                {
                    
                    teachersText = "The teachers that teach " + subject + " are: \n";
                    teachersText += teachers.ShowTeachersBySubject(subject);
                }
                MessageBox.Show(teachersText);
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }

        }
    }
}
