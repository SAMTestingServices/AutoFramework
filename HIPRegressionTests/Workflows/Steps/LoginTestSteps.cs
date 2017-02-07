using HIPTargettedRegression.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HIPTargettedRegression.Common;
using System.Configuration;

namespace HIPRegressionTests.Workflows.Steps
{
    [TestClass]
    public class LoginTestSteps : SharedBasis
    {
        [TestMethod]
        public void UserCanLogin()
        {
            LoginPage.GoToHomePage();
            LoginPage.CheckWeHitTheRightPage();

            // TODO: b) Encrypt/Decrypt the username and password to be more secure
            LoginPage.LoginAs(UserList.adminUser).WithPassword(UserList.adminPassword).EnterLoginDetails();

            LoginPage.DoLogin();
            LoginPage.ValidateWeGotLoggedIn();
        }
    }
}