using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

// TODO: Custom selectors not currently used as all standard selenium selectors are working for the framework

namespace DRFosterAutomationFramework.Helpers
{
    public class ToolExtensions
    {

        private static SelectElement select;

        static ToolExtensions()
        {
            select = null;
        }

        public static void SelectByText(IWebElement element, String text)
        {
            select = new SelectElement(element);
            select.SelectByText(text);
        }

    }
}