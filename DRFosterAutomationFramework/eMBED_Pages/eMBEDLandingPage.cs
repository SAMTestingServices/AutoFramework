using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.Helpers;
using System;
using OpenQA.Selenium;

// Navigate to the eMBED log-in page, do the log-in and confirm we end up at the right page.

namespace DRFosterAutomationFramework.eMBED_Pages
{
    public class eMBEDLandingPage
    {
        public static void GoToEmbedHomePage()
        {
            Driver.Instance.Navigate().GoToUrl(AddressList.embedTestUrl);
        }

        public static void EnterLoginDetails()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("username-email"));
            loginInput.SendKeys(UserList.eMBED005Username);

            var passwordInput = Driver.Instance.FindElement(By.Id("password"));
            passwordInput.SendKeys(UserList.eMBED005Password);
        }

        public static void DoLogin()
        {
            var loginButton = Driver.Instance.FindElement(By.ClassName("btn"));
            loginButton.Click();
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