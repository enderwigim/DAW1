using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            int numeroUsuario;
            string texto;

            texto = "El valor es: ";
            numeroUsuario = int.Parse(txtNumero.Text);

            for(int i = 1; i < numeroUsuario; i++)
            {
                texto += i + ", ";
            }
            MessageBox.Show(texto);
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int numeroUsuario, i;
            string texto;

            texto = "El valor es: ";
            numeroUsuario = int.Parse(txtNumero.Text);

            i = 1;
            while (i < numeroUsuario)
            {
                texto += i + ", ";
                i++;
            }
            MessageBox.Show(texto);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int numeroUsuario, i;
            string texto;

            texto = "El valor es: ";
            numeroUsuario = int.Parse(txtNumero.Text);

            i = 0;
            do
            {
                texto += i + ", ";
                i++;
            } while (i < numeroUsuario);
            MessageBox.Show(texto);
        }
    }
}
