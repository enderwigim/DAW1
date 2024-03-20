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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }
        CourseList courses = new CourseList();
        PersonList people = new PersonList();
        private void bCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos(courses/*, students*/);

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.

            fCur.ShowDialog();
        }

        private void btnGestionAlumnos_Click(object sender, EventArgs e)
        {
            if (!courses.IsEmpty())
            {
                fStudents fStu = new fStudents(people, courses);

                fStu.ShowDialog();
            }
            else
            {
                MessageBox.Show("There's no courses yet. Please, add one before adding students.");
            }
            
        }

        private void btnTeachersAdministration_Click(object sender, EventArgs e)
        {
            /*
            fTeachers fTea = new fTeachers(teachers, courses);

            fTea.ShowDialog();
            */
        }
    }
}
