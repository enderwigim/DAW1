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

        }
    }
}
