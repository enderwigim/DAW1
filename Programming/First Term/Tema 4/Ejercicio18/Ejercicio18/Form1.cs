using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factorialN(int n1)
        {
            int res = 1;
            for(int i = 1; i <= n1; i++)
            {
                res *= i;
            }
            return res;
        }

        int exponencialM(int base1, int exponente)
        {
            int res = 1;
            for(int i = 1; i <= exponente; i++)
            {
                res *= base1;
            }
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numN, numM, factorial, exponencial;
            double resultado;

            numN = int.Parse(txtNum1.Text);
            numM = int.Parse(txtNum2.Text);
            resultado = 0;

            for (int i = 1; i <= numM; i++)
            {
                factorial = factorialN(i);
                exponencial = exponencialM(numN, i);
                resultado += (double)exponencial / (double)factorial;

            }
            MessageBox.Show(resultado.ToString());
        }
    }
}
