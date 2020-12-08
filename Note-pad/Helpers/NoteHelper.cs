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
    public class NoteHelper: HelperBase
    {
        public NoteHelper(ApplicationManager manager)
            : base(manager)
        {
        }
        
        public void DeleteNote()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".icon_menu")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".icon_delete")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("button.ui-button:nth-child(1) > span:nth-child(1)")).Click();
        }

        public void RenameNote(NoteData note)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".icon_menu")).Click();
            driver.FindElement(By.LinkText("Параметры")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("title")).Click();
            driver.FindElement(By.Id("title")).SendKeys(note.Name);
            driver.FindElement(By.CssSelector("input:nth-child(18)")).Click();
        }

        public void CreateNewNote()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("+")).Click();
        }

        public NoteData GetRenamedNoteData()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".icon_menu")).Click();
            driver.FindElement(By.LinkText("Параметры")).Click();
            Thread.Sleep(3000);
            NoteData note = new NoteData(driver.FindElement(By.Id("title")).GetAttribute("value"));
            Console.WriteLine(note.Name);
            driver.FindElement(By.CssSelector("input:nth-child(18)")).Click();
            return note;
        }
    }
}