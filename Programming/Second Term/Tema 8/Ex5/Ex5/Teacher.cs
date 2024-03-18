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
            CourseCode = courseCode;
            Email = email;
            subjects = new List<string>();
        }

    }
}
