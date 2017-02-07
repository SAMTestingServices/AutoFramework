using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIPTargettedRegression.Helpers
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
