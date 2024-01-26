using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            int numeroIntroducido;
            string texto;

            numeroIntroducido = int.Parse(txtNumero.Text);
            texto = "El valor es: ";
            for (int i = 2; i <= numeroIntroducido; i += 2)
            {
                texto += i + ", ";
            }
            MessageBox.Show(texto);
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int numeroIntroducido, i;
            string texto;

            numeroIntroducido = int.Parse(txtNumero.Text);
            texto = "El valor es: ";

            i = 2;
            while (i <= numeroIntroducido)
            {
                texto += i + ", ";
                i += 2;
            }
            MessageBox.Show(texto);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int numeroIntroducido, i;
            string texto;

            numeroIntroducido = int.Parse(txtNumero.Text);
            texto = "El valor es: ";

            i = 0;
            do
            {
                i += 2;
                texto += i + ", ";
            } while (i <= numeroIntroducido);
            MessageBox.Show(texto);
        }
    }
}
