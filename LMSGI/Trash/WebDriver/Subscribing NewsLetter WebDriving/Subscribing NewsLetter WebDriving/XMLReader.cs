using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Subscribing_NewsLetter_WebDriving
{
    public class XMLReader
    {
        private string _filePath;
        private XmlDocument _document;


        public XMLReader(string filePath)
        {
            _filePath = filePath;
            _document = new XmlDocument();
            
            _document.Load(filePath);
        }

        public string ReadXml()
        {
            return _document.InnerXml;
        }
    }
}
