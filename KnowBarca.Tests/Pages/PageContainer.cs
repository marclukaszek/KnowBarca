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
    }
}
