using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public abstract class Person : Entity
    {
        private string _dni, _name, _surname, _tlf;

        // Propiedades
        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public string Tlf
        {
            get => _tlf;
            set => _tlf = value;
        }
        public Person (string dni, string name, string surname, string tlf) : base()
        {
            _dni = dni;
            _name = name;
            _surname = surname;
            _tlf = tlf;
        }
    }
}
