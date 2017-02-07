using HIPTargettedRegression.Common;
using OpenQA.Selenium;
using System;
using System.Drawing.Imaging;

namespace HIPTargettedRegression.Helpers
{
    class TakeScreenshot
    {

        public static Screenshot TakeScreenShot()
        {
            return ((ITakesScreenshot)Driver.Instance).GetScreenshot();
        }

        public static void SaveScreenshot()
        {
            try
            {
                var dateNow = DateTime.Now.Date.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "");
                dateNow = dateNow.Substring(0, 8);

                var timeNow = DateTime.Now.TimeOfDay.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "").Replace(@".", "");
                timeNow = timeNow.Substring(0, 6);

                var fileName = String.Format("C:\\Dev\\HIPTargetedRegression\\TestResults\\Screenshots\\{0}_{1}.png", dateNow, timeNow);
                Console.WriteLine("The screenshot was taken. Please check in the Screenshots folder for: {0}", fileName);

                var screenShot = TakeScreenShot();

                screenShot.SaveAsFile(fileName, ImageFormat.Png);

            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("I couldn't create the screenshot because of the following error: {0} ", e));
            }
        }

    }
}