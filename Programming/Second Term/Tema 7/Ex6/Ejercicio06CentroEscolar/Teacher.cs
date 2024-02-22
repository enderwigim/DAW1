using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class Teacher
    {
        private string name;
        private string dni;
        private string phoneNumber;
        private string courseCode;
        private List<string> subjects;



        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Dni
        {
            get { return dni; }
            set
            {
                if (value.Length >= 9 && value.Length <= 10)
                { dni = value.ToUpper(); }
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length >= 9 && value.Length <= 13)
                {
                    phoneNumber = value;
                };
            }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { 
                if (value.Length == 3)
                {
                    courseCode = value.ToUpper();
                }
            }
        }



        public string ShowTeacher()
        {
            return $"{Name}, {Dni}, {phoneNumber}, {courseCode}";
        }
    }
}
