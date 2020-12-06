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
    public class TestBase
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars {get; private set;}
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp() {
            driver = new FirefoxDriver("/Users/honning69/Downloads");
            driver.Manage().Window.Maximize();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown() {
            driver.Quit();
        }   
    }
}