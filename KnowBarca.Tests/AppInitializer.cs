using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            string path = @"....\KnowBarca\KnowBarca.Android\bin\Release\com.yama.knowbarca.apk";

            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile(path)
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}