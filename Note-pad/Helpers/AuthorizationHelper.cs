using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace Note_pad
{
    public class AuthorizationHelper: HelperBase
    {
        public AuthorizationHelper(ApplicationManager manager)  
            : base(manager)
        {
        }

        public bool IsLoggedIn()
        {
            try
            {
                driver.FindElement(By.Id("email"));
            }
            catch
            {
                return false;
            }
            return true;
        }
        public void Authorization(AccountData user)
        {
            if (!IsLoggedIn())
            {
                Logout();
            }
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys(user.Username);
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys(user.Password);
            driver.FindElement(By.CssSelector("tr:nth-child(3) input")).Click();
        }
        public void Logout()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Выйти")).Click();
        }
        public string GetAuthorizedLogin()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".account_info > div:nth-child(2) > a:nth-child(1)")).Click();
            var email = driver.FindElement(By.CssSelector("input.ng-pristine")).GetAttribute("value");
            Console.WriteLine(email);
            manager.Navigation.OpenHomePage();
            return email;
        }
    }
}