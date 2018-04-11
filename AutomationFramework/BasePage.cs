using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework
{
    public abstract class BasePage : Browser
    {
        public void InitBrowser()
        {
            DriverContext.Driver = GetBrowser("Chrome");
        }

        public void InitPage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
