using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleiumTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp] //Pokretanje drivera i otvaranje web stranice
        public void Initialize()
        {
            //Pozivanje drivera kroz "PropertiesCollection"
            PropertiesCollection.driver = new ChromeDriver();

            //Pokretanje drivera te navigiranje na plusplaner webstranciu
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.plusplaner.com");

            //Povratna informacija koja nam govori dali je/nije izvrsen dio testa putem Output linka
            Console.WriteLine("Opened link");
        }

        //1.5.1 Test
        [Test]
        public void FirstTest()
        {            
            //Click na button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

           // Console.WriteLine("Alert message: " + SeleniumGetMethods.GetText("div: contains('Korisničko')", PropertyType.CssName));
        }

        //1.5.2 Test
        [Test]
        public void SecoundTest()
        {
            //Upisivanje ispravnog Username-a
            SeleniumSetMethods.EnterText("Username", "tester12", PropertyType.Name);

            //Click na button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

        }

        //1.5.3 Test
        [Test]
        public void ThirdTest()
        {
            //Upisivanje ispravnog Passworda-a
            SeleniumSetMethods.EnterText("Password", "Password1!", PropertyType.Name);

            //Click na button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

        }

        //1.5.4 Test
        [Test]
        public void ForthTest()
        {
            //Upisivanje ispravnog Username-a
            SeleniumSetMethods.EnterText("Username", "tester12", PropertyType.Name);

            //Upisivanje neispravnog Passworda-a
            SeleniumSetMethods.EnterText("Password", "Password1", PropertyType.Name);

            //Click na button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

        }

        //1.5.5 Test
        [Test]
        public void FifthTest()
        {
            //Upisivanje ispravnog Username-a
            SeleniumSetMethods.EnterText("Username", "tester12", PropertyType.Name);

            //Upisivanje ispravnog Passworda-a
            SeleniumSetMethods.EnterText("Password", "Password1!", PropertyType.Name);

            //Click na button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            // Zatvaranje drivera
            PropertiesCollection.driver.Close();

            Console.WriteLine("Close the browser");
        }
    }
}
