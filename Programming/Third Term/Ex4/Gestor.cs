using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4.AppData
{
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }

        private void btnOpenCourses_Click(object sender, EventArgs e)
        {
            FCurso fCur = new FCurso();
            fCur.ShowDialog();
            fCur.Close();
        }

        private void btnOpenStudents_Click(object sender, EventArgs e)
        {
            FStudents fStudents = new FStudents();
            fStudents.ShowDialog();
            fStudents.Close();
        }

        private void btnOpenTeachers_Click(object sender, EventArgs e)
        {
            FTeacher fTeacher = new FTeacher();
            fTeacher.ShowDialog();
            fTeacher.Close();
        }
    }
}
