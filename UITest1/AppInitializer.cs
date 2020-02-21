using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("D:/AppXFPrueba/AppXFPrueba/AppXFPrueba.Android/bin/Release/com.companyname.appxfprueba.apk")
                    .StartApp();
                
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}