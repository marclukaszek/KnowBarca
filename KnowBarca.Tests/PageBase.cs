using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using NUnit.Framework;
using Xamarin.UITest.Queries;
using KnowBarca.Tests.Pages;
using System.Runtime.CompilerServices;
using KnowBarca.Tests;

namespace KnowBarca.Tests
{
    class Driver : AppInitializer
    {
        public static IApp app { get; set; }

        public static bool Initialize(Platform platform, [CallerMemberName] string testMethodName = null)
        {
            string androidpath = @"..\..\..\KnowBarca\KnowBarca.Android\bin\Release\com.yama.knowbarca.apk";
            if (platform == Platform.Android)
            {
                app = ConfigureApp.Android.ApkFile(androidpath).StartApp();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
    public class PageBase : PageContainer
    {

        protected void Tap(Func<AppQuery, AppQuery> query)
        {
            WaitFor(query);
            Driver.app.Tap(query);
        }

        protected void WaitFor(Func<AppQuery, AppQuery> query)
        {
            Driver.app.WaitForElement(query);
        }

        protected void EnterText(Func<AppQuery, AppQuery> query, string text)
        {
            WaitFor(query);
            Driver.app.EnterText(query, text);
            Driver.app.DismissKeyboard();
        }

        protected void Back()
        {
            Driver.app.Back();
        }
        protected void ScrollScreenDown()
        {
            Driver.app.DragCoordinates(200, 1150, 200, 40);
        }
    }
}
