using TechTalk.SpecFlow;
using DRFosterAutomationFramework.eMBED_Pages;
using DRFosterAutomationFramework.Common;

namespace eMBEDAutomationTests.Workflows.Steps
{
    [Binding]
    public class LoginToEmbedSteps : SharedBasis
    {
        [Given(@"I have navigated to the eMBED website")]
        public void GivenIHaveNavigatedToTheEMBEDWebsite()
        {
            StartDriverAndLaunchTheBrowser();
            eMBEDLandingPage.GoToEmbedHomePage();
        }
        
        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            eMBEDLandingPage.EnterLoginDetails();
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            eMBEDLandingPage.DoLogin();
        }
        
        [Then(@"I am logged into the eMbed dashboard page")]
        public void ThenIAmLoggedIntoTheEMbedDashboardPage()
        {
            Extensions.WaitForPageToLoad();
            eMBEDLandingPage.ConfirmWeAreLoggedInToTheEmbedHomePage();
        }
    }
}