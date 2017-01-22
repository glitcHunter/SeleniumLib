﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebDriverFrameworkUnitTests.PropertiesCollection;

namespace WebDriverFrameworkUnitTests
{
    [TestFixture]
   public class BisnodeNavigationUnitTest
    {

        private BisnodeBasicNavigation bisnodeFactory()
        {
            return new BisnodeBasicNavigation();
        }

        BisnodeBasicNavigation bisnode;
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\chromedriver_win32");
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.bisnode.pl/");

             bisnode = bisnodeFactory();

        }

        [Test]
        public void RunBase()
        {           
           PageObject pageObject = bisnode.SiteNavigation();
        }
        [Test]
        public void CheckSearchForm_TypeText_OK()
        {
            bisnode.EnterTextInSearchForm("s");
        }
        [Test]
        public void NavigateTo_ProduktyIRozwiazania_OK()
        {
            bisnode.GroupButtonClick();
        }
        [Test]
        public void GetTextValue()
        {
            Assert.AreEqual("http://www.bisnode.pl", bisnode.GetCountryText());
        }

        [Test]
        public void selectDDLElementByText()
        {
            bisnode.SelectCountryByName("Polska");
        }

        [Test]
        public void GroupDDL()
        {
            string result = bisnode.getCountrFromDDL();
            Assert.AreEqual(result, "Polska");
        }

       [TearDown]
        public void PostConditions()
        {
           driver.Close();   
        }

    }
}
