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
        [Test(Description = "Chech if application starts")]
        public void ApplicationStart(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.MenuExist();
            MainPage.LogoExist();
            MainPage.FooterExist();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Chech if application starts")]
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
        /*
        [TestCase(Platform.Android)]
        [Test(Description = "Chech if application starts")]
        public void HistoryPartWorks(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.MenuExist();
            MainPage.LogoExist();
            MainPage.FooterExist();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Chech if application starts")]
        public void QuizPartWorks(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.MenuExist();
            MainPage.LogoExist();
            MainPage.FooterExist();
        }
        [TestCase(Platform.Android)]
        [Test(Description = "Chech if application starts")]
        public void ScoreboardWorks(Platform platform)
        {
            if (!Driver.Initialize(platform)) return;
            MainPage.MenuExist();
            MainPage.LogoExist();
            MainPage.FooterExist();
        }*/
    }
}
