using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         int calcularDinero(ref double euros, ref string total, int precioDinero, bool esMoneda)
        {
            int dinero = 0;

            if (euros >= precioDinero)
            {
                dinero = (int)euros / precioDinero;
                if (! esMoneda)
                {
                    total += dinero + " billetes de " + precioDinero + "\n";
                }
                else
                {
                    total += dinero + " monedas de " + precioDinero + " \n";
                }
                
                euros = euros % precioDinero;

            }
            return dinero;
        }
       
        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Declaramos las variables.
            double euros;
            string total;
            bool esMoneda;

            
            euros = double.Parse(txtEuros.Text);
            total = "";

            esMoneda = false;

            calcularDinero(ref euros, ref total, 500, esMoneda);
            calcularDinero(ref euros, ref total, 200, esMoneda);
            calcularDinero(ref euros, ref total, 100, esMoneda);
            calcularDinero(ref euros, ref total, 50, esMoneda);
            calcularDinero(ref euros, ref total, 20, esMoneda);
            calcularDinero(ref euros, ref total, 10, esMoneda);
            calcularDinero(ref euros, ref total, 5, esMoneda);

            esMoneda = true;

            calcularDinero(ref euros, ref total, 2, esMoneda);
            calcularDinero(ref euros, ref total, 1, esMoneda);
            euros = Math.Round(euros, 2) * 100;
            calcularDinero(ref euros, ref total, 50, esMoneda);
            calcularDinero(ref euros, ref total, 20, esMoneda);
            calcularDinero(ref euros, ref total, 10, esMoneda);
            calcularDinero(ref euros, ref total, 5, esMoneda);
            calcularDinero(ref euros, ref total, 2, esMoneda);
            calcularDinero(ref euros, ref total, 1, esMoneda);
            
            lblEuros.Text = total;
        }
    }
}
