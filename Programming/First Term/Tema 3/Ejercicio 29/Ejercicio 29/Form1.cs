using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1;
            double resultado, a;
            resultado = 0;
            num1 = int.Parse(txtNum.Text);
            
            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 != 0)
                {
                    resultado += (1 / (double)i);
                }
                else
                {
                    resultado -= (1 / (double)i);
                }
            }

            MessageBox.Show(resultado.ToString());
        }
    }
}
