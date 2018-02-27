using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace UITestMobile
{
    public class AppInitializer
    {
        private static IApp _app;
        public static AppInitializer _currentInstance;


        public AppInitializer(Platform platform)
        {
            if (platform == Platform.Android)
            {
                _app = ConfigureApp
                .Android
                .ApkFile($"{ AppDomain.CurrentDomain.BaseDirectory}..\\..\\..\\packages\\test.apk")
                .StartApp();             
            }
        }

        public static AppInitializer GetInstance(Platform platform) => _currentInstance ?? (_currentInstance = new AppInitializer(platform));

        public static IApp GetApp()
        {
            return _app;
        }

        public static void CloseApp()
        {
            _currentInstance = null;
            _app = null;

        }
    }
}

