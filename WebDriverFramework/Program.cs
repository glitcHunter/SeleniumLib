using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\chromedriver_win32");
            driver.Navigate().GoToUrl("http://www.bisnode.pl/");

            IWebElement element = driver.FindElement(By.Name("s"));

            element.SendKeys("Test");

            driver.Close();

         //   Console.Read();
        }
    }
}
