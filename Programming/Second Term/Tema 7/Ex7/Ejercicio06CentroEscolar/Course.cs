using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    internal class Course
    {
        private string name;
        private string codigo;

        public Course()
        {
            name = "";
            codigo = "";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
