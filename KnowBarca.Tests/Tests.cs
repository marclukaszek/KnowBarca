using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace KnowBarca.Tests
{
    [TestFixture]
    public class Tests : PageBase
    {
        [TestCase(Platform.Android)]
        [Test(Description = "Check if application starts")]
        public void ApplicationStart(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.MenuExist();
            MainPage.LogoExist();
            MainPage.FooterExist();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Check if all menu page are opening")]
        public void AllPagesOpens(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.MenuExist();
            MainPage.GoToHistoryPage();
            HistoryPage.HistoryPageOpens();
            MainPage.GoToQuizPage();
            QuizPage.QuizPageOpens();
            MainPage.GoToScoreboardPage();
            ScoreboardPage.ScoreboardPageOpens();
            MainPage.GoToAuthorPage();
            AuthorPage.AuthorPageOpens();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Check if History part logic works")]
        public void CheckHistoryLogic(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.GoToHistoryPage();
            HistoryPage.GoToBeginning();
            BeginningPage.GoToBeginningTest();
            BeginningPageTest.AnswerTestWrong();
            BeginningPage.GoToBeginningTest();
            BeginningPageTest.AnswerTestCorrect();
            BeginningPageCorrect.BeginningPageCorrectOpens();
            BeginningPageCorrect.GoToNextChapter();
            StadiumPage.StadiumPageOpens();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Check if quiz logic works")]
        public void CheckQuizLogic(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.GoToQuizPage();
            QuizPage.AnswerFor6points();
            ScoreboardPage.CheckIfPlayerGet6Points();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Check if scoreboard works")]
        public void CheckScoreboardLogic(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.GoToQuizPage();
            QuizPage.AnswerFor10points();
            ScoreboardPage.CheckIfPlayerGet10Points();
            ScoreboardPage.GoBackToMenuAfterQuiz();
            MainPage.GoToQuizPage();
            QuizPage.AnswerFor0points();
            ScoreboardPage.CheckIfPlayer2Get0Points();
        }

    }
}
