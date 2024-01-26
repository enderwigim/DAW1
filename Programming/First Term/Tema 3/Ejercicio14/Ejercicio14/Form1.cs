using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFOR_Click(object sender, EventArgs e)
        {
            int i, num;

            num = 0;
            for (i = 0; i <= 10; i++)
            {
                num += i;
            }
            MessageBox.Show("El resultado es: " + num);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i, num;

            num = 0;
            i = 0;
            while (i <= 10)
            {
                num += i;
                i++;
            }
            MessageBox.Show("El resultado es: " + num);
        }
    }
}
