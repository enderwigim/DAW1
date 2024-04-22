using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        private IWebDriver _chromeDriver;


        public Driver()
        {
            // Create an instance for Chrome.
            _chromeDriver = new ChromeDriver();
            _chromeDriver.Manage().Window.Maximize();
        }

        public void GoToUrl(string URL)
        {
            _chromeDriver.Navigate().GoToUrl(URL);
            Thread.Sleep(3000);
        }
        public void HandleButton(Button button)
        {
            var buttonDriver = _chromeDriver.FindElement(By.XPath(button.XPath));
            if (button.Type.ToLower() == "click")
            {
                buttonDriver.Click();
            }
            else if (button.Type.ToLower() == "text")
            {
                buttonDriver.SendKeys(button.Insert);
            }
            else if (button.Type.ToLower() == "select")
            {
                SelectElement selectButton = new SelectElement(buttonDriver);
                selectButton.SelectByIndex(int.Parse(button.Insert));
            }
            Thread.Sleep(3000);
        }
        public void DriveClose()
        {
            _chromeDriver.Close();
        }


    }
}
