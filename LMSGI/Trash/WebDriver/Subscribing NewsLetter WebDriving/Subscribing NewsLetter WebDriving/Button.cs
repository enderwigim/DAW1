using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscribing_NewsLetter_WebDriving
{
    public class Button
    {
        private string _name;
        private string _xPath;
        private string _type;
        private string _insert;

        public string Name
        {
            get { return _name; }
        }
        public string XPath
        {
            get { return _xPath; }
        }
        public string Type
        {
            get { return _type; }
        }
        public string Insert
        {
            get { return _insert; }

        }

        private Button(string name, string xPath, string type, string insert)
        {
            _name = name;
            _xPath = xPath;
            _type = type;
            _insert = insert;
        }
        public static Button Create(string name, string xPath, string type, string insert)
        {
            if (name == null || xPath == null || type == null)
            {
                return null;
            }
            return new Button(name, xPath, type, insert);
        }
        
    }
    
}
