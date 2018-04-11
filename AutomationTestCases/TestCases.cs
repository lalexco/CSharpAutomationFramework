using System;
using AutomationTestCases.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTestCases
{
    [TestClass]
    public class TestCases
    {
        GoogleHome googleHome;
        GoogleResults googleResults;
        SeleniumPage seleniumPage;

        [TestInitialize]
        public void BeforeEachTest()
        {
            googleHome = new GoogleHome();
            googleResults = new GoogleResults();
            seleniumPage = new SeleniumPage();
        }

        [TestMethod]
        public void SearchProduct()
        {
            googleHome.Clicking(googleHome.Search)
                      .EnteringText(googleHome.Search, "Selenium")
                      .Submit(googleHome.Search);

            googleResults
                .Clicking(googleResults.Videos)
                .Clicking(googleResults.Img)
                .Clicking(googleResults.Libros)
                .Clicking(googleResults.Noticias)
                .Clicking(googleResults.Todo)
                .Clicking(googleResults.SeleniumOrg);
        }
    }
}

