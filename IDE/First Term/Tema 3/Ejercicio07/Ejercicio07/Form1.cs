using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int maxDiv(int n1, int n2)
        {
            int divisorN1;
            divisorN1 = 0;
            for (int i = 1; i <= n1 && i <= n2; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    divisorN1 = i;
                }
            }
    

            return divisorN1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, maximoComunDiv;

            num1 = int.Parse(txtNum.Text);
            num2 = int.Parse(txtNum2.Text);
            
            maximoComunDiv = maxDiv(num1, num2);

            MessageBox.Show(maximoComunDiv.ToString());
        }
    }
}
