using System;
using System.Diagnostics;

namespace DRFosterAutomationFramework.Helpers
{
    public class ReportGenerator
    {
        public static void OutputNUnitToSpecFlow()
        {
            // HACK: This entire report generation process needs refactoring to provide reports from Pickles
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            string callSpecFlow = "specflow.exe";
            string invokeNuReport = "nunitexecutionreport";
            string reportSourcePath = "\"C:\\Dev\\HIPTargetedRegression\\HIPRegressionTests\\HIPRegressionTests.csproj\"";
            string reportOutputPath = "/xmlTestResult:\"C:\\Dev\\HIPTargetedRegression\\packages\\NUnit.ConsoleRunner.3.6.0\tools\\TestResult.xml\"";

            cmd.StandardInput.WriteLine(callSpecFlow + " " + invokeNuReport + " " + reportSourcePath + " " + reportOutputPath);

            Console.WriteLine(callSpecFlow + " " + invokeNuReport + " " + reportSourcePath + " " + reportOutputPath);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

    }
}