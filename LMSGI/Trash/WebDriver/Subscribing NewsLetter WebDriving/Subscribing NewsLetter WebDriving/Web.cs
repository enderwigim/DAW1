using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Subscribing_NewsLetter_WebDriving
{
    [XmlRoot("webs")]
    public class Web
    {

        [XmlArray("pagina")]
        private List<Pagina> _pages;

        public List<Pagina> Pages => _pages;
    }

 
}
