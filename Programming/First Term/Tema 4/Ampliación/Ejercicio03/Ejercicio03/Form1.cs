using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int CalcMCM(int n1, int n2)
        {
           int mcm = 0;
           bool mcmEncontrado = false;
           for (int i = 1; !mcmEncontrado; i++)
            {
                
               if ((n1 * i) % n2 == 0)
                 {
                
                    mcm = n1 * i;
                    mcmEncontrado = true;
                 }
                // for (int j = 1; j <= (n1 * i) && !mcmEncontrado; j++)
                //{
                //    if ((n2 * j) == (n1 * i))
                //    {
                //        mcmEncontrado = true;
                //        mcm = n1 * i;
                //    }
                //}
            }
            return mcm;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num1, num2, mcm;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            mcm = CalcMCM(num1, num2);
            MessageBox.Show(mcm.ToString());
        }
    }
}
