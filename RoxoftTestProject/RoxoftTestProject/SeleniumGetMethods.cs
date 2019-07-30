using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleiumTestProject
{
    class SeleniumGetMethods
    {
        public static string GetText(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
       //    if (elementType == PropertyType.CssName)
       //         return PropertiesCollection.driver.FindElement(By.CssSelector("div:contains('Korisničko')")).GetAttribute("value");
            else return String.Empty;

        }
    }
}