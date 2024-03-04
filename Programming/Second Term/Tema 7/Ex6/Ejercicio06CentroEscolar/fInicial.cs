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
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        // Creamos la lista de cursos.
        CourseList courses = new CourseList();
        StudentList students = new StudentList();
        TeachersList teachers = new TeachersList();
        // Crear aquí también la lista de profesores y de alumnos.

        private void bCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos(courses, students);

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.
            
            fCur.ShowDialog();
        }

        private void btnGestionAlumnos_Click(object sender, EventArgs e)
        {
            if (!courses.IsEmpty())
            {
                fStudents fStu = new fStudents(courses, students);

                fStu.ShowDialog();
            } else
            {
                MessageBox.Show("There's no courses yet. Please, add one before adding students.");
            }
        }

        private void btnTeachersAdministration_Click(object sender, EventArgs e)
        {
            fTeachers fTea = new fTeachers(teachers, courses);

            fTea.ShowDialog();
        }
    }
}
