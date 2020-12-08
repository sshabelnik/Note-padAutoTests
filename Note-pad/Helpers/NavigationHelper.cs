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
    public class NavigationHelper: HelperBase
    {
        public NavigationHelper(ApplicationManager manager)
            : base(manager)
        {
            
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Settings.BaseURL);
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 900);
        }
    }
}