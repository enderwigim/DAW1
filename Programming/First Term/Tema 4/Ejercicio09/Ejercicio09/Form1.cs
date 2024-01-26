using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int exponencial(int n1, int n2)
        {
            int res;
            res = 1;
            for (int i = 1; i <= n2; i++)
            {
                res *= n1;
            }
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int base1, exponente, resultado;

            base1 = int.Parse(txtNum1.Text);
            exponente = int.Parse(txtNum2.Text);

            resultado = exponencial(base1, exponente);
            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}
