using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class BeginningPage : PageBase
    {
        public Func<AppQuery, AppQuery> BeginningPageId => (e) => e.Marked("BeginningPage");
        public Func<AppQuery, AppQuery> TestButton => (e) => e.Marked("BeginningTestButton");


        public void BeginningPageOpens()
        {
            WaitFor(BeginningPageId);
            Back();
        }
        public void GoToBeginningTest()
        {
            Driver.app.ScrollDown();
            WaitFor(TestButton);
            Tap(TestButton);
        }
    }
}
