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
        private XmlNodeList _listaPaginas;


        public XMLReader(string filePath)
        {
            _filePath = filePath;
            _document = new XmlDocument();

            _document.Load(filePath);
            _listaPaginas = _document.SelectNodes("//pagina");
        }
        public string ReadXml()
        {
            return _document.InnerXml;
        }
        public List<Button> GenerateButtonsToWeb(int paginaIndex)
        {
            XmlNodeList pagina = _listaPaginas.Item(paginaIndex).ChildNodes;
            List<Button> buttons = new List<Button>();

            
            for (int i = 1; i < pagina.Count; i++)
            {
                if (pagina.Item(i).ChildNodes.Count > 1)
                {
                    string name, xpath, type, insert;
                    name = xpath = type = insert = null;
                    for (int j = 0; j < pagina.Item(i).ChildNodes.Count; j++)
                    {
                        string elementName = pagina.Item(i).ChildNodes.Item(j).Name;
                        string elementText = pagina.Item(i).ChildNodes.Item(j).InnerXml;
                        if (elementName == "name")
                        {
                            name = elementText;
                        }
                        else if (elementName == "xpath")
                        {
                            xpath = elementText;
                        }
                        else if (elementName == "type")
                        {
                            type = elementText;
                        }
                        else if (elementName == "insert")
                        {
                            insert = elementText;
                        }
                    }
                    Button newButton = Button.Create(name, xpath, type, insert);
                    if (newButton != null)
                    {
                        buttons.Add(newButton);
                    }
                }
                
            }
            return buttons;
        }
        public void GetWebData()
        {

        }
        public int CountItems(string tag)
        {
            // We will get the nodes we are interested about as an array with the names, and will
            // return a dictionary with every part.
            XmlNodeList pagina = _document.SelectNodes("//" + tag);
            return pagina.Count;


        }
    }
}
