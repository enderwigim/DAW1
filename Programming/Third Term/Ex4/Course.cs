using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Course : Entity
    {
        private string _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Course (string id, string name) : base()
        {
            _id = id;
            _name = name;
        }
        public static Course CreateCourse(string id, string name)
        {
            if (!string.IsNullOrEmpty(name) && !(id.Length < 3) && !(id.Length > 4))
            {
                return new Course(id.ToUpper(), name);
            }
            return null;
        }
    }
}
