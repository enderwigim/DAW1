using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CalcularResultadoResto(int n1, int n2, out int resultado, out int resto)
        {
            resultado = n1 / n2;
            resto = n1 % n2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado, resto;


            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            resultado = resto = 0;

            CalcularResultadoResto(num1, num2, out resultado, out resto);

            MessageBox.Show(resultado + " " + resto);
        }
    }
}
