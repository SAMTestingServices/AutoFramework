using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace HIPTargettedRegression.Helpers
{
    public class AddressList
    {
        public static string BaseURLLive
        {
            get { return  "https://my.drfoster.co.uk/"; }
        }
        public static string Testing005URL
        {
            get { return "http://testing05:50000/mbed"; }
        }

    }
}