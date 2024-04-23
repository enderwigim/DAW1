using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Models
{
    public class Teacher
    {
        // Miembros
        private string _dni, _name, _surname, _tlf, _mail;

        // Propiedades
        public string dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        // Otra posible forma de hacer la propiedad
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
        public string eMail
        {
            get => _mail;
            set => _mail = value;
        }

        
        private Teacher(string dni, string name, string surname, string Tlf, string eMail)
        {
            _dni = dni;
            _name = name;
            _surname = surname;
            _tlf = Tlf;
            _mail = eMail;
        }
        public static Teacher CreateTeacher(string dni, string name, string surname, string Tlf, string eMail)
        {
            // This static function lets us create the Teacher just with our rules. If the data is not correct, the teacher won't be created and
            // null will be returned.
            if ((dni.Length < 9 && dni.Length > 10) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || Tlf.Length < 9 || !eMail.Contains("@"))
            {
                return null;
            }
            return new Teacher(dni, name, surname, Tlf, eMail);
        }
    }
}
