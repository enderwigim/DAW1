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

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            // Declaramos las variables
            int cantidadAlumnos;
            double porcenML, porcenL, porcenM, porcenP, peso, muyligero, ligero, medio, pesado, sumaPeso, pesoMedio;

            // Realizamos un try, para atrapar todos los posibles errores de formato. Porejemplo: Si el usuario no ingresa ningun numero.
            try { 
                //Creamos el InputBox y se damos el valor del mismo al peso.
                peso = int.Parse(Interaction.InputBox("Introduzca un peso", "Ejercicio 23"));

                // Le damos un valor inicial al resto de las variables.
                cantidadAlumnos = 0;
                muyligero = ligero = medio = pesado = porcenL = porcenM = porcenP = sumaPeso = 0;

                //Creamos un while que requiera que el peso inicial sea mayor a cero. Esto va a impedir que los futuros peso sean 0 tambien.
                while (peso > 0)
                {
                    // Durante el bucle buscamos a que categoria corresponde el peso.
                    if (peso <= 50)
                    {
                        // En caso de corresponderse, sumamos uno a la categoria. Para poder tener un registro de la misma.
                        muyligero++;
                    }
                    else if (peso > 50 && peso <= 65)
                    {
                        ligero++;
                    }
                    else if (peso > 65 && peso <= 80)
                    {
                        medio++;
                    }
                    else if (peso > 80)
                    {
                        pesado++;
                    }
                    // Luego sumamos el peso que tenemos en una variable suma.
                    sumaPeso += peso;
                    // Volvemos a llamar al InputBox y lo asociamos al peso.
                    try
                    {
                        peso = double.Parse(Interaction.InputBox("Introduzca un peso", "Ejercicio 23"));
                    }
                    catch (FormatException fEX)
                    {
                        MessageBox.Show("Porfavor, introduzca numeros en el InputBox");
                    }

                    // Sumamos 1 a cantidad de alumnos para llevar un registro del mismo.
                    cantidadAlumnos++;

                }

                
                // En caso de que el usuario ingrese, el peso de al menos un alumno, se realizaran las cuentas correspondientes.
                if (cantidadAlumnos > 0)
                {
                    // Calculamos el porcentaje de alumnos que corresponde a cada categoria.
                    porcenML = Math.Round((muyligero / (double)cantidadAlumnos) * 100);
                    porcenL = Math.Round((ligero / (double)cantidadAlumnos) * 100);
                    porcenM = Math.Round((medio / (double)cantidadAlumnos) * 100);
                    porcenP = Math.Round((pesado / (double)cantidadAlumnos) * 100);

                    // Calculamos el peso medio de la clase.
                    pesoMedio = sumaPeso / (double)cantidadAlumnos;

                    // Utilizamos el MessageBox
                    MessageBox.Show("Cantidad Alumnos: " + cantidadAlumnos + "\n" +
                        "De los cuales pesan: \n" +
                        "Menos de 50: " + muyligero + "\n" +
                        "Entre 50 y 65: " + ligero + "\n" +
                        "Entre 66 y 80: " + medio + "\n" +
                        "Mas de 80: " + pesado + "\n\n" +
                        "El porcentaje de alumnos con un peso menos de 50 es: " + porcenML + "\n" +
                        "El porcentaje de alumnos con un peso entre 50 y 65 es: " + porcenL + "\n" +
                        "El porcentaje de alumnos con un peso entre 66 y 80 es: " + porcenM + "\n" +
                        "El porcentaje de alumnos con mas de 80 es: " + porcenP + "\n" +
                        "\n El peso medio de la clase es: " + pesoMedio);
                }
                // En caso de que el usuario no ingrese el peso de ningún alumno. Directamente aparecerá el siguiente MessageBox.
                else
                {
                    MessageBox.Show("No se ha introducido ningún alumno.");
                }
            } catch (FormatException fEX) {
                MessageBox.Show("Porfavor, introduzca numeros en el InputBox");
            }


        }
    }
}
