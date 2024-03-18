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
        }
    }
}
