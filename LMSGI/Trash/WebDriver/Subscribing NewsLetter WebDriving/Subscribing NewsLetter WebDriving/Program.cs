using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.IO;

namespace Subscribing_NewsLetter_WebDriving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Manager manager = new Manager();
            manager.ManageEveryPage();
            
            
        }
    }
}
