using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.eMBED_Pages.eMBED_Elements;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

// Page presented to a user post log-in

namespace DRFosterAutomationFramework.eMBED_Pages
{
   public class eMBEDDashboardPage : Extensions
    {

        // ---------------------------------------------------------------------------------------------------

        public static void validateTopBarNavigationIsPresent()
        {
            //This method checks for a SINGLE element on the page, namely the container of the navigation links
            bool topNavIdName = Driver.Instance.PageSource.Contains("container-fluid navbar-fixed-top navigation-container");
            if (topNavIdName == true)
            {
                Console.WriteLine($"The check for Nav Container CSS being present came back as: {topNavIdName}/n"); 
            }
            else
            {
                var topBarNavigationException = $"The check for ID 'logo' being present came back as: {topNavIdName.ToString().ToUpper()} but I expected TRUE";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(topBarNavigationException); 
            }
        }

        // ------------------------------------------------------------------------------------------------------------
        // This method checks for MULTIPLE items of the same type being present on the page, compared to an IDictionary

        public static void validateTopBarNavigationElements()
        {
            Console.WriteLine("----- Top Bar Navigation Elements -----");
            foreach (var item in eMBEDDashboardPageItems.NavElementName.Values)
            {
                if (IsElementPresent(By.Id(item)))
                {
                    Console.WriteLine($"As expected, I saw an element with the ID of: {item}");
                }
                else
                {
                    Console.WriteLine($"I could NOT locate an element with the ID of: {item}");
                    TakeScreenshot.SaveScreenshot();
                    var pageNavigationElementException = $"I expected {item} but it was not located";
                    throw new Exception(pageNavigationElementException);
                }

            }
        }

        // ---------------------------------------------------------------------------------------------------
        // Check for MULTIPLE text links on the top navigation area of the dashboard page 

        public static void confirmDashboardTabLinksAreCorrect()
        {
            foreach (var tabitem in eMBEDDashboardPageItems.TabLinkText.Values)
            {
                if (IsElementPresent(By.LinkText(tabitem)))
                {
                    Console.WriteLine($"As expected, I saw: {tabitem}");
                }
                else
                {
                    Console.WriteLine($"I could NOT locate the item: {tabitem}");
                    TakeScreenshot.SaveScreenshot();
                    var pageNavigationElementException = $"I expected {tabitem} but it was not located";
                    throw new Exception(pageNavigationElementException);
                }
            }
        }

        // ---------------------------------------------------------------------------------------------------
        // Check a list of known URLs against what appear in the code on the page - are they the same?

        public static void TopNavigationLinksURLCheck()
        {
            Console.WriteLine("-------------------");
            int index = 1;
            char letter = 'a';
            foreach (var item in eMBEDDashboardPageItems.TabLinkURL.Values)
            {
                Console.WriteLine($"     {index}{letter}: I expected {item}");

                bool matchingItemInThePageSource = Driver.Instance.PageSource.Contains(item);
                if (matchingItemInThePageSource == true)
                {
                    Console.WriteLine($"         {index}{letter}: In the page source I saw {item}");
                    Console.WriteLine("-------");
                    index++;
                    letter++;
                }
                else
                {
                    Console.WriteLine($"FAIL as I saw {matchingItemInThePageSource} and could NOT locate the item: {item}");
                    TakeScreenshot.SaveScreenshot();
                    var pageNavigationElementException = $"I expected {item} but it was not located";
                    throw new Exception(pageNavigationElementException);
                }
            }
        }

        // ---------------------------------------------------------------------------------------------------
        // Check what text links are visible on the page and which are not displayed - is this correct for the user?

        public static void TopNavigationLinkTextCheck()
        {
            //Get all the links from the webpage, whether they have link-text on the screen or not
            var locateTheLinkSection = Driver.Instance.FindElement(By.XPath("//ul[@class='nav nav-tabs']"));
            var setOfLinksOnThePage = locateTheLinkSection.FindElements(By.TagName("a"));

            List<string> onPageLinkList = new List<string>();

            int index = 1;
            foreach (var item in setOfLinksOnThePage)
            {
               // Console.WriteLine("The following link text was displayed on the page");
                if (item.Displayed)
                {
                    onPageLinkList.Add(item.Text);
                    Console.WriteLine($"     {index}: {item.Text}");
                }

                //Console.WriteLine("The following are in the code, but not displayed on the page");
                if (!item.Displayed)  
                {
                    Console.WriteLine($"     {index}: There was also a link for: {item}, but no link text was displayed");
                }
                index++;
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("The text links set on the page are:");
            int a = 1;
            foreach (var link in onPageLinkList)
            {
                Console.WriteLine($"     {a}: {link}");
                a++;
            }

            // TODO: Now do a comparison between the two to make sure this visible set is as expected

        }

        // ---------------------------------------------------------------------------------------------------
        // Find, activate and validate the functionality of the search panel

        public static void validateSearchFilter()
        {
            var filterLink = Driver.Instance.FindElement(By.LinkText("FILTER"));

            if (filterLink.Displayed == true)
            {
                Console.WriteLine("Filter link was found on the page");

                System.Threading.Thread.Sleep(9000); //HACK: Hard coded wait - Replace with something more dynamic
                filterLink.Click();

                // Wait for the Filter panel to come into view
                System.Threading.Thread.Sleep(2000);

                // XPath locations for each Dropdown
                var fromMonthDropdown = Driver.Instance.FindElement(By.XPath("//select"));
                var fromYearDropdown = Driver.Instance.FindElement(By.XPath("//div[2]/select"));
                var toMonthDropdown = Driver.Instance.FindElement(By.XPath("//div[2]/div/select"));
                var toYearDropdown = Driver.Instance.FindElement(By.XPath("//div[2]/div[2]/select"));

                // Values to choose fromm the Dropdowns
                var fromMonthValue = "March";
                var fromYearValue = "2016";
                var toMonthValue = "November";
                var toYearValue = "2016";

                // Select the FROM Month and Year
                new SelectElement(fromMonthDropdown).SelectByText(fromMonthValue);
                new SelectElement(fromYearDropdown).SelectByText(fromYearValue);

                // Select the TO Month and Year
                new SelectElement(toMonthDropdown).SelectByText(toMonthValue);
                new SelectElement(toYearDropdown).SelectByText(toYearValue);

                // Click the Apply button
                Driver.Instance.FindElement(By.XPath("//div[2]/button")).Click();

                //Wait for the selection to appear on the page
                System.Threading.Thread.Sleep(2000);

                // Click the Secondary Care Indicators panel
                Driver.Instance.FindElement(By.XPath("//div/i")).Click();
                
            }
            else
            {
                Console.WriteLine($"FAIL as I did not see the FILTER link on the page");
                //TakeScreenshot.SaveScreenshot();
                var pageElementDisplayed = $"I expected to see the FILTER link but it was not located";
                throw new Exception(pageElementDisplayed);
            }

            //-------------------------------------------------------------------------
        }

        public static void printToFile()
        {
            FileReadAndWrite.fileWriter();
        }

    }

}