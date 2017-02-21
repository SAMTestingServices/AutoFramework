using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.HUBPages;
using System.Configuration;
using TechTalk.SpecFlow;
using System;

namespace HUBAutomationTests.Workflows.Steps
{
    [Binding]
    public class LoginToDRFosterSteps : SharedBasis
    {
        [Given(@"I have navigated to the Dr Foster website")]
        public void GivenIHaveNavigatedToTheDrFosterWebsite()
        {
            StartDriverAndLaunchTheBrowser();
            LoginPage.GoToHomePage();
            LoginPage.CheckWeHitTheRightPage();
        }
        
        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            LoginPage
                .LoginAs(ConfigurationManager.AppSettings[UserList.HUBAdminUsername])
                .WithPassword(ConfigurationManager.AppSettings[UserList.HUBAdminPassword].Decrypt())
                .EnterLoginDetails();
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            LoginPage.DoLogin();
        }
        
        [Then(@"I am logged into the tools dashboard page")]
        public void ThenIAmLoggedIntoTheToolsDashboardPage()
        {
            LoginPage.ValidateWeGotLoggedIn();
            CleanUp();
        }
    }
}