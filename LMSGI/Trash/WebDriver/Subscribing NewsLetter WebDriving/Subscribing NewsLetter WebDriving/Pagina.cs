using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Subscribing_NewsLetter_WebDriving
{
    [XmlRoot("pagina")]
    public class Pagina
    {
        [XmlElement("URL")]
        private string _url;
        [XmlArray("buttons")]
        [XmlArrayItem("button")]
        private List<Button> buttons;

        public string Url => _url;
        public List<Button> Buttons => buttons;

        public Pagina()
        {

        }
    }
}
