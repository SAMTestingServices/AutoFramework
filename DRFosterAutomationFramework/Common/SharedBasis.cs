using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DRFosterAutomationFramework.Common
{
    [TestClass]
    public class SharedBasis
    {
        [TestInitialize]
        public void StartDriverAndLaunchTheBrowser()
        {
            var chosenBrowser = Browser.Firefox;
            Driver.LaunchTheBrowser(chosenBrowser.ToString());
            Console.WriteLine("I launched the {0} browser", chosenBrowser);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Console.WriteLine("Test Cleanup was called.");
            
            // TODO: Report generation needs putting in place to produce Pickles docs
            // ReportGenerator.OutputNUnitToSpecFlow();

            // Driver.ClearCookies();
            // Driver.Close();
            Driver.Quit();
        }
    }
}