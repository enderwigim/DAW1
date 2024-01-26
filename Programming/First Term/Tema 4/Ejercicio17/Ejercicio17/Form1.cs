using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        int division(int n1, int n2)
        {
            int res;
            res = 0;
            while (n1 > 0)
            {
                n1 -= n2;
                if (n1 >= 0)
                {
                    res++;
                }
                
            }
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            resultado = division(num1, num2);
            MessageBox.Show(resultado.ToString());

        }
    }
}
