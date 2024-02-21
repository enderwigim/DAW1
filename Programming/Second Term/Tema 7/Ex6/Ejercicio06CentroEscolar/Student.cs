using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class Student
    {
        // TODO nombre, dni, teléfono, lista de notas (simplemente una lista de valores double) y código del curso al cuál pertenecen.
        private string name;
        private string dni;
        private string phoneNumber;
        private string courseCode;
        private List<double> grades;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { 
                    if (value.Length == 9 || value.Length == 10) 
                    { dni = value.ToUpper();} 
                }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { if (value.Length >= 9 && value.Length <= 13)
                    phoneNumber = value;
                }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { if (value.Length == 3)
                    { courseCode = value.ToUpper();} 
                }
        }

        public Student()
        {
            Name = "";
            Dni = "";
            PhoneNumber = "";
            CourseCode = "";
            grades = new List<double>();
        }

        public string ShowGrades()
        {
            string gradeText = Name + "grades are: \n";
            for (int i = 0; i <  grades.Count; i++) 
            {
                gradeText += grades[i] + ", ";
            }
            return gradeText;
        }

        public string ShowStudent()
        {
            string studentText = $"{Name}, {Dni}, {PhoneNumber}, {CourseCode} \n {ShowGrades()}";
            return studentText;
        }

    }
}
