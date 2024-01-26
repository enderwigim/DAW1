using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int obtenerModulo(int n1)
        {
            int numModulo = n1;
            if (numModulo < 0)
            {
                numModulo *= -1;
            }

            return numModulo;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, modulo;

            num1 = int.Parse(txtNum1.Text);

            modulo = obtenerModulo(num1);
            MessageBox.Show("El valor absoluto de: " + num1 + " es " + modulo);
        }
    }
}
