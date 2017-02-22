using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using System;
using DRFosterAutomationFramework.eMBED_Pages.eMBED_Elements;

// Page presented to a user post log-in

namespace DRFosterAutomationFramework.eMBED_Pages
{
   public class eMBEDDashboardPage
    {
        public static void validateMainNavigationIsPresent()
        {
            var mainNavigation = Driver.Instance.FindElement(By.Id("main-navigation"));

            if (mainNavigation != null) // TODO: change this to an assert of the ID? Check what it actually returns first
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

        public static void confirmDashboardTopLinksAreCorrect()
        {
            // TODO: If the Dictionary/Enum approach works, iterate over the others
            var actualSarValue = Driver.Instance.FindElement(By.LinkText("SAR")).ToString();
            var ExpectedSarValue = eMBEDDashboardPageItems.TabLinkName[eMBEDNavigation.SAR].ToString();

            if (actualSarValue == ExpectedSarValue)
            {
                Console.WriteLine("As expected, I saw '" + ExpectedSarValue + "' in the top navigation.");
            }
            else
            {
                Console.WriteLine("I could NOT confirm we're on the eMBED Home Page");
                var topNavigationException = $"I expected ' { ExpectedSarValue } ', but I saw ' { actualSarValue } '.";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(topNavigationException);
            }

        }
    }
}