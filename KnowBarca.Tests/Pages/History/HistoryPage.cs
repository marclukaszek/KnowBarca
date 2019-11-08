using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class HistoryPage : PageBase
    {
        public Func<AppQuery, AppQuery> HistoryPageId => (e) => e.Marked("HistoryPage");
        public Func<AppQuery, AppQuery> GoToBeginningButton => (e) => e.Marked("StartBeginningButton");

        public void HistoryPageOpens()
        {
            WaitFor(HistoryPageId);
            Back();
        }
        public void GoToBeginning()
        {
            WaitFor(GoToBeginningButton);
            Tap(GoToBeginningButton);
        }
    }
}
