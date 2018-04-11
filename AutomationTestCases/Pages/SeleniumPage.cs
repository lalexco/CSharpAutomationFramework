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
    public class SeleniumPage : BasePage
    {
        public SeleniumPage()
        {
            InitPage();
        }

        #region Elements
        [FindsBy(How = How.XPath, Using = "//a[@title = 'Selenium Projects']")]
        public IWebElement SeleniumProjectsMenu;
        #endregion Elements


        public SeleniumPage Clicking(IWebElement element)
        {
            ClickElement(element);
            return this;
        }

        public SeleniumPage AssertDisplayed(IWebElement element)
        {
            AssertIsDisplayed(element);
            return this;
        }
    }
}
