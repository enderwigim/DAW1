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
    }
}
