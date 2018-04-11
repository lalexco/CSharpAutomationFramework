using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationFramework
{
    public class Browser
    {
        internal IWebDriver Driver;

        protected IWebDriver GetBrowser(string BrowserName)
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return Driver;
        }

        protected void GoToUrl(string Url)
        {
            Driver.Navigate().GoToUrl(Url);
        }

        protected void VerificaTitulo(string TituloEsperado)
        {
            if (Driver.Title == TituloEsperado)
            {
                Console.WriteLine("El título es correcto, es lo esperado " + Driver.Title);
            }
            else
            {
                Console.WriteLine("El Titulo no es correcto, esperado: " + TituloEsperado + "actual: " + Driver.Title);
            }
        }

        protected void AssertIsDisplayed(IWebElement element)
        {
            bool EstaDesplegado = false;
            int x = 0;
            while (!EstaDesplegado && x <= 20)
            {
                try
                {
                    EstaDesplegado = element.Displayed;
                    Console.WriteLine("Elemento desplegado");
                }
                catch (NoSuchElementException)
                {
                    Console.WriteLine("Buscando elemento.....");
                }

                x++;
            }

            Assert.IsTrue(element.Displayed, "Validacion de elemento desplegado fallida, verificar elemento.");
        }

        protected void LeerImprimirLista()
        { }

        protected void VerificaSiEsVisible(IWebElement element)
        {
            bool estaDesplegado = false;
            try
            {
                estaDesplegado = element.Displayed;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Cayendo en exception..");
            }

            if (!estaDesplegado)
            {
                Console.WriteLine("El elemento no está desplegado");
            }

            else
            {
                Console.WriteLine("El elemento está desplegado");
            }

        }

        protected void ClickElement(IWebElement element)
        {
            Console.WriteLine("Haciendo click");
            element.Click();
        }

        protected void EnterText(IWebElement element, string value)
        {
            Console.WriteLine("Mandando Texto");
            element.SendKeys(value);
        }

        protected void HacerSubmit(IWebElement element)
        {
            element.Submit();
        }

        protected void RetornaURL()
        { }

        protected void CerrarBrowser()
        { }

        protected void CerrarBrowser(IWebElement element, string Xpath)
        {

        }

        //Crear una lista en Browser que haga un foreach e imprima todos los elementos
        //Implementarla en MicrosoftHome
        //Creaer el WebElement que contenga elementos hijos
        //LLamarla desde los test cases






    }
}
