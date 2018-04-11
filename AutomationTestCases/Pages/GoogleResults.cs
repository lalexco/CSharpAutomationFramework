using AutomationFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestCases.Pages
{
    public class GoogleResults : BasePage
    {
        public GoogleResults()
        {
            InitPage();
        }

        #region Elements
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Imágenes')]")]
        public IWebElement Img;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Vídeos')]")]
        public IWebElement Videos;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Libros')]")]
        public IWebElement Libros;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Noticias')]")]
        public IWebElement Noticias;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Todo')]")]
        public IWebElement Todo;

        [FindsBy(How = How.XPath, Using = "//a[@href = 'https://www.seleniumhq.org/']")]
        public IWebElement SeleniumOrg;
        #endregion Elements

        public GoogleResults Clicking(IWebElement element)
        {
            ClickElement(element);
            return this;
        }
    }
}
