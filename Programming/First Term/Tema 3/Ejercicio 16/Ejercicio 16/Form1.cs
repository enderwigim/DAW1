using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaramos las variables
            int num, suma;

            /* Utilizaremos un try para tomar todos los FormatException errors. Por ejemplo: Si el usuario pone 1,1. Directamente le
             avisara del error. */
            try
            {
                num = int.Parse(Interaction.InputBox("Introduzca un número", "Ejercicio 16"));
                suma = 0;
                while (num <= 9 && num >= 0)
                {
                    suma += num;
                    // Nos enfrentamos a la misma situación anterior. Por eso ut
                    try
                    {
                        
                        num = int.Parse(Interaction.InputBox("Introduzca un número", "Ejercicio 16"));
                    }
                    catch (FormatException FEx)
                    {
                        num = 0;
                        MessageBox.Show("Porfavor, solo introduzca numeros enteros.\n" + FEx.Message);
                    }
                }
                if (suma == 0)
                {
                    MessageBox.Show("No hay resultado en la suma. Los numeros ingresados equivalen a 0");
                }
                else
                {
                    MessageBox.Show("El resultado de la suma es: " + suma);
                }
                
            }
            catch (FormatException FEx)
            {
                MessageBox.Show("Porfavor, solo introduzca numeros enteros.\n" +  FEx.Message);
            }
        }
    }
}
