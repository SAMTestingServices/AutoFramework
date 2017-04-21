using TechTalk.SpecFlow;

using System;
using Framework.Common;
using PageObjects_ARC;

namespace ArcAutomationTests.Features.Steps
{
    [Binding]
    public class SearchGridFeaturesSteps : SharedBasis
    {
        [Given(@"I have navigated to the Arc website")]
        public void GivenIHaveNavigatedToTheArcWebsite()
        {
            StartDriverAndLaunchTheBrowser();
            ArcHomePage.GoToPage();


        }

        [Given(@"have logged in")]
        public void GivenHaveLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }


        [Given(@"I am in operations in Tanker View")]
        public void GivenIAmInOperationsInTankerView()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I am on the Fixture Grid page")]
        public void GivenIAmOnTheFixtureGridPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter the following search terms into the Search bar: ""(.*)""")]
        public void GivenIEnterTheFollowingSearchTermsIntoTheSearchBar(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"click Return")]
        public void GivenClickReturn()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the correct fixture with the Gain ID = ""(.*)"" should be returned as the first result")]
        public void ThenTheCorrectFixtureWithTheGainIDShouldBeReturnedAsTheFirstResult(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"there should be (.*) result returned")]
        public void ThenThereShouldBeResultReturned(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
