using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace Subscribing_NewsLetter_WebDriving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Instance for Chrome
            IWebDriver chromeDriver = new EdgeDriver();
            chromeDriver.Manage().Window.Maximize();

            chromeDriver.Navigate().GoToUrl("https://wizzair.com/en-gb/newsletter");
            Thread.Sleep(20000);
            bool cookiesPresent = (chromeDriver.FindElements(By.XPath("//*[@id=\"onetrust-accept-btn-handler\"]")).Count() > 0);
            if (cookiesPresent)
            {
                chromeDriver.FindElement(By.XPath("//*[@id=\"onetrust-accept-btn-handler\"]")).Click();
            }
            Thread.Sleep(5000);

            IWebElement name = chromeDriver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/form/fieldset/div[1]/div[1]/div/div/label/input"));
            name.SendKeys("Sergito");

            IWebElement surname = chromeDriver.FindElement(By.XPath("*[@id='app']/div/main/div/form/fieldset/div[1]/div[2]/div/div/label/input"));
            surname.SendKeys("Voixito");

            IWebElement gender = chromeDriver.FindElement(By.XPath("*//*[@id=\"app\"]/div/main/div/form/fieldset/div[1]/div[3]/div/div/label/select"));
            SelectElement selectgender = new SelectElement(gender);
            selectgender.SelectByIndex(1);

            IWebElement email = chromeDriver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/form/fieldset/div[2]/div/label/input"));
            email.SendKeys("email");

            IWebElement acceptButton = chromeDriver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/form/fieldset/div[4]/div[1]/span/label[1]"));
            acceptButton.Click();

            IWebElement sendButton = chromeDriver.FindElement(By.XPath("//*[@id=\"app\"]/div/main/div/form/fieldset/div[4]/div[2]/button"));
            sendButton.Click();
            // chromeDriver.Close();
        }
    }
}
