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
        public Func<AppQuery, AppQuery> q1cor => (e) => e.Marked("q1c");
        public Func<AppQuery, AppQuery> q2cor => (e) => e.Marked("q2c");
        public Func<AppQuery, AppQuery> q3cor => (e) => e.Marked("q3c");
        public Func<AppQuery, AppQuery> q4cor => (e) => e.Marked("q4c");
        public Func<AppQuery, AppQuery> q5cor => (e) => e.Marked("q5c");
        public Func<AppQuery, AppQuery> q6cor => (e) => e.Marked("q6c");
        public Func<AppQuery, AppQuery> q7cor => (e) => e.Marked("q7c");
        public Func<AppQuery, AppQuery> q8cor => (e) => e.Marked("q8c");
        public Func<AppQuery, AppQuery> q9cor => (e) => e.Marked("q9c");
        public Func<AppQuery, AppQuery> q10cor => (e) => e.Marked("q10c");

        public Func<AppQuery, AppQuery> q1wng => (e) => e.Marked("q1w");
        public Func<AppQuery, AppQuery> q2wng => (e) => e.Marked("q2w");
        public Func<AppQuery, AppQuery> q3wng => (e) => e.Marked("q3w");
        public Func<AppQuery, AppQuery> q4wng => (e) => e.Marked("q4w");
        public Func<AppQuery, AppQuery> q5wng => (e) => e.Marked("q5w");
        public Func<AppQuery, AppQuery> q6wng => (e) => e.Marked("q6w");
        public Func<AppQuery, AppQuery> q7wng => (e) => e.Marked("q7w");
        public Func<AppQuery, AppQuery> q8wng => (e) => e.Marked("q8w");
        public Func<AppQuery, AppQuery> q9wng => (e) => e.Marked("q9w");
        public Func<AppQuery, AppQuery> q10wng => (e) => e.Marked("q10w");
        public Func<AppQuery, AppQuery> CheckAnswerButton1 => (e) => e.Marked("QAC1");
        public Func<AppQuery, AppQuery> CheckAnswerButton2 => (e) => e.Marked("QAC2");
        public Func<AppQuery, AppQuery> NicknameEntry => (e) => e.Marked("NicknameEntry");
        public void QuizPageOpens()
        {
            WaitFor(QuizPageId);
            Back();
        }
        public void AnswerFor6points()
        {
            Tap(q1wng);
            Tap(q2cor);
            ScrollScreenDown();
            Tap(q3cor);
            Tap(q4cor);
            ScrollScreenDown();
            Tap(q5wng);
            Tap(q6cor);
            ScrollScreenDown();
            Tap(q7wng);
            Tap(q8cor);
            ScrollScreenDown();
            Tap(q9wng);
            Tap(q10wng);
            Tap(q10cor);
            Tap(CheckAnswerButton1);
            ScrollScreenDown();
            EnterText(NicknameEntry, "Player 1");
            Tap(CheckAnswerButton2);
        }
        public void AnswerFor10points()
        {
            Tap(q1cor);
            Tap(q2cor);
            ScrollScreenDown();
            Tap(q3cor);
            Tap(q4cor);
            ScrollScreenDown();
            Tap(q5cor);
            Tap(q6cor);
            ScrollScreenDown();
            Tap(q7cor);
            Tap(q8cor);
            ScrollScreenDown();
            Tap(q9cor);
            Tap(q10cor);
            Tap(CheckAnswerButton1);
            ScrollScreenDown();
            EnterText(NicknameEntry, "Player 1");
            Tap(CheckAnswerButton2);
        }
        public void AnswerFor0points()
        {
            Tap(q1wng);
            Tap(q2wng);
            ScrollScreenDown();
            Tap(q3wng);
            Tap(q4wng);
            ScrollScreenDown();
            Tap(q5wng);
            Tap(q6wng);
            ScrollScreenDown();
            Tap(q7wng);
            Tap(q8wng);
            ScrollScreenDown();
            Tap(q9wng);
            Tap(q10wng);
            Tap(CheckAnswerButton1);
            ScrollScreenDown();
            EnterText(NicknameEntry, "Player 2");
            Tap(CheckAnswerButton2);
        }

    }
}
