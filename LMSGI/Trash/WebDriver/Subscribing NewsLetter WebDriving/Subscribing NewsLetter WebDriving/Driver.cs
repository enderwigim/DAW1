using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;                    // Seba: Limpia tu codigo, si no usas ninguno de estos using borralos, si usas alguno conserva solamente el que usas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Subscribing_NewsLetter_WebDriving
{
    public class Driver
    {
        private IWebDriver _chromeDriver = new ChromeDriver();       
                                                    
                                                   
        public Driver()
        {
            // Let's just maximize the window.
            _chromeDriver.Manage().Window.Maximize();
        }

        public void GoToUrl(string URL)
        {
            _chromeDriver.Navigate().GoToUrl(URL);
            Thread.Sleep(3000);
        }
        public void HandleButton(Button button)         // Seba:  Si es mas de una opcion devuelve un int en lo que fallo (un 0 o un 1 si se completo correctamente, si es una sola un bool)
        {
            try
            {
                var buttonDriver = _chromeDriver.FindElement(By.XPath(button.XPath));    
                if (button.Type.ToLower() == "click")                                    
                    buttonDriver.Click();
                else if (button.Type.ToLower() == "text")
                    buttonDriver.SendKeys(button.Insert);
                else if (button.Type.ToLower() == "select")
                {
                    SelectElement selectButton = new SelectElement(buttonDriver);
                    selectButton.SelectByIndex(int.Parse(button.Insert));
                }
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("The following error happened. We will follow to the next page.");
                Console.Error.WriteLine(ex.ToString());
                return;        
            }
        }
        public void DriveClose()
        {
            _chromeDriver.Close();            
        }                                        


    }
}
