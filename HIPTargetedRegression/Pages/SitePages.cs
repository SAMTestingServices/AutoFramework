using HIPTargettedRegression.Common;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIPTargettedRegression.Pages
{
    public static class SitePages
    {
        private static T GetPage<T>() where T : new()
            {
                var page = new T();
                PageFactory.InitElements(Driver.Instance, page);
                return page;
            }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

    }
}