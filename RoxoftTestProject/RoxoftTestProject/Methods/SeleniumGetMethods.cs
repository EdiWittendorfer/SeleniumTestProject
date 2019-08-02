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
            if (elementType == PropertyType.CssName)
                return PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/div/div/div")).Text;
            else return String.Empty;
        }

        public static string IsEnabled(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
            {
                if (PropertiesCollection.driver.FindElement(By.Id(element)).Enabled)
                {
                    return (element);
                }
                else
                {
                    return String.Empty;
                }
            }

            if (elementType == PropertyType.Name)
            {
                if (PropertiesCollection.driver.FindElement(By.Name(element)).Enabled)  
                {
                    return (element);
                }
                else
                {
                    return String.Empty;
                }
            }
            else
            {
                return String.Empty;
            }
        }       

    }
}