using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestCalc
{
    public class AppInitializer
    {
        public static string ApkPath = @"C:\Users\ahmed\Desktop\AndroidDB.Android.apk";
        public static string AppPath = "";
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("SharedCalc.Android")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .AppBundle(AppPath)
                .StartApp();
        }
    }
}

