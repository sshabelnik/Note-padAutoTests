using NUnit.Framework;

namespace Note_pad
{
    public class LoginTests: TestBase
    {
        [Test]
        public void LoginWithValidData()
        {
            manager.Navigation.OpenHomePage();
            AccountData user = new AccountData(Settings.Username, Settings.Password);
            manager.Auth.Authorization(user);
            
            var passedUsername = manager.Auth.GetAuthorizedLogin();
            Assert.AreEqual(user.Username, passedUsername);
        }
        
        [Test]
        public void LoginWithInvalidData()
        {
            manager.Navigation.OpenHomePage();
            AccountData user = new AccountData(Settings.Username, Settings.Password);
            string passedUsername;
            try
            {
                passedUsername = manager.Auth.GetAuthorizedLogin();
            }
            catch
            {
                passedUsername = null;
            }
            Assert.AreNotEqual(user.Username, passedUsername);
        }
    }
}