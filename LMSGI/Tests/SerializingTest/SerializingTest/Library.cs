using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializingTest
{
    [XmlRoot("Library")]
    public class Library
    {
        [XmlArray("Books")]
        [XmlArrayItem("Book")]
        public List<Book> Books { get; set; }
    }
    public class Book
    {
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("Author")]
        public string Author { get; set; }
    }
}
