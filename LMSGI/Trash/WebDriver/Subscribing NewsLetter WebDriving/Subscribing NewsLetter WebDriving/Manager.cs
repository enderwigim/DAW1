using System;
using System.IO;

namespace Subscribing_NewsLetter_WebDriving
{
    public class Manager
    {
        // Will have the directory of our file.
        private string _sFilePath;
        // XMLReader
        private XMLReader reader;

        // Driver
        private Driver driver = new Driver();
        private PageList pages;

        public Manager()
        {
            // We set the directory in which we will work
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\Data\webs.xml");
            _sFilePath = Path.GetFullPath(sFile);

            // Create reader. Thought we are going to use it just for this. It maybe useful later.
            reader = new XMLReader(_sFilePath);
            // Create pages.
            pages = reader.DeserializeXMLIntoPageList();
        }
        public void ManagePage(Page page)
        {
            driver.GoToUrl(page.Url);
            for (int i = 0; i < page.GetAmmountOfButtons(); i++)
            {
                driver.HandleButton(page.Buttons[i]);
            }
        }
        public void ManageEveryPage()
        {
            // We will loop through every page and we will manage to surf it with the direction gotten from the xml.
            for (int i = 0; i < pages.GetPageCount(); i++)
            {
                ManagePage(pages.GetPage(i));
            }
            driver.DriveClose();
            
        }
        
    }
}
