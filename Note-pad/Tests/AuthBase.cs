using NUnit.Framework;

namespace Note_pad
{
    public class AuthBase: TestBase
    {
        [SetUp]
        public void SetupTest()
        {
            manager.Navigation.OpenHomePage();
            AccountData user = new AccountData(Settings.Username, Settings.Password);
            manager.Auth.Authorization(user);
        }
    }
}