using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaramos las variables.
            int num1, num2, resultado;
            string txt;

            // Le damos valor a esas variables.
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            resultado = 0;
            txt = num1 + " * " + num2 + " = ";

            // Creamos un caso en el que num1 sea menor a 0
            if (num1 < 0)
            {
                // Simplemente generamos un loop alrededor de num1
                for (int i = -1; i >= num1; i--)
                {
                    // A resultado siempre se le restará el numero 2.
                    resultado -= num2;
                    txt += "- (" + num2 + ") ";
                }

            }
            
            else if (num1 > 0)
            {
                /* Generamos un loop en base a i. Que empiece en 1 y termine cuando se supere num1. Esto es para que haga el loop una cantidad
                igual al valor de num1 */
                for (int i = 1; i <= num1; i++)
                {
                    /* sumamos al resuldo el num2. al hacer esto repetidamente estamos consiguiendo num2 +
                    num2 + ..., una num2 cantidad de veces. */
                    resultado += num2;
                    txt += "+ (" + num2 + ") ";
                }
            }
            txt += "= " + resultado;
            
            MessageBox.Show(txt);
        }
    }
}
