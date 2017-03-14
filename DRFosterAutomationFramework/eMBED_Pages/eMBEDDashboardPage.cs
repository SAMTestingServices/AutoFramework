using DRFosterAutomationFramework.Common;
using DRFosterAutomationFramework.eMBED_Pages.eMBED_Elements;
using DRFosterAutomationFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

// Page presented to a user post log-in

namespace DRFosterAutomationFramework.eMBED_Pages
{
   public class eMBEDDashboardPage : Extensions
    {
        public static void validateTopBarNavigationIsPresent()
        {
            bool topNavIdName = Driver.Instance.PageSource.Contains(eMBEDDashboardPageItems.NavElementName[eMBEDTopNavElements.Logo]);

            if (topNavIdName == true)
            {
                Console.WriteLine($"The check for ID of 'logo' being present came back as: {topNavIdName.ToString().ToUpper()}");
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
                    Console.WriteLine($"As expected, I saw and element with the ID of: {item}");
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

        public static void TopNavigationLinksCheck()
        // THIS IS JUST A TEST OF HOW TO CHECK FOR DIFFERENCES IN LINK SETS ON THE PAGE
        {

            // Get all of the known links from our enum/dictionary in eMBEDNavigation.cs
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The links in our known set are:");
            int i = 1;
            foreach (var item in eMBEDDashboardPageItems.TabLinkURL.Keys)
            {
                Console.WriteLine($"     {i}: {item}");
                i++;
            }

            //Then get the links from the webpage
            var locateTheLinkSection = Driver.Instance.FindElement(By.XPath("//ul[@class='nav nav-tabs']"));
            var actuaLinkSetCount = locateTheLinkSection.FindElements(By.TagName("a"));

            List<string> actualLinkList = new List<string>();

            foreach (var item in actuaLinkSetCount)
            {
                if (item.Displayed)
                {
                    actualLinkList.Add(item.Text);
                }

                if (!item.Displayed)
                {
                    Console.WriteLine($"There was also a link for:{0}, but no link text was displayed", item.Text);
                }
            }

            //var someContentOnThePage = Driver.Instance.PageSource.Contains("");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("The links set on the page are:");
            int a = 1;
            foreach (var link in actualLinkList)
            {
                Console.WriteLine($"     {a}: {link}");
                a++;
            }
        }

    }

}