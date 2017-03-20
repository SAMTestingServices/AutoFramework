using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.eMBED_Pages.eMBED_Elements;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;

// Page presented to a user post log-in

namespace DRFosterAutomationFramework.eMBED_Pages
{
   public class eMBEDDashboardPage : Extensions
    {
        public static void validateTopBarNavigationIsPresent()
        {
            bool topNavIdName = Driver.Instance.PageSource.Contains("container-fluid navbar-fixed-top navigation-container");
            if (topNavIdName == true)
            {
                Console.WriteLine($"The check for Nav Container CSS being present came back as:{topNavIdName}"); 
            }
            else
            {
                var topBarNavigationException = $"The check for ID 'logo' being present came back as: {topNavIdName.ToString().ToUpper()} but I expected TRUE";
                TakeScreenshot.SaveScreenshot();
                throw new Exception(topBarNavigationException);
            }
        }

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

        public static void TopNavigationLinksURLCheck()
        {
            Console.WriteLine("-------------------");
            int i = 1;
            char let = 'a';
            foreach (var item in eMBEDDashboardPageItems.TabLinkURL.Values)
            {
                Console.WriteLine($"     {i}{let}: I expected {item}");

                bool matchingItemInThePageSource = Driver.Instance.PageSource.Contains(item);
                if (matchingItemInThePageSource == true)
                {
                    Console.WriteLine($"         {i}{let}: In the page source I saw {item}");
                    Console.WriteLine("-------");
                    i++;
                    let++;
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

//------------
        public static void TopNavigationLinkTextCheck()
        {
            //Get all the links from the webpage, whether they have link-text on the screen or not
            var locateTheLinkSection = Driver.Instance.FindElement(By.XPath("//ul[@class='nav nav-tabs']"));
            var setOfLinksOnThePage = locateTheLinkSection.FindElements(By.TagName("a"));

            List<string> onPageLinkList = new List<string>();

            int i = 1;
            foreach (var item in setOfLinksOnThePage)
            {
               // Console.WriteLine("The following link text was displayed on the page");
                if (item.Displayed)
                {
                    onPageLinkList.Add(item.Text);
                    Console.WriteLine($"     {i}: {item.Text}");
                }

                //Console.WriteLine("The following are in the code, but not displayed on the page");
                if (!item.Displayed)  
                {
                    Console.WriteLine($"     {i}: There was also a link for: {item}, but no link text was displayed");
                }
                i++;
            }

            //------------

            Console.WriteLine("-----------------------------");
            Console.WriteLine("The text links set on the page are:");
            int a = 1;
            foreach (var link in onPageLinkList)
            {
                Console.WriteLine($"     {a}: {link}");
                a++;
            }

        }

    }

}