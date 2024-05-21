using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializingTest
{
    [Serializable]
    public class Button
    {

        private string _name;
        private string _xPath;
        private string _type;
        private string _insert;

        [XmlElement("name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [XmlElement("xpath")]
        public string XPath
        { 
            get { return _xPath; } 
            set { _xPath = value; } 
        }
        [XmlElement("type")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        [XmlElement("insert")]
        public string Insert
        {
            get { return _insert; }
            set { _insert = value; }
        }

        private Button(string name, string xPath, string type, string insert)
        {
            _name = name;
            _xPath = xPath;
            _type = type;
            _insert = insert;
        }
        public Button() 
        {

        }
        public static Button Create(string name, string xPath, string type, string insert)        // Seba: Te falta el ? a la derecha de lo que devuelve para 
        {                                                                                          // indicar que puede devolver null, no hace nada pero ayuda a quien usa el codigo (vos)

            if (name == null || xPath == null || type == null)
            {
                return null;
            }
            return new Button(name, xPath, type, insert);
        }

    }
    
}
