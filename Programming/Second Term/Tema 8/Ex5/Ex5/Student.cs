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

        public void AddGrades(int newGrade)
        {
            grades.Add(newGrade);
        }
        public void DeleteGrades()
        {
            grades.Clear();
        }
        public double CalcAVG()
        {
            double avg = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                avg += grades[i];
            }
            avg /= grades.Count;
            return avg;
        }
        public bool IsAVGUpperThan5()
        {
            bool isUpper = false;
            double avg = CalcAVG();
            if (avg >= 5)
            {
                isUpper = true;
            }
            return isUpper;
        }
        public override string ShowData()
        {
            return $"\nNombre: {Name}" +
                   $"\nDNI: {DNI}" +
                   $"\nTelefono: {PhoneNumber}" +
                   $"\nGrupo: {courseCode}" +
                   $"\nNotas: {ShowGrades()}";
        }
    }
}
