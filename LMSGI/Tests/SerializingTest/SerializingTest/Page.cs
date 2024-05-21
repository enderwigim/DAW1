using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializingTest
{
    [Serializable]
    [XmlRoot("page")]
    public class Page
    {
        // It should be use on the attribute but in the property
        // [XmlElement("URL")] !! Won't happen anything
        private string _url;

        [XmlElement("URL")]
        public string Url
        {
            get { return _url;  }
            set { _url = value; } // If we don't have a set, it wont work.
        }

        // Now we will add the Buttons. We will check if it works with a class in another file.
        private List<Button> _buttons;

        [XmlArray("buttons")]
        [XmlArrayItem("button")]
        public List<Button> Buttons
        {
            get { return _buttons; }
            set { _buttons = value; }
        }

    }
   
}
