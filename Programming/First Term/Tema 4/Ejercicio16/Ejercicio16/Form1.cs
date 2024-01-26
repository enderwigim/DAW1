using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factorial(int n1)
        {
            int res = 1;
            for (int i = 1; i <= n1; i++)
            {
                res *= i;
            }
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, resultado;

            num1 = int.Parse(txtNum1.Text);

            resultado = factorial(num1);
            MessageBox.Show(resultado.ToString());
        }
    }
}
