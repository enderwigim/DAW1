using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Empleado
    {
            
        // Declaración de miembros de la clase.
        private string nombre;
        private int edad;
        // Aquí almacenaremos ventas realizadas por el empleado.
        // Utilizamos el tipo List.
        private List<double> mVentas;

        // Propiedades de la clase
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set
            {
                // No permitimos edades negativas o superiores a 100.
                if (value >= 0 && value <= 100)
                    edad = value;
            }
        }

        // Constructor
        public Empleado()
        {
            nombre = "";
            edad = 0;
            // Creamos la lista de ventas.
            mVentas = new List<double>();
        }

        // Métodos de la clase
        // Cumpleaños del empleado
        public void CumpleAnyos()
        {
            edad = edad + 1;
        }
        // Añadir una venta al empleado.
        public void AnyadirVenta(double venta)
        {
            if (venta > 0)
                mVentas.Add(venta);
        }

        // Función que devuelve un texto con la lista de ventas
        // Es privada ya que solo se utilizará dentro de la clase 
        // (en mostraDatos)
        private string MostrarVentas()
        {
            string texto;
            int i;
            if (mVentas.Count > 0)
            {
                texto = "Las ventas son : ";
                for (i = 0; i < mVentas.Count; i++)
                    texto = texto + mVentas[i] + ", ";
                texto = texto + "\n";
            }
            else
                texto = "Empleado sin ventas.\n";
            return texto;
        }

        // Función que devuelve un texto con los datos del empleado.
        // Es pública ya que se llama desde fuera de la clase
        public string MostrarDatos()
        {
            string texto;
            texto = "Datos del empleado:\n";
            texto = texto + "Nombre: " + nombre + "\n";
            texto = texto + "Edad: " + edad + "\n";
            texto = texto + MostrarVentas();
            return texto;
        }
    }
    
    

}


