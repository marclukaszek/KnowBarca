using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class ScoreboardPage : PageBase
    {
        public Func<AppQuery, AppQuery> ScoreboardPageId => (e) => e.Marked("ScoreboardPage");

        public void ScoreboardPageOpens()
        {
            WaitFor(ScoreboardPageId);
            Back();
        }
    }
}
