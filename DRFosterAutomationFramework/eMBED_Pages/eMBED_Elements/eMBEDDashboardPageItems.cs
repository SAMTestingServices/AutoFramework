using System.Collections.Generic;

namespace DRFosterAutomationFramework.eMBED_Pages.eMBED_Elements
{
    public class eMBEDDashboardPageItems
    {
        // Top Navigation elements in container-fluid class

        public static IDictionary<eMBEDTopNavElements, string> NavElementName
           = new Dictionary<eMBEDTopNavElements, string>
            {
                    { eMBEDTopNavElements.Logo, "logo" },
                    { eMBEDTopNavElements.ApplicationName, "application-name" },
                    { eMBEDTopNavElements.Welcome, "welcome" },
                    { eMBEDTopNavElements.OrgSelector, "org-selector" }
            };

        public static IDictionary<eMBEDTopNavLinks, string> LinkTextandLocation
            = new Dictionary<eMBEDTopNavLinks, string>
            {
                    { eMBEDTopNavLinks.LogoLink, "http://testing05/" },
                    { eMBEDTopNavLinks.LogoText, "" },
                    { eMBEDTopNavLinks.CIMLink, "http://testing05:50000/mbed" },
                    { eMBEDTopNavLinks.CIMText, "COMMISSIONING INSIGHT MANAGER" },
                    { eMBEDTopNavLinks.UsernameLink, "http://testing05/profile/mcrowther" },
                    { eMBEDTopNavLinks.SignoutLink, "http://testing05/users/account/logoff" },
                    { eMBEDTopNavLinks.OrgSelectorLink, "" }
            };

//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public static IDictionary<string, string> someNameHere
            = new Dictionary<string, string>
            {
                { "COMMISSIONING INSIGHT MANAGER","http://testing05:50000/mbed" }
            };
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        // Second set of links in nav-wrapper class

        public const string Filter = "FILTER";

        public static IDictionary<eMBEDNavigation, string> TabLinkText
            = new Dictionary<eMBEDNavigation, string>
              {
                    { eMBEDNavigation.SAR, "SAR" },
                    { eMBEDNavigation.RiskStratification, "Risk Stratification" },
                    { eMBEDNavigation.RiskOverview, "Risk Overview" },
                    { eMBEDNavigation.RiskStratificationOverview, "Risk Stratification" },
                    { eMBEDNavigation.GPOS, "GPOS" },
                    { eMBEDNavigation.Performance, "Performance" }
              };

        public static IDictionary<eMBEDNavigation, string> TabLinkURL
            = new Dictionary<eMBEDNavigation, string>
              {
                    { eMBEDNavigation.SAR, "#/performance" },
                    { eMBEDNavigation.RiskStratification, "#/riskstratification" },
                    { eMBEDNavigation.RiskOverview, "#/riskstratificationoverview" },
                    { eMBEDNavigation.RiskStratificationOverview, "#/riskstratification" },
                    { eMBEDNavigation.GPOS, "#/gpos" },
                    { eMBEDNavigation.Performance, "mbed/performance" }
              };

        // #####################################################################################################

        // Main content area with ID of main

        public const string SecondaryCareIndicators = "Secondary Care Indicators";
        public const string SarByAcs = "SAR by ACS";
        public const string SarByDiagnosis = "SAR by Diagnosis";
        public const string Alerting = "Alerting";

    }

}