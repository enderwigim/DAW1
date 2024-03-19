using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class Student: Person
    {
        private string courseCode;
        private List<double> grades;
        
        public string CourseCode
        {
            get { return courseCode; } 
            set { courseCode = value; }
        }
        public Student(string courseCode, string name, string dni, string phoneNumber) : base(name, dni, phoneNumber)
        {
            CourseCode = courseCode;
            grades = new List<double>();
        }

        public override string ShowData()
        {
            return $"\nNombre: {Name}" +
                   $"\nDNI: {DNI}" +
                   $"\nTelefono: {PhoneNumber}" +
                   $"\nTelefono: {PhoneNumber}" +
                   $"\nNotas: {ShowGrades()}";
        }
        public string ShowGrades()
        {
            string textGrades = "";
            if (grades.Count > 0)
            {
                for (int i = 0; i < grades.Count; i++)
                {
                    textGrades += grades[i] + ", ";
                }
            }
            else
            {
                textGrades = "There's no grades yet.";
            }
            return textGrades;
        }
    }
}
