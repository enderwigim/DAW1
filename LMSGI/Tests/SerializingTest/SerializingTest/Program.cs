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
            var serializer = new XmlSerializer(typeof(PageList));
            using (StreamReader reader = new StreamReader("webs.xml"))
            {
                var pageList = (PageList)serializer.Deserialize(reader);
                Console.WriteLine(pageList);
                
                
                Console.ReadLine();
            }
        }
    }
}
