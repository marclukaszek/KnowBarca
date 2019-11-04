using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace KnowBarca.Tests.Pages
{
    public class MainPage : PageBase
    {
        public Func<AppQuery, AppQuery> Logo => (e) => e.Marked("Logo");
        public Func<AppQuery, AppQuery> Menu => (e) => e.Marked("MenuFrame");
        public Func<AppQuery, AppQuery> Footer => (e) => e.Marked("Footer");
        public Func<AppQuery, AppQuery> HistoryButton => (e) => e.Marked("HistoryButton");
        public Func<AppQuery, AppQuery> QuizButton => (e) => e.Marked("QuizButton");
        public Func<AppQuery, AppQuery> ScoreboardButton => (e) => e.Marked("ScoreboardButton");
        public Func<AppQuery, AppQuery> AuthorButton => (e) => e.Marked("AuthorButton");

        public void LogoExist()
        {
            WaitFor(Logo);
        }

        public void MenuExist()
        {
            WaitFor(Menu);
        }
        public void FooterExist()
        {
            WaitFor(Footer);
        }
        public void GoToHistoryPage()
        {
            WaitFor(HistoryButton);
            Tap(HistoryButton);
        }
        public void GoToQuizPage()
        {
            WaitFor(QuizButton);
            Tap(QuizButton);
        }
        public void GoToScoreboardPage()
        {
            WaitFor(ScoreboardButton);
            Tap(ScoreboardButton);
        }
        public void GoToAuthorPage()
        {
            WaitFor(AuthorButton);
            Tap(AuthorButton);
        }
    }
}
