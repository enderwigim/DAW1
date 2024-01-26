using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_18
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

            resultado = 0;
            numeroIntroducido = int.Parse(txtNumero.Text);
            for (int i = 2; i <= numeroIntroducido; i += 2)
            {
                if (i % 2 == 0)
                {
                    resultado += i;
                }
            }
            MessageBox.Show("El resultado es: " + resultado.ToString());
        }
    }
}
