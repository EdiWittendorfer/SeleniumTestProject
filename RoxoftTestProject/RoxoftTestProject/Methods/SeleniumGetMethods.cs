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
        //Gets text from error message
        public static string GetText(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.CssName)
                return PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/div/div/div")).Text;
            else return String.Empty;
        }

        //Checks if Username is dislpayed/enabled/empty        
        public static void UserNameTextboxCheck(string element, PropertyType elementType)
        { 
            bool UserNameTxtDisplayed = PropertiesCollection.driver.FindElement(By.Name(element)).Displayed;
            if (UserNameTxtDisplayed == true)
            {
                Console.WriteLine("Username field is displayed");
                bool UserNameTxtEnabled = PropertiesCollection.driver.FindElement(By.Name(element)).Enabled;
                if (UserNameTxtEnabled == true)
                {
                    Console.WriteLine("Username field is enabled");
                    string UserNameTxtValue = PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
                    if (string.IsNullOrEmpty(UserNameTxtValue))
                    {
                        Console.WriteLine("Username field is empty \n");
                    }
                    else
                    {
                         Console.WriteLine("Username field is NOT empty \n");
                    }
                }
                else
                {
                     Console.WriteLine("Username field is NOT enabled");
                }
            }
            else
            {
                Console.WriteLine("Username field is NOT displayed");
            }
        }

        //Checks if Password is dislpayed/enabled/empty  
        public static void PasswordTextboxCheck(string element, PropertyType elementType)
        {
            bool PasswordTxtDisplayed = PropertiesCollection.driver.FindElement(By.Name(element)).Displayed;
            if (PasswordTxtDisplayed == true)
            {
                Console.WriteLine("Username field is displayed");
                bool PasswordTxtEnabled = PropertiesCollection.driver.FindElement(By.Name(element)).Enabled;
                if (PasswordTxtEnabled == true)
                {
                    Console.WriteLine("Username field is enabled");
                    string PasswordTxtValue = PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
                    if (string.IsNullOrEmpty(PasswordTxtValue))
                    {
                        Console.WriteLine("Password field is empty \n");
                    }
                    else
                    {
                        Console.WriteLine("Password field is NOT empty \n");
                    }
                }
                else
                {
                    Console.WriteLine("Password field is NOT enabled");
                }
            }
            else
            {
                Console.WriteLine("Password field is NOT displayed");
            }
        }

        //Checks if LoginButton is dislpayed/enabled  
        public static void LoginButtonCheck(string element, PropertyType elementType)
        {
            bool LoginButtonDisplayed = PropertiesCollection.driver.FindElement(By.Name(element)).Displayed;
            if (LoginButtonDisplayed == true)
            {
                Console.WriteLine("Login button is displayed");
                bool LoginButtonEnabled = PropertiesCollection.driver.FindElement(By.Name(element)).Enabled;
                if (LoginButtonEnabled == true)
                {
                    Console.WriteLine("Login button is enabled \n");
                }
                else
                {
                    Console.WriteLine("Login button is NOT enabled \n");
                }
            }
            else
            {
                Console.WriteLine("Login button is NOT displayed");
            }
        }
    }
}