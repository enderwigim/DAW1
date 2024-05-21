using System.Collections.Generic;
using System.Xml.Serialization;

namespace Subscribing_NewsLetter_WebDriving
{
    [XmlRoot("page")]
    public class Page
    {
        
        private string _url;

        private List<Button> buttons;

        
        [XmlElement("URL")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        [XmlArray("buttons")]
        [XmlArrayItem("button")]
        public List<Button> Buttons
        {
            get { return buttons; }
            set { buttons = value; }
        }

        public int GetAmmountOfButtons()
        {
            return buttons.Count;
        }

    }
}
