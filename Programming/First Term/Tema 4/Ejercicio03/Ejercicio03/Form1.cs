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
        void IntercambiarNum(ref int n1, ref int n2)
        {
            int n3;

            n3 = n1;
            n1 = n2;
            n2 = n3;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            IntercambiarNum(ref num1, ref num2);
            txtNum1.Text = num1.ToString();
            txtNum2.Text = num2.ToString();
        }
    }
}
