using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Subscribing_NewsLetter_WebDriving
{
    public class Button
    {
        
        private string _name;
        private string _xPath;
        private string _type;
        private string _insert;

        [XmlElement("name")]
        public string Name => _name;
        [XmlElement("xpath")]
        public string XPath => _xPath;
        [XmlElement("type")]
        public string Type => _type;
        [XmlElement("insert")]
        public string Insert => _insert;

        public Button() { }
        private Button(string name, string xPath, string type, string insert)
        {
            _name = name;
            _xPath = xPath;
            _type = type;
            _insert = insert;
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
