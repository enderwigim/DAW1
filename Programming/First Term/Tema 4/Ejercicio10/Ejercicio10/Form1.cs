using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int elevar(int base1, int exponente)
        {
            int res = 1;
            for(int i = 1; i <= exponente; i++) 
            {
                res *= exponente;
            }
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, resultadoElev2, resultadoElev5, resultadoElev7;

            num1 = int.Parse(txtNum1.Text);

            resultadoElev2 = elevar(num1, 2);
            resultadoElev5 = elevar(num1, 5);
            resultadoElev7 = elevar(num1, 7);

            MessageBox.Show("El resultado de elevar " + num1 + " a: \n 2: " + resultadoElev2 + " \n 5: " + resultadoElev5 +
                " \n 7: " + resultadoElev7);
        }
        
    }
}
