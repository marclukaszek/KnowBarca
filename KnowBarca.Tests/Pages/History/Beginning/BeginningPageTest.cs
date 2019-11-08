using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class BeginningPageTest : PageBase
    {
        public Func<AppQuery, AppQuery> BeginningTestPageId => (e) => e.Marked("BeginningTestPage");
        public Func<AppQuery, AppQuery> Correct1Q => (e) => e.Marked("Bq1c");
        public Func<AppQuery, AppQuery> Wrong1Q => (e) => e.Marked("Bq1w");
        public Func<AppQuery, AppQuery> GoTo2QButton => (e) => e.Marked("Bq2n");
        public Func<AppQuery, AppQuery> Correct2Q => (e) => e.Marked("Bq2c");
        public Func<AppQuery, AppQuery> Wrong2Q => (e) => e.Marked("Bq2w");
        public Func<AppQuery, AppQuery> GoTo3QButton => (e) => e.Marked("Bq3n");
        public Func<AppQuery, AppQuery> Correct3Q => (e) => e.Marked("Bq3c");
        public Func<AppQuery, AppQuery> Wrong3Q => (e) => e.Marked("Bq3w");
        public Func<AppQuery, AppQuery> CheckAnsButton => (e) => e.Marked("BCheckAns");


        public void BeginningPageOpens()
        {
            WaitFor(BeginningTestPageId);
            Back();
        }
        public void AnswerTestWrong()
        {
            WaitFor(Wrong1Q);
            Tap(Wrong1Q);
            WaitFor(GoTo2QButton);
            Tap(GoTo2QButton);
            WaitFor(Correct2Q);
            Tap(Correct2Q);
            WaitFor(GoTo3QButton);
            Tap(GoTo3QButton);
            WaitFor(Correct3Q);
            Tap(Correct3Q);
            Tap(Wrong3Q);
            Tap(CheckAnsButton);
            AlertBox.PressOK();
            Tap(Wrong3Q);
            Tap(CheckAnsButton);
            WaitFor(AlertBox.OKButton);
            AlertBox.PressOK();
        }
        public void AnswerTesCorrect()
        {
            WaitFor(Correct1Q);
            Tap(Correct1Q);
            WaitFor(GoTo2QButton);
            Tap(GoTo2QButton);
            WaitFor(Correct2Q);
            Tap(Correct2Q);
            WaitFor(GoTo3QButton);
            Tap(GoTo3QButton);
            WaitFor(Correct3Q);
            Tap(Correct3Q);
            Tap(CheckAnsButton);
        }
    }
}
