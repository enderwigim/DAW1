using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool compruebaDivisible(int n1, int n2)
        {
            bool esDivisible = false;
            if (n1 % n2 == 0)
            {
                esDivisible = true;
            }

            return esDivisible;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool esDivisible;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            esDivisible = compruebaDivisible(num1, num2);
            if (esDivisible)
            {
                MessageBox.Show("El numero es divisible");
            }
            else
            {
                MessageBox.Show("El numero no es divisible");
            }

        }
    }
}
