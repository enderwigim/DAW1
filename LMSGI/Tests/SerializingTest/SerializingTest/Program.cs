using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializingTest
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Create pageList
            PageList pageList = new PageList();
            //Create page
            Page pageToAdd = new Page();
            pageToAdd.Url = "https://discord.com/";
            pageToAdd.Buttons = new List<Button>();

            //Create Button
            Button button = new Button
            {
                Name = "login",
                XPath = "/html/body/div[1]/div[1]/div/div[1]/div[1]/a",
                Type = "click"
            };

            // Add Button into Page
            pageToAdd.Buttons.Add(button);

            // Add pageToAdd into pageList
            pageList.Pages.Add(pageToAdd);

            XmlSerializer serializer = new XmlSerializer(typeof(PageList));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, pageList);
                string xmlString = writer.ToString();
                Console.WriteLine(xmlString);
            }
        }
        public PageList DeserializeXMLInToPageList()
        {
            var serializer = new XmlSerializer(typeof(PageList));
            using (StreamReader reader = new StreamReader("webs.xml"))
            {
                var pageList = (PageList)serializer.Deserialize(reader);
                return pageList;
            }
        }
    }
}
