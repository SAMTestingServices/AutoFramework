using System.Collections.Generic;

namespace DRFosterAutomationFramework.eMBED_Pages.eMBED_Elements
{
    public static class eMBEDDashboardPageItems
    {
        public const string Logo = "DR Foster Logo";

        public const string CIM = "COMMISSIONING INSIGHT MANAGER";

        public const string Welcome = "Welcome";

        public const string SignOut = "/logoff";

        public const string OrgSelector = "org-selector";

        public const string Filter = "FILTER";

        public static IDictionary<eMBEDNavigation, string> TabLinkName
            = new Dictionary<eMBEDNavigation, string>
              {
                    { eMBEDNavigation.SAR, "SAR" },
                    { eMBEDNavigation.RiskStratification, "Risk Stratification" },
                    { eMBEDNavigation.GPOS, "GPOS" },
                    { eMBEDNavigation.Performance, "Performance"}
              };

        public const string SecondaryCareIndicators = "Secondary Care Indicators";

        public const string SarByAcs = "SAR by ACS";

        public const string SarByDiagnosis = "SAR by Diagnosis";

        public const string Alerting = "Alerting";
    }

}