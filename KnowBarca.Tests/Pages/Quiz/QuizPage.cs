using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class QuizPage : PageBase
    {
        public Func<AppQuery, AppQuery> QuizPageId => (e) => e.Marked("QuizPage");

        public void QuizPageOpens()
        {
            WaitFor(QuizPageId);
            Back();
        }
    }
}
