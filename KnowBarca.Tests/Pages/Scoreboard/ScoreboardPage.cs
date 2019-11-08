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
        public Func<AppQuery, AppQuery> Player1Nickname => (e) => e.Marked("Player 1");
        public Func<AppQuery, AppQuery> Player2Nickname => (e) => e.Marked("Player 2");
        public Func<AppQuery, AppQuery> Player1Points6 => (e) => e.Marked("6");
        public Func<AppQuery, AppQuery> Player1Points10 => (e) => e.Marked("10");
        public Func<AppQuery, AppQuery> Player2Points0 => (e) => e.Marked("0");
        public void ScoreboardPageOpens()
        {
            WaitFor(ScoreboardPageId);
            Back();
        }
        public void CheckIfPlayerGet6Points()
        {
            WaitFor(Player1Nickname);
            WaitFor(Player1Points6);
        }
        public void GoBackToMenuAfterQuiz()
        {
            Back();
            Back();
        }
        public void CheckIfPlayerGet10Points()
        {
            WaitFor(Player1Nickname);
            WaitFor(Player1Points10);
        }
        public void CheckIfPlayer2Get0Points()
        {
            WaitFor(Player1Nickname);
            WaitFor(Player2Points0);
        }
    }
}
