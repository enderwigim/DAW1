using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Subscribing_NewsLetter_WebDriving
{
    public class XMLReader
    {
        private string _filePath;
        public XmlSerializer serializer;
                                               

        public XMLReader(string filePath)         
        {   
            // filePath can't be null.
            if (filePath == null)
            {
                return;
            }
            _filePath = filePath;

        }                              
        public PageList DeserializeXMLIntoPageList()
        {
            // We deserialize our XML into an object.
            var serializer = new XmlSerializer(typeof(PageList));
            try
            {
                // It will work if the data in the XML is correct.
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    var pageList = (PageList)serializer.Deserialize(reader);
                    return pageList;
                
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred while retrieving data: ", ex.Message);
                return null;
            }
        }
        /*
        public string GetWebURL(int paginaIndex)
        {
            XmlNodeList pagina = _listaPaginas.Item(paginaIndex).ChildNodes;
            return pagina.Item(0).InnerText;
        }
        public int CountItems(string tag)
        {
            XmlNodeList xml = _document.SelectNodes("//" + tag);
            return xml.Count;

        }
        */
    }
}
