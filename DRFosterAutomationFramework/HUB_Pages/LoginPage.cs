using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using System;

namespace DRFosterAutomationFramework.HUB_Pages
{
    public class LoginPage
    {

        public static void GoToHomePage()
        {
            Driver.Instance.Navigate().GoToUrl(AddressList.BaseURLLive); //ListOfSiteURLs.cs
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public static void CheckWeHitTheRightPage()
        {
            var homepageWelcomeMessage = Driver.Instance.FindElement(By.CssSelector("div.zone.zone-content > h1")).Text;
            var expectedHomePageText = "Welcome to My Dr Foster UK";

            if (homepageWelcomeMessage == expectedHomePageText)
            {
                Console.WriteLine("As expected, I saw '" + homepageWelcomeMessage + "' on the home page.");
            }
            else
            {
                Console.WriteLine("I could NOT confirm we're on the Home Page");
                var homePageException = $"I expected ' {expectedHomePageText} ', but I saw ' { homepageWelcomeMessage } '.";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(homePageException);
            }

        }

        public static void ValidateWeGotLoggedIn()
        {
            var loggedinText = Driver.Instance.FindElement(By.PartialLinkText("Sign out")).Text;
            var expectedLoggedinText = "Sign out";

            if (loggedinText == expectedLoggedinText)
            {
                Console.WriteLine("As expected, I saw '" + expectedLoggedinText + "' text link once logged in.");
            }
            else
            {
                Console.WriteLine("I could NOT confirm we're logged in.");
                var loggedInException = $"I expected '{expectedLoggedinText}' but couldn't find it.";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(loggedInException);
            }
        }

        public static void DoLogin()
        {
            var loginButton = Driver.Instance.FindElement(By.ClassName("btn"));
            loginButton.Click();
        }
    }

    public class LoginCommand
    {
        private string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void EnterLoginDetails()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("username-email"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("password"));
            passwordInput.SendKeys(password);
        }

    }

}