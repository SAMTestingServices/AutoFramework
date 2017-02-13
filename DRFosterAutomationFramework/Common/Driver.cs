using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Drawing;

namespace DRFosterAutomationFramework.Common
{
   
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        // ############ Dynamic selection of the web browser #############
     
        public static void LaunchTheBrowser(string browser)
        {
            switch (browser.ToLower())
            {
                case "firefox":
                   Instance = initialiseFirefox();
                    Console.WriteLine("Firefox WebDriver was started.");
                    break;
                case "ie":
                    Instance = initialiseIE();
                    Console.WriteLine("IE 11 WebDriver was started.");
                    break;
                case "chrome":
                    Instance = initialiseChrome();
                    Console.WriteLine("Chrome WebDriver was started.");
                    break;
                default:
                    Console.WriteLine(browser + " is not recognised, so the default of Firefox WebDriver was launched instead.");
                    Instance = initialiseFirefox();
                    break;
            }
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Instance.Manage().Window.Size = new Size(1015, 1300);
        }

// ############ After LaunchTheBrowser() runs, an Instance of the chosen browser is initialised #############

        private static IWebDriver initialiseFirefox()
        {
            Instance = new FirefoxDriver();
            return Instance;
        }

        private static IWebDriver initialiseIE()
        {
            Instance = new InternetExplorerDriver();
            return Instance;
            // MarkCTest: IE 11 may behave inconsistently as at Jan 2016 due to a change by Microsoft
        }

        private static IWebDriver initialiseChrome()
        {
            Instance = new ChromeDriver();
            return Instance;
        }

        // ############  Close the browser / Quit the Driver instance / Clear the Cookies  #############

        public static void ClearCookies()
        {
            // TODO: Clear the cookies from only the site under test?
            // then validate the cookies really were cleared
            Instance.Manage().Cookies.DeleteAllCookies();
            Console.WriteLine("Cookies were cleared from the browser cache.");
        }

        public static void Close()
        {
            // TODO: Change to check the browser window title, close it, then check the browser window is no longer open
            Instance.Close();

            //var instanceCheck = Instance.ToString();
            //if (instanceCheck == null)
            //{
            //    Console.WriteLine("The Browser window was closed.");
            //}
            //else
            //{
            //    Console.WriteLine("The Browser window was NOT closed, I got '" + instanceCheck + "' as the result.");
            //}
        }

        public static void Quit()
        {
            Instance.Quit();

            // HACK: This seems unstable, research an alternate way to get status
            var instanceCheck = Instance.ToString();
            if (instanceCheck == null)
            {
                Console.WriteLine("The WebDriver Instance was Quit.");
            }
            else
            {
                Console.WriteLine("The WebDriver Instance may NOT have quit, I got '" + instanceCheck + "' as the result.");
            }
        }

    }
}