using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    internal class Course
    {
        private string nombre;
        private string pito;

        public Course()
        {
            nombre = "";
            pito = "";
        }

        public string Name
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Code
        {
            get { return pito; }
            set { pito = value; }
        }

        override
        public string ToString()
        {
            string text = $"Course Name: {Name} \n Course Code: {Code}";
            return text;
        }
    }
}
