using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool esPrimo (int num)
        {
            bool primo = true;

            for (int i = 2; i < num; i++)
            {
               if (num % i == 0)
                {
                    primo = false;
                }
        
            }

            return primo;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num;
            string primos = "";

            num = int.Parse(txtNum.Text);
            for (int i = 2; i < num; i++)
            {
                if (esPrimo(i))
                {
                    primos += i + "\n";
                }
            }
            lblNumPrimo.Text = primos;
        }
    }
}
