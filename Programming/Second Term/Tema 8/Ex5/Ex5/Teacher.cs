using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex5
{
    public class Teacher: Person
    {
        private List<string> subjects;
        private string courseCode;
        private string email;

        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Teacher(string courseCode, string email, string name, string dni, string phoneNumber) : base(name, dni, phoneNumber)
        {
            CourseCode = courseCode.ToUpper();
            Email = email;
            subjects = new List<string>();
        }
        public Teacher(string email, string name, string dni, string phoneNumber) : base(name, dni, phoneNumber)
        {
            Email = email;
            subjects = new List<string>();
            CourseCode = null;
        }

        public bool AddSubject(string newSubject)
        {
            bool subjectAdded = false;
            if (!subjects.Contains(newSubject.ToLower()))
            {
                subjects.Add(newSubject.ToLower());
                subjectAdded = true;
            }
            return subjectAdded;
        }
        public void RemoveSubjects()
        {
            subjects.Clear();
        }

        public string ShowSubjects()
        {
            string textSubjects = "This teacher doesn't have subjects yet";
            if (subjects.Count > 0) 
            {
                textSubjects = "";
                for (int i = 0; i < subjects.Count; i++)
                {
                    textSubjects += subjects[i] + ",";
                }
            }
            return textSubjects;
        }
        public string ShowIfTutor()
        {
            string text = "This teacher is not a tutor";
            if (courseCode != null)
            {
                text = $"This teacher is the tutor of: {CourseCode}";
            }
            return text;
        }

        public override string ShowData()
        {
            return $"\nNombre: {Name}" +
                   $"\nDNI: {DNI}" +
                   $"\nTelefono: {PhoneNumber}" +
                   $"\nEmail: {Email}" +
                   $"\nMaterias: {ShowSubjects()}" +
                   $"\n{ShowIfTutor()}";
                   
        }


    }
}
