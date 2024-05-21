using System.Collections.Generic;
using System.Xml.Serialization;

namespace Subscribing_NewsLetter_WebDriving
{
    [XmlRoot("pages")]
    public class PageList
    {

        private List<Page> _pages;

        [XmlElement("page")]
        public List<Page> Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }
        public PageList()
        {
            _pages = new List<Page>();
        }
        public int GetPageCount()
        {
            return _pages.Count;
        }
        public Page GetPage(int index)
        {
            return _pages[index];
        }
    }

 
}
