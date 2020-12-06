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
    public class ApplicationManager
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars {get; private set;}
        private IJavaScriptExecutor js;
        
        private NavigationHelper navigation;
        private NoteHelper notes;
        private AuthorizationHelper auth;

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }

        public AuthorizationHelper Auth
        {
            get
            {
                return auth;
            }
        }

        public NoteHelper Notes
        {
            get
            {
                return notes;
            }
        }

        public ApplicationManager()
        {
            driver = new FirefoxDriver("/Users/honning69/Downloads");
            driver.Manage().Window.Maximize();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();

            navigation = new NavigationHelper(this);
            notes = new NoteHelper(this);
            auth = new AuthorizationHelper(this);

        }

        public void Stop()
        {
            driver.Quit();
        }
    }
}