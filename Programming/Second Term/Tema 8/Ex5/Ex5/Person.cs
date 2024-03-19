using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public abstract class Person
    {
        private string _name;
        private string _DNI;
        private string _phoneNumber;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string DNI
        {
            get { return _DNI; }
            set { _DNI = value.ToUpper(); }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public Person(string name, string dni, string phoneNumber)
        {
            Name = name;
            DNI = dni;
            PhoneNumber = phoneNumber;
        }
        public abstract string ShowData();
    }
}
