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
    public partial class fCursos : Form
    {
        public CourseList courseList;
        public PersonList people;
        public fCursos(CourseList courseList,PersonList personList)
        {
            InitializeComponent();
            this.courseList = courseList;
            this.people = personList;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            DialogResult addMoreCourses = DialogResult.Yes;
            while (addMoreCourses == DialogResult.Yes)
            {
                bool wasAdded = false;
                string name = Interaction.InputBox("Add a nombre to the course");
                string code = Interaction.InputBox("Add a code to the course");

                if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
                {
                    if (code.Length >= 3 && code.Length <= 4)
                    {
                        if (!courseList.AddCourse(name, code))
                        {
                            MessageBox.Show("That course is already in the list");
                        }
                        else
                        {
                            MessageBox.Show("Course Added");
                            wasAdded = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The course's lenght must be between 3 and 4 chars");
                    }
                }
                else
                {
                    MessageBox.Show("The Course can't be empty or have any digits in it.");
                }
                if (wasAdded)
                {
                    addMoreCourses = MessageBox.Show("Do you want to add more", "", MessageBoxButtons.YesNo);
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (!courseList.IsEmpty())
            {
                string code = Interaction.InputBox("What course do you want to delete?");
                if (courseList.RemoveCourse(code))
                {
                    MessageBox.Show("The course was deleted");
                }
                else
                {
                    MessageBox.Show("That course doesn't exist");
                }
            }
            else
            {
                MessageBox.Show("There's no courses in the list yet.");
            }

        }

        private void btnShowEveryCourse_Click(object sender, EventArgs e)
        {
            string text = courseList.ShowEveryCourse();
            if (text != "")
            {
                MessageBox.Show(text);
            }
            else
            {
                MessageBox.Show("There's no courses in the list");
            }
        }

        private void ShowEveryStudentInCourse_Click(object sender, EventArgs e)
        {
            if (!courseList.IsEmpty())
            {
                string studentsInCourse = "The course doesn't exist";
                string courseCode = Interaction.InputBox("What course's students do you want to see?");
                int index = courseList.GetIndexByCode(courseCode);

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
    }
}
