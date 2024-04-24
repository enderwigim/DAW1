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
            
            // We obtain the absolute path of our xml, through geting the current proyect directory.
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\..\Data\webs.xml");
            string sFilePath = Path.GetFullPath(sFile);

            // We create our XML reader.
            XMLReader reader = new XMLReader(sFilePath);
            // Create Driver
            Driver chromeDriver = new Driver();

            for (int i = 1; i < reader.CountItems("pagina"); i++)
            {
                Console.WriteLine($"Entraré a: {reader.GetWebURL(i)}");
                chromeDriver.GoToUrl(reader.GetWebURL(i));
                List<Button> buttons = reader.GenerateButtonsToWeb(i);

                for (int j = 0; j < buttons.Count; j++)
                {
                    try
                    {
                        chromeDriver.HandleButton(buttons[j]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ha ocurrido un error con el boton de nombre: {buttons[j].Name}\nMensaje de error: {ex.Message}");
                        Console.WriteLine("Se cerrará el programa");
                        chromeDriver.DriveClose();
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine($"Terminé con: {reader.GetWebURL(i)}");
                Console.ReadKey();

            }
            chromeDriver.DriveClose();
            
            
        }
    }
}
