using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numeroIntroducido;
            string multiplos;

            numeroIntroducido = int.Parse(txtNumero.Text);
            multiplos = "Los valores son: ";

            for (int i = 1; i <= numeroIntroducido; i++)
            {
                if (i % 3 == 0)
                {
                    multiplos += i + ", ";
                }
            }
            MessageBox.Show(multiplos);

        }
    }
}
