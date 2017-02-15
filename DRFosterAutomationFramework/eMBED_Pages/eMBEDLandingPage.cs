using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using System;

namespace DRFosterAutomationFramework.eMBED_Pages
{
    class eMBEDLandingPage
    {
        public static void GoToEmbedHomePage()
        {
            Driver.Instance.Navigate().GoToUrl(AddressList.embedTestUrl);
        }

        public static void LogInToEmbed()
        {
            
        }

        public static void ConfirmWeAreLoggedInToTheEmbedHomePage()
        {
            var expectedPageTitle = "Dashboard - embed";
            var actualPageTitle = Driver.Instance.Title;

            if (expectedPageTitle == actualPageTitle)
            {
                Console.WriteLine("As expected, I saw '" + expectedPageTitle + "' on the eMBED home page.");
            }
            else
            {
                Console.WriteLine("I could NOT confirm we're on the eMBED Home Page");
                var embedHomePageException = $"I expected ' { expectedPageTitle } ', but I saw ' { actualPageTitle } '.";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(embedHomePageException);
            }
        }
        
        public static void validateMainNavigation()
        {
            var mainNavigation = Driver.Instance.FindElement(By.Id("main-navigation"));
            
            if (mainNavigation != null) // TODO: change this to an assert of the ID, check what it actually returns first
            {
                Console.WriteLine("I found the main-navigation element by its ID");
            }
            else
            {
                Console.WriteLine("The Main Navigation element was NOT located on the page");
                var mainNavigationException = $"I expected to find the main-navigation element, but instead I got {mainNavigation} ";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(mainNavigationException);
            }
        }

    }
}
