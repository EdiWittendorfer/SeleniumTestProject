using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleiumTestProject
{
    //Postavljanje property-a
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }


    class PropertiesCollection
    {
        //Dodavanje drivera
        public static IWebDriver driver { get; set; }
    }
}
