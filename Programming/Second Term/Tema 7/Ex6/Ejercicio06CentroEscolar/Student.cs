using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class Student
    {

        private string name;
        private string dni;
        private string phoneNumber;
        private string courseCode;
        private List<double> grades;


        public string Name
        {
            get { return name; }
            set { name = CustomFunctions.FirstLetterToCapital(value); }
        }
        public string Dni
        {
            get { return dni; }
            set
            {
                if (value.Length == 9 || value.Length == 10)
                { dni = value.ToUpper(); }
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length >= 9 && value.Length <= 13)
                    phoneNumber = value;
            }
        }
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value.ToUpper(); }
        }


        public Student()
        {
            Name = "";
            Dni = "";
            PhoneNumber = "";
            CourseCode = "";
            grades = new List<double>();
        }
        // Add and Delete grades.
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void DeleteGrades()
        {
            grades.Clear();
        }
        // Calculation methods.
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
        // Show methods.
        public string ShowGrades()
        {
            string gradeText = "This student doesn't have any grades";
            if (grades.Count != 0)
            {
                gradeText = Name + " grades are: \n";
                for (int i = 0; i < grades.Count; i++)
                {
                    gradeText += grades[i] + ", ";
                }

            }
            return gradeText;
        }

        public string ShowStudent()
        {
            string studentText = $"{Name}, {Dni}, {PhoneNumber}, {CourseCode} \n {ShowGrades()} \n";
            return studentText;
        }

    }
}

   