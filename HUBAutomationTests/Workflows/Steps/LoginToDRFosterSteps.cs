using TechTalk.SpecFlow;
using DRFosterAutomationFramework.HUBPages;
using DRFosterAutomationFramework.Common;

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
            //LoginPage.LoginAs(UserList.adminUser).WithPassword(UserList.adminPassword).EnterLoginDetails();
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