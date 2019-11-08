using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowBarca.Tests.Pages
{
    public class PageContainer
    {
        public MainPage MainPage => new MainPage();
        public AuthorPage AuthorPage => new AuthorPage();
        public ScoreboardPage ScoreboardPage => new ScoreboardPage();
        public QuizPage QuizPage => new QuizPage();
        public HistoryPage HistoryPage => new HistoryPage();
        public BeginningPage BeginningPage => new BeginningPage();
        public BeginningPageTest BeginningPageTest => new BeginningPageTest();
        public AlertBox AlertBox => new AlertBox();
        public BeginningPageCorrect BeginningPageCorrect => new BeginningPageCorrect();
        public StadiumPage StadiumPage => new StadiumPage();
    }
}
