using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool divisorEncontrado;

            num = int.Parse(txtNum.Text);
            divisorEncontrado = false;


            if (num > 1)
            {
                for (int i = 2; i < num && divisorEncontrado == false; i++)
                {
                    if (num % i == 0)
                    {
                        divisorEncontrado = true;
                    }
                }
                if (! divisorEncontrado)
                {
                    MessageBox.Show("El numero es primo.");
                }
                else
                {
                    MessageBox.Show("El numero no es primo");
                }
            }
            else
            {
                MessageBox.Show("Ningun numero menos o igual a 1 es primo.");
            }
        }
    }
}
