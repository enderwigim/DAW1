﻿using OpenQA.Selenium;
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
        private IWebDriver _chromeDriver;        // Seba: Inicia en nulo, en el constructor lo inicias, pero, te vas a acordar de hacerlo en todos los constructores?
                                                    // si te olvidas, te explota la aplicación: Si no ganas nada inicializando el atributo en el constructor, no lo inicies ahi,
                                                    // a parte consume espacio que en este constructor no importa, pero en algunos que ya tienen otras cosas ocupa espacio
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
        public void HandleButton(Button button)         // Seba:  Si es mas de una opcion devuelve un int en lo que fallo (un 0 o un 1 si se completo correctamente, si es una sola un bool)
        {
            try
            {
                var buttonDriver = _chromeDriver.FindElement(By.XPath(button.XPath));    // Seba: Estos if esta bien aqui ya que son lo suficientemente pequeños, si fuesen 
                if (button.Type.ToLower() == "click")                                      // mas grandes siempre podes pasarlos a funciones.
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
                Console.Error.WriteLine(ex.ToString());
                return;
                
                                        // Seba: Cuida los espacios, formatea bien el codigo. 
            }
        }
        public void DriveClose()
        {
            _chromeDriver.Close();            // Seba: Si es una opcion de diseño en particular conservala, es a gusto de cada, pero investiga el using a ver que te parece
        }                                        // te va a prevenir de dolores de cabeza.


    }
}
