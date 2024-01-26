using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int expo(int n1, int n2)
        {
            int res = 1;
            
            for (int i = 1; i <= n2; i++)
            {
                res *= n1;
            }
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int base1, exponente1, resultado;

            base1 = int.Parse(txtNum1.Text);
            exponente1 = int.Parse(txtNum2.Text);

            resultado = expo(base1, exponente1);

            MessageBox.Show(resultado.ToString());
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
