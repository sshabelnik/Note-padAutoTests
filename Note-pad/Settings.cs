using System;
using System.Xml;

namespace Note_pad
{
    public static class Settings
    {
        public static string file = "/Users/honning69/Documents/GitHub/Note-pad/Settings.xml";

        private static string baseURL;

        private static string username;
        private static string password;
        
        private static XmlDocument document;
        
        static Settings()
        {
            if (!System.IO.File.Exists(file)) { throw new Exception("Problem: settings file not found: " + file); }
            document = new XmlDocument();
            document.Load(file);
        }
        
        public static string BaseURL
        {
            get
            {
                if (baseURL == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("BaseURL");
                    baseURL = node.InnerText;
                }
                return baseURL;
            }
        }
        

        public static string Username
        {
            get
            {
                if (username == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Username");
                    username = node.InnerText;
                    
                }

                return username;
            }
        }

        public static string Password
        {
            get
            {
                if (password == null)
                {
                    XmlNode node = document.DocumentElement.SelectSingleNode("Password");
                    password = node.InnerText;
                }

                return password;
            }
        }
    }
}