using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Course : Entity
    {
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Course (int id, string name) : base()
        {
            _id = id;
            _name = name;
        }
        public static Course CreateCourse(int id, string name)
        {
            if (id > 0 && !(name.Length < 3) && !(name.Length > 4))
            {
                return new Course(id, name);
            }
            return null;
        }
    }
}
