using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Teacher : Person
    {
        // Miembros
        private string _mail;

        
        
        public string eMail
        {
            get => _mail;
            set => _mail = value;
        }


        private Teacher(string dni, string name, string surname, string tlf ,string eMail) : base(dni, name, surname, tlf)
        {
            _mail = eMail;
        }
        public static Teacher CreateTeacher(string dni, string name, string surname, string Tlf, string eMail)
        {
            // This static function lets us create the Teacher just with our rules. If the data is not correct, the teacher won't be created and
            // null will be returned.
            if (dni.Length != 9 ||
                 string.IsNullOrEmpty(name) || 
                 string.IsNullOrEmpty(surname) || 
                 Tlf.Length < 9 || 
                 !eMail.Contains("@"))
            {
                return null;
            }
            return new Teacher(dni, name, surname, Tlf, eMail);
        }
    }
}
