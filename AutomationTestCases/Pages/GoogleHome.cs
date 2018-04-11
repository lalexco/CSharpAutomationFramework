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
    public class GoogleHome : BasePage
    {
        public GoogleHome()
        {
            InitBrowser();
            InitPage();
            GoToUrl("https://www.google.com.mx");
        }

        #region Elements
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement Search;
        #endregion Elements


        public GoogleHome Clicking(IWebElement element)
        {
            ClickElement(element);
            return this;
        }
        public GoogleHome Submit(IWebElement element)
        {
            HacerSubmit(element);
            return this;
        }
        public GoogleHome EnteringText(IWebElement element, String valor)
        {
            EnterText(element, valor);
            return this;
        }
        public GoogleHome ListCompare()
        {
            Console.WriteLine("Ordering Ascending");
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            list.Add(10);
            list.Add(11);

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ordering Descending");
            var orderDesc = list.OrderByDescending(x => x);

            foreach (var item in orderDesc)
            {
                Console.WriteLine(item);
            }
            return this;

        }
        public GoogleHome Fibonacci()
        {
            Console.WriteLine("\n Fibonacci Serie");
            int a = 0;
            int b = 1;
            int resultado = 1;

            for (int i = 0; i < 20; i++)
            {
                resultado = a + b;
                Console.WriteLine(resultado);

                a = b;
                b = resultado;
                //Console.WriteLine(resultado);
            }

            return this;
        }
        public GoogleHome SecondRevers()
        {
            Console.WriteLine("\n Secoond Reverse");
            string s = "Hola Mundo";
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.Write(new string(charArray));

            return this;
        }
        public GoogleHome Reverse()
        {
            string[] array = { "Text", "Hello" };

            // Print.
            foreach (string value in array)
            {
                Console.Write(value);
            }
            Console.WriteLine();

            // Reverse.
            Array.Reverse(array);

            foreach (string value in array)
            {
                Console.Write(value);
            }
            Console.WriteLine();
            return this;

        }

        public GoogleHome ArrayExercise()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6 };

            List<int> List1 = A.ToList();
            List1.Sort();
            int counter = 0;
            foreach (var item in List1)
            {
                if (item != counter)
                {
                    Console.WriteLine(item);
                }

            }

            return this;
        }

    }
}
