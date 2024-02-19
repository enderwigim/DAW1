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

        public ListaCursos listaCursos;
       // public ListaAlumnos listaAlumnos; //necesaria para el botón de mostrar los alumnos por curso.

        private void fCursos_Load(object sender, EventArgs e)
        {

        }
        public fCursos(ListaCursos listaCursos)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.listaCursos = listaCursos;
        }

    }
}
