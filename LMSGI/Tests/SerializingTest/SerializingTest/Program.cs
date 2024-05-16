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
            var serializer = new XmlSerializer(typeof(Page));
            using (StreamReader reader = new StreamReader("webs.xml"))
            {
                var page = (Page)serializer.Deserialize(reader);
                Console.WriteLine(page.Url);
                
                foreach (Button button in page.Buttons)
                {
                    Console.WriteLine($"Name: {button.Name}, Xpath: {button.Type}");
                }
                Console.ReadLine();
            }
        }
    }
}
