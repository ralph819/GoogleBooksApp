using System;
using System.IO;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace GoogleBookApp.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            var path = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            
            if (platform == Platform.Android)
            {
                var apkPath = Path.Combine(path, "GoogleBookApp/GoogleBookApp.Android/bin/Release/com.ralph819.googlebookapp.apk");
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .ApkFile(apkPath)
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}