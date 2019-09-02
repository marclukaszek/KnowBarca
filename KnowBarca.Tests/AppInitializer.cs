using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.yama.knowbarca")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}