using DRFosterAutomationFramework.HUB_Pages;
using DRFosterAutomationFramework.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HUBAutomationTests.Workflows.Steps
{
    [TestClass]
    public class LoginTestSteps : SharedBasis
    {
        [TestMethod]
        public void UserCanLogin()
        {
            LoginPage.GoToHomePage();
            LoginPage.CheckWeHitTheRightPage();

            // TODO: Encrypt/Decrypt the username and password to be more secure
            LoginPage.LoginAs(UserList.adminUser).WithPassword(UserList.adminPassword).EnterLoginDetails();

            LoginPage.DoLogin();
            LoginPage.ValidateWeGotLoggedIn();
        }
    }
}