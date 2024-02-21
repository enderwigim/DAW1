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
        private string code;

        public Course()
        {
            nombre = "";
            code = "";
        }

        public string Name
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Code
        {
            get { return code; }
            set { code = value.ToUpper(); }
        }

        override
        public string ToString()
        {
            string text = $"Course Name: {Name} \n Course Code: {Code} \n";
            return text;
        }
    }
}
