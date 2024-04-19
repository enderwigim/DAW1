using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Subscribing_NewsLetter_WebDriving
{
    public class XMLReader
    {
        private string _filePath;
        private XmlDocument _document;
        private XPathNavigator _nav;


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
        public void GetEveryElement()
        {
            /*
            var buttons = _document.GetElementsByTagName;
            _document.Re()


            for (int i = 0; i < _document.GetElementsByTagName("button").Count; i++)
            {
                Console.WriteLine();
            }
            */
        }
    }
}
