using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleiumTestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxoftTestProject.Tests
{   
    class LoginTests
    {
        [SetUp] //Starting the driver and opening the web site
        public void Initialize()
        {
            //Calling the driver through "PropertiesCollection"
            PropertiesCollection.driver = new ChromeDriver();

            //Starting the driver and navigating the plusplaner web site
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.plusplaner.com");
          
            //The feedback tells me if it is/isn't executed test via the Output link
            Console.WriteLine("Opened link \n");
        }

        //1.5.1 Test
        [Test]
        public void FirstTest()
        {
            //Checking the state of TextBoxes and Button
            SeleniumGetMethods.UserNameTextboxCheck("Username", PropertyType.Name);
            SeleniumGetMethods.PasswordTextboxCheck("Password", PropertyType.Name);
            SeleniumGetMethods.LoginButtonCheck("action", PropertyType.Name);

            //Click on button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

            //Getting alert message from the website
            Console.WriteLine("Alert message: " + SeleniumGetMethods.GetText("/html/body/div[1]/div/div/div/div/div/div/div/div", PropertyType.CssName) + "\n");
        }

        //1.5.2 Test
        [Test]
        public void SecoundTest()
        {
            //Checking the state of TextBoxes and Button
            SeleniumGetMethods.UserNameTextboxCheck("Username", PropertyType.Name);
            SeleniumGetMethods.PasswordTextboxCheck("Password", PropertyType.Name);
            SeleniumGetMethods.LoginButtonCheck("action", PropertyType.Name);

            //Entering the correct Username
            SeleniumSetMethods.EnterText("Username", "tester12", PropertyType.Name);                                 

            //Click on button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

            //Getting alert message from the website
            Console.WriteLine("Alert message: " + SeleniumGetMethods.GetText("/html/body/div[1]/div/div/div/div/div/div/div/div", PropertyType.CssName) + "\n");

        }

        //1.5.3 Test
        [Test]
        public void ThirdTest()
        {
            //Checking the state of TextBoxes and Button
            SeleniumGetMethods.UserNameTextboxCheck("Username", PropertyType.Name);
            SeleniumGetMethods.PasswordTextboxCheck("Password", PropertyType.Name);
            SeleniumGetMethods.LoginButtonCheck("action", PropertyType.Name);

            //Entering the correct Password
            SeleniumSetMethods.EnterText("Password", "Password1!", PropertyType.Name);

            //Click on button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

            //Getting alert message from the website
            Console.WriteLine("Alert message: " + SeleniumGetMethods.GetText("/html/body/div[1]/div/div/div/div/div/div/div/div", PropertyType.CssName) + "\n");
        }

        //1.5.4 Test
        [Test]
        public void ForthTest()
        {
            //Checking the state of TextBoxes and Button
            SeleniumGetMethods.UserNameTextboxCheck("Username", PropertyType.Name);
            SeleniumGetMethods.PasswordTextboxCheck("Password", PropertyType.Name);
            SeleniumGetMethods.LoginButtonCheck("action", PropertyType.Name);

            //Entering the correct Username
            SeleniumSetMethods.EnterText("Username", "tester12", PropertyType.Name);

            //Entering the invalid Password
            SeleniumSetMethods.EnterText("Password", "Password1", PropertyType.Name);

            //Click on button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);
            
            //Getting alert message from the website
            Console.WriteLine("Alert message: " + SeleniumGetMethods.GetText("/html/body/div[1]/div/div/div/div/div/div/div/div", PropertyType.CssName) + "\n");

        }

        //1.5.5 Test
        [Test]
        public void FifthTest()
        {
            //Checking the state of TextBoxes and Button
            SeleniumGetMethods.UserNameTextboxCheck("Username", PropertyType.Name);
            SeleniumGetMethods.PasswordTextboxCheck("Password", PropertyType.Name);
            SeleniumGetMethods.LoginButtonCheck("action", PropertyType.Name);

            //Entering the correct Username
            SeleniumSetMethods.EnterText("Username", "tester12", PropertyType.Name);

            //Entering the correct Password
            SeleniumSetMethods.EnterText("Password", "Password1!", PropertyType.Name);

            //Click on button "Prijava"
            SeleniumSetMethods.Click("action", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            //Closing the driver
            PropertiesCollection.driver.Close();

            //The feedback tells me if it is/isn't executed test via the Output link
            Console.WriteLine("Close the browser");
        }
    }
}
