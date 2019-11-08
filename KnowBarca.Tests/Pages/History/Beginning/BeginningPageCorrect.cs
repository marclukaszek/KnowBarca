using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class BeginningPageCorrect : PageBase
    {
        public Func<AppQuery, AppQuery> BeginningPageCorrectId => (e) => e.Marked("BeginningPageCorrect");
        public Func<AppQuery, AppQuery> NextChapterButton => (e) => e.Marked("GoStadiumButton");


        public void BeginningPageCorrectOpens()
        {
            WaitFor(BeginningPageCorrectId);
            Back();
        }
        public void GoToNextChapter()
        {
            WaitFor(NextChapterButton);
            Tap(NextChapterButton);
        }
    }
}
