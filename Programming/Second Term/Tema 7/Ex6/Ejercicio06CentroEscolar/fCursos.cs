using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        public CourseList courseList;
       // public ListaAlumnos listaAlumnos; //necesaria para el botón de mostrar los alumnos por curso.

        private void fCursos_Load(object sender, EventArgs e)
        {

        }
        public fCursos(CourseList courseList)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.courseList = courseList;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Add a nombre to the course");
            string code = Interaction.InputBox("Add a course to the course");

            if (!name.Any(char.IsDigit) && !string.IsNullOrWhiteSpace(name))
            {
                if (code.Length == 3) {
                    if (!courseList.AddCourse(name, code))
                    {
                        MessageBox.Show("That course is already in the list");
                    }else
                    {
                        MessageBox.Show("Course Added");
                    }
                } else
                {
                    MessageBox.Show("The course's lenght must be of 3 chars");
                }
            } else
            {
                MessageBox.Show("The Course can't be empty or have any digits in it.");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            string code = Interaction.InputBox("What course do you want to delete?");
            int index = courseList.GetIndexByCode(code);
            if (index != 1)
            {
                courseList.RemoveCourse(index);
                MessageBox.Show("The course was deleted");
            } else
            {
                MessageBox.Show("That course doesn't exist");
            }
        }

        private void btnShowEveryCourse_Click(object sender, EventArgs e)
        {
            string text = courseList.ShowEveryCourse();
            if (text != "")
            {
                MessageBox.Show(text);
            } else
            {
                MessageBox.Show("There's no courses in the list");
            }
            
        }
    }
}


// Last week, while I was returning home, I found a TV in the trash.
// It was in perfect shape, so I took it home
// I was really surprised when I founded out that It worked perfectly