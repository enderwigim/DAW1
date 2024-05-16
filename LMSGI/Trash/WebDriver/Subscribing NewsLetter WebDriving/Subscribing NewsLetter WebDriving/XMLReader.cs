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
        private XmlDocument _document = new XmlDocument();
        private XmlNodeList _listaPaginas;         
                                               

        public XMLReader(string filePath)         // Seba: Aqui el _listaPaginas por ej esta bien hecho, ya que no podes iniciarlo antes porque necesitas los datos por constructor.
        {                                            // Si el constructor creciese mas, tendrias que pasarlo a una función para mantenerlo lo mas pequeño posible, pero asi esta bien.
            _filePath = filePath;


            _document.Load(filePath);
            _listaPaginas = _document.SelectNodes("//pagina");
        }
        
        public string ReadXml()        // Seba: Si haces el chequeo tenes que poner el ? 
        {
            
            if (_document == null)
                return null;
            return _document.InnerXml;        // Seba: Aunque no sea necesario, converti el codigo en anti-bobos, no solo para vos, sino para quien lo usa. 
        }                                      // Si en algun momento del codigo el document pasa a ser null, esta función te explota la aplicación.
        /*
        public List<Button> GenerateButtonsToWeb(int paginaIndex)
        {
            XmlNodeList pagina = _listaPaginas.Item(paginaIndex).ChildNodes;        // Seba: No controlas que paginaIndex este dentro del rango aceptado. 
            List<Button> buttons = new List<Button>();
            // Seba: if ( fuera del count)
             // return buttons;
            
            for (int i = 1; i < pagina.Count; i++) 
            {
                if (pagina.Item(i).ChildNodes.Count > 1)            // Seba: if innecesario
                {      
                    string name, xpath, type, insert;     
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
        */
        public void CreateButton()
        {
            var serializer = new XmlSerializer(typeof(Pagina));
            using (StreamReader reader = new StreamReader(_filePath))
            {
                var page = (Pagina)serializer.Deserialize(reader);
                Console.WriteLine(page.Url);
                foreach (Button button in page.Buttons)
                {
                    Console.WriteLine(button.Name);
                }
                
            }
        }
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
    }
}
