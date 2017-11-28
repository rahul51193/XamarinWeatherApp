using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XamarinWeatherApp
{
    class Common
    {
        public static string API_KEY = "26bb87e0da5c30cf2dd007b1bab61409";
        public static string API_LINK = "http://api.openweathermap.org/data/2.5/weather";

        public static string APIRequest (string lat, string lang)
        {
            StringBuilder sb = new StringBuilder(API_LINK);
            sb.AppendFormat("?lat={0}&lon={l} &APPID={2} &units=metric");
            return sb.ToString();
        }

        public static DateTime  UnixTimeToDateStamp(double UnixTimeStamp)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(UnixTimeStamp).ToLocalTime();
            return dt;
        }

        public static string GetImage(string icon)
        {
            return $"http://openweathermap.org/img/w/{icon}.png";
        }

    }
}