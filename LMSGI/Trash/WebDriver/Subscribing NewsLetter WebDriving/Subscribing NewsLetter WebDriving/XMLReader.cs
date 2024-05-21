using System;
using System.IO;
using System.Xml.Serialization;


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

    }
}
