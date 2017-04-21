using TechTalk.SpecFlow;
using DRFosterAutomationFramework.eMBED_Pages;
using DRFosterAutomationFramework.Common;
using System;

namespace eMBEDAutomationTests.Features.Steps
{
    [Binding]
    public class ValidateEmbedDashboardPageFeaturesSteps : SharedBasis
    {
        [Given(@"I am logged into eMBED and viewing the Dashboard page")]
        public void GivenIAmLoggedIntoEMBEDAndViewingTheDashboardPage()
        {
            // TODO: This repeats steps in the prior test. We need to retain state from the previous test
            StartDriverAndLaunchTheBrowser();
            eMBEDLandingPage.GoToEmbedHomePage();
            eMBEDLandingPage.EnterLoginDetails();
            eMBEDLandingPage.DoLogin();
            Extensions.WaitForPageToLoad();
            eMBEDLandingPage.ConfirmWeAreLoggedInToTheEmbedHomePage();
        }

        //------------------------------------------------------------------
        // Scenario: A top navigation section provides links to CIM, account and view settings

        [Given(@"the top navigation elements have loaded")]
        public void GivenTheTopNavigationElementsHaveLoaded()
        {
           eMBEDDashboardPage.validateTopBarNavigationIsPresent();
           eMBEDDashboardPage.validateTopBarNavigationElements();
        }

        [Then(@"each goes to the expected location")]
        public void ThenEachGoesToTheExpectedLocation()
        {
            eMBEDDashboardPage.TopNavigationLinksURLCheck();
            eMBEDDashboardPage.TopNavigationLinkTextCheck();
        }

        //------------------------------------------------------------------
        // Scenario: A Filter element allows users to select month and year range for analysis

        [Given(@"I have clicked on the burger icon")]
        public void GivenIHaveClickedOnTheFilterBurgerIcon()
        {
            eMBEDDashboardPage.findAndClickBurgerIcon();
        }

        [When(@"I select a month and year range")]
        public void WhenISelectAMonthAndYearRange()
        {
            eMBEDDashboardPage.selectMonthAndYearRangeForSearch();
        }

        [Then(@"the data returned matches the date range selected")]
        public void ThenTheDataReturnedMatchesTheDateRangeSelected()
        {
            eMBEDDashboardPage.dataReturnedMatchesTheDateRangeSelected();
        }

        //------------------------------------------------------------------
        //Scenario: A set of navigation links are shown that take the user to relevent dashboard sections

        [Given(@"the navigation elements are present on the page")]
        public void GivenTheNavigationElementsArePresentOnThePage()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        [Given(@"the SAR (.*) is active")]
        public void GivenTheSARIsActive(string p0)
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        [Given(@"each other (.*) is present and inactive but selectable")]
        public void GivenEachOtherIsPresentAndInactiveButSelectable(string p0)
        {
            //eMBEDDashboardPage.confirmDashboardTabLinksAreCorrect();
        }

        [Then(@"they link to the expected (.*)")]
        public void ThenTheyLinkToTheExpected(string p0, Table table)
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        // ----------------------------------------------------------------
        // Scenario: Secondary Care Indicators panel can be expanded to view SAR by ACS and by Diagnosis data

        [Given(@"I have expanded the Secondary Care Indicators panel")]
        public void GivenIHaveExpandedTheSecondaryCareIndicatorsPanel()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }
        
        [Given(@"I can see the SAR by ACS and by Diagnosis sections")]
        public void GivenICanSeeTheSARByACSAndByDiagnosisSections()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        [Then(@"I can expand both of these to view the data in each panel section")]
        public void ThenICanExpandBothOfTheseToViewTheDataInEachPanelSection()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        // ----------------------------------------------------------------
        // Scenario: A user can export the information on the dashboard to PDF

        [Given(@"I have selected the Export to PDF tool icon in a (.*)")]
        public void GivenIHaveSelectedTheExportToPDFToolIconInA(string p0)
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        [When(@"a PDF file save dialogue is opened")]
        public void WhenAPDFFileSaveDialogueIsOpened()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }
        
        [Then(@"I can save the PDF and get returned to the main screen")]
        public void ThenICanSaveThePDFAndGetReturnedToTheMainScreen(Table table)
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        // ----------------------------------------------------------------
        // Scenario: Footer text provides required copyright notices and reference links

        [Given(@"the footer has copyright notices and reference links")]
        public void GivenTheFooterHasCopyrightNoticesAndReferenceLinks()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }

        [Then(@"the copyright notices should state the current year")]
        public void ThenTheCopyrightNoticesShouldStateTheCurrentYear()
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }
        
        [Then(@"reference links should go to the correct locations")]
        public void ThenReferenceLinksShouldGoToTheCorrectLocations(Table table)
        {
            Console.WriteLine("ScenarioContext.Current.Pending();");
        }
    }
}
