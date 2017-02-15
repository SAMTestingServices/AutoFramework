using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using System;

namespace DRFosterAutomationFramework.eMBED_Pages
{
   public class eMBEDDashboardPage
    {
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
