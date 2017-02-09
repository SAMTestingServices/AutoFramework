using System;
using TechTalk.SpecFlow;
using HIPTargettedRegression.Pages;
using HIPTargettedRegression.Common;


namespace HIPRegressionTests.Defects.Steps
{
    [Binding]
    public class HUB_514EnsureAnalyseByTypesRunWithoutErrorSteps
    {
        [Given(@"I am logged into the Dr Foster website")]
        public void GivenIAmLoggedIntoTheDrFosterWebsite()
        {
            LoginPage.GoToHomePage();
            LoginPage.CheckWeHitTheRightPage();
            LoginPage.LoginAs(UserList.adminUser).WithPassword(UserList.adminPassword).EnterLoginDetails();
            LoginPage.DoLogin();
            LoginPage.ValidateWeGotLoggedIn();
        }
        
        [Given(@"I am viewing data as the Aintree University Hospital NHS Foundation Trust")]
        public void GivenIAmViewingDataAsTheAintreeUniversityHospitalNHSFoundationTrust()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected HIP from the dashboard")]
        public void GivenIHaveSelectedHIPFromTheDashboard()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select the Analysis tab")]
        public void GivenISelectTheAnalysisTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"select the Drill Down menu option")]
        public void GivenSelectTheDrillDownMenuOption()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"from the Analyse By dropdown select an Analyse By (.*) previously seen to error")]
        public void GivenFromTheAnalyseByDropdownSelectAnAnalyseByPreviouslySeenToError(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the corresponding Analyse By report should be produced without error")]
        public void ThenTheCorrespondingAnalyseByReportShouldBeProducedWithoutError()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
