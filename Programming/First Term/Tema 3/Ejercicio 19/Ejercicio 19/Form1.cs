using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numeroIntroducido, resultado;

            numeroIntroducido = int.Parse(txtNumero.Text);

            resultado = 1;
            for (int i = 1; i <= numeroIntroducido; i++)
            {
                resultado *= i;
            }
            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}
