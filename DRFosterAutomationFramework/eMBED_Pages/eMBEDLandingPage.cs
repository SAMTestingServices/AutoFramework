using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.Helpers;
using System;

namespace DRFosterAutomationFramework.eMBED_Pages
{
    public class eMBEDLandingPage
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

    }
}
