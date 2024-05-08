using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ex4
{
    public class Student : Person
    {
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public Student (string dni, string name, string surname, string  tlf ,string address) : base(dni, name, surname, tlf)
        {
            _address = address;
        }
        public static Student CreateStudent(string dni, string name, string surname, string Tlf, string address)
        {
            // This static function lets us create the Student just with our rules. If the data is not correct, the teacher won't be created and
            // null will be returned.
            if ((dni.Length < 9 && dni.Length > 10) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || Tlf.Length < 9 || string.IsNullOrEmpty(address))
            {
                return null;
            }
            return new Student(dni, name, surname, Tlf, address);
        }
    }
}
