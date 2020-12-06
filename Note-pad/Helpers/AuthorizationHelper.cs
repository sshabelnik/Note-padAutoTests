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
        
        public void Authorization(AccountData user)
        {
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
    }
}