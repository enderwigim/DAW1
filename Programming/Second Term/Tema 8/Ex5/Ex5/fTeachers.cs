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
    public partial class fTeachers : Form
    {
        private PersonList _people;
        private CourseList _courses;
        public fTeachers(PersonList people, CourseList courses)
        {
            InitializeComponent();
            _people = people;
            _courses = courses;

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string name, dni, phoneNumber, courseCode, email;
            DialogResult isTutor, moreTearchers;
            moreTearchers = DialogResult.Yes;


            while (moreTearchers == DialogResult.Yes)
            {
                bool wasAdded = false;
                name = Interaction.InputBox("What's the teacher name?");
                if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
                {

                    dni = Interaction.InputBox("What's the teacher DNI/NIE?");
                    if (dni.Length >= 9 && dni.Length <= 10 && _people.GetIndexByDNI(dni) == -1)
                    {
                        phoneNumber = Interaction.InputBox("What's the teacher phone number");
                        if (phoneNumber.Length >= 9 && phoneNumber.Length <= 13)
                        {

                            email = Interaction.InputBox("Add an email");
                            if (email.Length >= 9 && email.Contains("@"))
                            {
                                if (!_people.isEmailInList(email))
                                {
                                    isTutor = MessageBox.Show("Is the teacher a tutor?", " ", MessageBoxButtons.YesNo);
                                    if (isTutor == DialogResult.Yes)
                                    {
                                        courseCode = Interaction.InputBox("What's the teacher course code");
                                        if (_courses.GetIndexByCode(courseCode.ToUpper()) != -1)
                                        {
                                            Teacher newTutor = new Teacher(courseCode, email, name, dni, phoneNumber);
                                            _people.AddTeacher(newTutor);
                                            wasAdded = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("That course doesn't exist");
                                        }

                                    }
                                    else
                                    {
                                        Teacher newTeacher = new Teacher(email, name, dni, phoneNumber);
                                        _people.AddTeacher(newTeacher);
                                        wasAdded = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("That email is already in the list");
                                }
                            }
                            else
                            {
                                MessageBox.Show("That email doesn't have a proper structure");
                            }


                        }
                        else
                        {
                            MessageBox.Show("That's not the correct format for a phone number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check if the format is Okay, or if that DNI already exist in the list");
                    }
                }
                else
                {
                    MessageBox.Show("Introduce the name properly");
                }
                if (wasAdded)
                {
                    moreTearchers = MessageBox.Show("Do you want to add another one?", " ", MessageBoxButtons.YesNo);
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
        }

        private void btnShowTeachers_Click(object sender, EventArgs e)
        {
            if (!_people.IsEmpty())
            {
                MessageBox.Show(_people.ShowTeachers());
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (!_people.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");
                int result = _people.DeleteTeacher(dni);
                if (result == -1)
                {
                    MessageBox.Show("There's no teachers in the list");
                } else if (result == -2)
                {
                    MessageBox.Show("That teacher is not in the list");
                } else if (result == -3)
                {
                    MessageBox.Show("That dni is not from a teacher");
                }
                else
                {
                    MessageBox.Show("Teacher Deleted");
                }
            }
            else
            {
                MessageBox.Show("There's no people in the list yet.");
            }
        }

        private void btnTeacherData_Click(object sender, EventArgs e)
        {
            if (!_people.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");
                MessageBox.Show(_people.ShowATeacher(dni));
            }
            else
            {
                MessageBox.Show("There's no people in the list yet.");
            }
        }

        private void btnOrderTeachers_Click(object sender, EventArgs e)
        {
            if (!_people.IsEmpty())
            {
                _people.OrderTeachers();
                MessageBox.Show("List Ordered");
            }
            else
            {
                MessageBox.Show("There's no students in the list yet.");
            }
        }

        private void btnAddSubjectToTeacher_Click(object sender, EventArgs e)
        {
            if (!_people.IsEmpty())
            {
                string dni = Interaction.InputBox("What's the teacher's DNI??");
                DialogResult addMoreSubjects = DialogResult.Yes;
                DialogResult addToSameDni = DialogResult.Yes;
                while (addMoreSubjects == DialogResult.Yes)
                {
                    if (addToSameDni == DialogResult.No)
                    {
                        dni = Interaction.InputBox("What's the teacher's DNI??");
                    }
                    bool wasAdded = false;
                    string subjectName = Interaction.InputBox("What subject do you want to add?");
                    if (!subjectName.Any(char.IsDigit) || !string.IsNullOrWhiteSpace(subjectName))
                    {
                        int result = _people.AddTeachersSubject(dni, subjectName);
                        if (result == -1)
                        {
                            MessageBox.Show("There's no teacher in the List");
                            addToSameDni = DialogResult.No;
                        }
                        else if (result == -2)
                        {
                            MessageBox.Show("That DNI is not in the list");
                            addToSameDni = DialogResult.No;
                        }
                        else if (result == -3)
                        {
                            MessageBox.Show("That DNI is not from a teacher");
                            addToSameDni = DialogResult.No;
                        }
                        else
                        {
                            wasAdded = true;
                            MessageBox.Show("Subject added");
                            addToSameDni = MessageBox.Show("Do you want to add more subjects to the same teacher?", "", MessageBoxButtons.YesNo);
                            if (addToSameDni != DialogResult.Yes)
                            {
                                addMoreSubjects = MessageBox.Show("Do you want to add more subjects to another teacher?", "", MessageBoxButtons.YesNo);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("That's no the name of a subject.");
                    }
                }
            }
            else
            {
                MessageBox.Show("There's no teachers in the list yet.");
            }
        }
    }
}
