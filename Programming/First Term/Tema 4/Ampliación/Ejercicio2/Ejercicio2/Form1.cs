using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcMinimum(int n1, int n2, int n3)
        {
            int min = n1;
            if (n2 < min)
            {
                min = n2;
            }
            if (n3 < min)
            {
                min = n3;
            }
            return min;
        }

        int MaxComunDen(int n1, int n2, int n3)
        {
            int maxComunDiv = 0;
            int minimum = CalcMinimum(n1, n2, n3);
            bool divisorEncontrado = false;
            for (int i = minimum; !divisorEncontrado; i--)
            {
                if (n1 % i == 0 && n2 % i == 0 && n3 % i == 0)
                {
                    maxComunDiv = i;
                    divisorEncontrado = true;
                }
            }

            return maxComunDiv;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, minimum, maxComunDiv;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num3 = int.Parse(txtNum3.Text);
            minimum = CalcMinimum(num1, num2, num3);
            maxComunDiv = MaxComunDen(num1, num2, num3);

            MessageBox.Show("El numero mas pequeño es " + minimum);
            MessageBox.Show("El maximo comun divisor de los 3 numeros es: " + maxComunDiv);

        }
    }
}
