using DRFosterAutomationFramework.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRFosterAutomationFramework.HUBPages;
using System.Configuration;
using System;

// Log-in Smoke test without SpecFlow

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

            LoginPage
                .LoginAs(ConfigurationManager.AppSettings[UserList.AdminUsernameFromAppConfig])
                .WithPassword(ConfigurationManager.AppSettings[UserList.AdminPasswordFromAppConfig].Decrypt())
                .EnterLoginDetails();

            LoginPage.DoLogin();
            LoginPage.ValidateWeGotLoggedIn();
        }
    }
}