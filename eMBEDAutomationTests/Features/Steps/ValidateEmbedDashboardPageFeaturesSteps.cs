using TechTalk.SpecFlow;
using DRFosterAutomationFramework.eMBED_Pages;
using DRFosterAutomationFramework.Common;

namespace eMBEDAutomationTests.Features.Steps
{
    [Binding]
    public class ValidateEmbedDashboardPageFeaturesSteps : SharedBasis
    {
        [Given(@"I am logged into eMBED and viewing the Dashboard page")]
        public void GivenIAmLoggedIntoEMBEDAndViewingTheDashboardPage()
        {
            // TODO: This repeats the last step of the prior test. We need to retain state from the previous test
            eMBEDLandingPage.ConfirmWeAreLoggedInToTheEmbedHomePage();
        }
        
        [Given(@"the top navigation elements have loaded")]
        public void GivenTheTopNavigationElementsHaveLoaded()
        {
            eMBEDDashboardPage.validateMainNavigationIsPresent();
        }
        
        [Given(@"I have clicked on the filter burger icon")]
        public void GivenIHaveClickedOnTheFilterBurgerIcon()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the navigation elements are present on the page")]
        public void GivenTheNavigationElementsArePresentOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the SAR (.*) is active")]
        public void GivenTheSARIsActive(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"each other (.*) is present and inactive but selectable")]
        public void GivenEachOtherIsPresentAndInactiveButSelectable(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have expanded the Secondary Care Indicators panel")]
        public void GivenIHaveExpandedTheSecondaryCareIndicatorsPanel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I can see the SAR by ACS and by Diagnosis sections")]
        public void GivenICanSeeTheSARByACSAndByDiagnosisSections()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected the Export to PDF tool icon in a (.*)")]
        public void GivenIHaveSelectedTheExportToPDFToolIconInA(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the footer has copyright notices and reference links")]
        public void GivenTheFooterHasCopyrightNoticesAndReferenceLinks()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select a month and year range")]
        public void WhenISelectAMonthAndYearRange()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a PDF file save dialogue is opened")]
        public void WhenAPDFFileSaveDialogueIsOpened()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"each (.*) goes to the (.*)")]
        public void ThenEachGoesToThe(string p0, string p1, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the data returned matches the date range selected")]
        public void ThenTheDataReturnedMatchesTheDateRangeSelected()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"they link to the expected (.*)")]
        public void ThenTheyLinkToTheExpected(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can expand both of these to view the data in each panel section")]
        public void ThenICanExpandBothOfTheseToViewTheDataInEachPanelSection()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can save the PDF and get returned to the main screen")]
        public void ThenICanSaveThePDFAndGetReturnedToTheMainScreen(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the copyright notices should state the current year")]
        public void ThenTheCopyrightNoticesShouldStateTheCurrentYear()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"reference links should go to the correct locations")]
        public void ThenReferenceLinksShouldGoToTheCorrectLocations(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
