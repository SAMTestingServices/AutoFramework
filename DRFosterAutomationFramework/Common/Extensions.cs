using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

// Methods to extend Selenium functionality

namespace DRFosterAutomationFramework.Common
{
    public static class Extensions
    {
        private const int DefaultSleepBeforeRetrySpeed = 50;

        public static void WaitForPageToLoad()
        {
            for (int i = 0; i < 400; i++) // HACK: Refactor WaitForPageToLoad as this is essentially an explicit wait
            {
                var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(60));
                wait.Until((wdriver) => (wdriver as IJavaScriptExecutor)
                .ExecuteScript("return document.readyState")
                .Equals("complete"));
            }
        }
    }
}