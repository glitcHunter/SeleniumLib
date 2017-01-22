using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFrameworkUnitTests
{
    public class PropertiesCollection
    {
        public enum PropertyType
        {
            Id,
            Name,
            ClassName,
            LinkText,
        }

        public static IWebDriver driver { get; set; }
    }
}
