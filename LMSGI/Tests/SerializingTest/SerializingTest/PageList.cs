using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializingTest
{
    [XmlRoot("pages")]
    public class PageList
    {
        private List<Page> pages;
        [XmlElement("page")]
        public List<Page> Pages { get; set; }
        public PageList() {
            pages = new List<Page>();
        }
    }
}
