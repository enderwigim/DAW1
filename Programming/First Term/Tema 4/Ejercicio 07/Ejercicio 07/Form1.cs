using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcularMaximoComunDiv (int num1, int num2)
        {
            int maximoComunDiv = 0;
            bool encontrado = false;

            if (num1 > num2)
            {
                for (int i = num1; !encontrado; i--)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        maximoComunDiv = i;
                        encontrado = true;
                    }
                }
            }
            else
            {
                for (int i = num2; !encontrado; i--)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        maximoComunDiv = i;
                        encontrado = true;
                    }
                }
            }

            return maximoComunDiv;
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, maximoComunDiv;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            maximoComunDiv = CalcularMaximoComunDiv(num1, num2);
            MessageBox.Show(maximoComunDiv.ToString());

            
        }
    }
}
