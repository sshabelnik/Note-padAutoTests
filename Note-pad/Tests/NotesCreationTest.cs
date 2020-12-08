using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml.Serialization;
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
    public class NotesCreationTest: TestBase
    {
        public static IEnumerable<NoteData> GroupDataFromXmlFile()
        {
            return (List<NoteData>)new XmlSerializer(typeof(List<NoteData>))
                .Deserialize(new StreamReader("/Users/honning69/Documents/GitHub/Note-padAutoTests/DataGenerator/bin/Debug/notes.xml"));
        }


        [Test, TestCaseSource("GroupDataFromXmlFile")]

        public void TestMethod(NoteData note)
        {
            manager.Navigation.OpenHomePage();
            AccountData user = new AccountData("Boooo211@yandex.ru", "12345678");
            manager.Auth.Authorization(user);
            var authorizedLogin = manager.Auth.GetAuthorizedLogin();
            Assert.AreEqual(user.Username, authorizedLogin);
            manager.Notes.CreateNewNote();
            manager.Notes.RenameNote(note);
            var assertNote = manager.Notes.GetRenamedNoteData();
            Assert.AreEqual(note.Name, assertNote.Name);
            manager.Notes.DeleteNote();
            manager.Auth.Logout();
        }
    }
}