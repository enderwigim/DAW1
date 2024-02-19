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
        ListaCursos listaCursos = new ListaCursos();
        // Crear aquí también la lista de profesores y de alumnos.

        private void bCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos(listaCursos);

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.
            
            fCur.ShowDialog();
        }
    }
}
