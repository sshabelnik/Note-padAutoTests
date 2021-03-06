﻿// Generated by Selenium IDE
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
    [TestFixture]
    public class AuthCreateEditDeleteLogoutTest {
        private IWebDriver driver;
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
        [Test]
        public void authCreateEditDeleteLogout() {
            driver.Navigate().GoToUrl("https://note-pad.net/");
            driver.Manage().Window.Size = new System.Drawing.Size(1440, 900);
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).SendKeys("s.shabelnik01@gmail.com");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("SeReGa24042001");
            driver.FindElement(By.CssSelector("tr:nth-child(3) input")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("+")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".icon_menu")).Click();
            driver.FindElement(By.LinkText("Параметры")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("title")).Click();
            driver.FindElement(By.Id("title")).SendKeys("Name edited");
            driver.FindElement(By.CssSelector("input:nth-child(18)")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".icon_menu")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".icon_delete")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("button.ui-button:nth-child(1) > span:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Выйти")).Click();
        }
    }    
}
