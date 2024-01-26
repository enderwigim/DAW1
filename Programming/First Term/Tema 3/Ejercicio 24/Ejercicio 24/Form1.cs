using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int num, multiplicacion;
            string texto;

            num = int.Parse(txtNum.Text);
            texto = "Tabla del " + num + "\n";
            for (int i = 1; i <= 10; i++)
            {
                multiplicacion = num * i;
                texto += num + " * " + i + " = " + multiplicacion + "\n";
            }
            MessageBox.Show(texto);
        }
    }
}
