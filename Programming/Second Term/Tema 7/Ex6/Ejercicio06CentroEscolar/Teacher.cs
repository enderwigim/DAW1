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
            set { courseCode = value.ToUpper();}
        }

        public Teacher(string name, string dni, string phoneNumber, string courseCode)
        {
            Name = name;
            Dni = dni;
            PhoneNumber = phoneNumber;
            CourseCode = courseCode;
            subjects = new List<string>();
        }

        public Teacher(string name, string dni, string phoneNumber)
        {
            Name = name;
            Dni = dni;
            PhoneNumber = phoneNumber;
            CourseCode = "NULL";
            subjects = new List<string>();
        }

        public bool RemoveJustOneSubject(string subjectName)
        {
            bool wasDeleted = false;
            subjectName = CustomFunctions.FirstLetterToCapital(subjectName);
            int subjectIndex = subjects.IndexOf(subjectName);
            if (subjectIndex != -1)
            {
                subjects.RemoveAt(subjectIndex);
                wasDeleted = true;
            }
            return wasDeleted;
        }

        public bool EmptySubjects()
        {
            bool IsEmpty = true;
            if (subjects.Count > 0)
            {
                IsEmpty = false;
            }
            return IsEmpty;
        }
        public void AddSubject(string subjectName)
        {
            subjects.Add(subjectName);
        }
        public bool RemoveSubjects()
        {
            bool removed = false;
            if (!EmptySubjects())
            { 
                subjects.Clear();
                removed = true;
            }
            return removed;
        }

        public bool HasSubject(string subjectToHave)
        {
            bool HasSubject = false;
            if (subjects.Contains(subjectToHave))
            {
                HasSubject = true;
            }
            return HasSubject;
        }
        public string ShowSubjects()
        {
            string everySubject = "There's no subjects yet";
            if (subjects.Count > 0)
            {
                everySubject = "This teacher teachs the following subjects: \n";
                for (int i = 0; i < subjects.Count; i++)
                {
                    everySubject += subjects[i] + ", ";
                }

            }
            return everySubject;
        }
        public string ShowTeacher()
        {
            if (CourseCode == "NULL")
            {
                return $"{Name}, {Dni}\n{phoneNumber}\n {ShowSubjects()}\n";
            } else
            {
                return $"{Name}, {Dni}\n{phoneNumber}\n{courseCode}'s tutor\n{ShowSubjects()}\n";
            }
           
        }
    }
}
