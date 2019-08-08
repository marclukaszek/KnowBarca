using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Classes;

namespace KnowBarca.Pages.Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        int scorev = 0;

        public QuizPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");

        }

        async void QuizSolved(object sender, EventArgs e)
        {
            scorev = 0;
            Mark();
            string istr = scorev.ToString();
            nicknameFrame.IsVisible = true;
            nicknameEntry.IsVisible = true;
            nicknameLabel.IsVisible = true;
            QS1.IsVisible = false;
            QS2.IsVisible = true;
            //await DisplayAlert("Twój wynik to: ", istr+"/3", "OK");
        }
        void QuizSolved2(object sender, EventArgs e)
        {
            Score score = new Score()
            {
                Nickname = nicknameEntry.Text,
                ScoreVal = scorev
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Score>();
                int rowsAdded = conn.Insert(score);
            }
        }

        public int Mark()
        {
            if (c1.IsChecked)
                scorev++;
            if (c2.IsChecked)
                scorev++;
            if (c3.IsChecked)
                scorev++;


            return scorev;
        }

        private void W1_CheckChanged(object sender, EventArgs e)
        {
            w1.IsChecked = true;
            c1.IsChecked = false;
            ww1.IsChecked = false;
        }

        private void Ww1_CheckChanged(object sender, EventArgs e)
        {
            w1.IsChecked = false;
            c1.IsChecked = false;
            ww1.IsChecked = true;
        }

        private void C1_CheckChanged(object sender, EventArgs e)
        {
            w1.IsChecked = false;
            c1.IsChecked = true;
            ww1.IsChecked = false;
        }

        private void C2_CheckChanged(object sender, EventArgs e)
        {
            w2.IsChecked = false;
            c2.IsChecked = true;
            ww2.IsChecked = false;
        }

        private void W2_CheckChanged(object sender, EventArgs e)
        {
            w2.IsChecked = true;
            c2.IsChecked = false;
            ww2.IsChecked = false;
        }

        private void Ww2_CheckChanged(object sender, EventArgs e)
        {
            w2.IsChecked = false;
            c2.IsChecked = false;
            ww2.IsChecked = true;
        }

        private void W3_CheckChanged(object sender, EventArgs e)
        {
            w3.IsChecked = true;
            c3.IsChecked = false;
            ww3.IsChecked = false;
        }

        private void Ww3_CheckChanged(object sender, EventArgs e)
        {
            w3.IsChecked = false;
            c3.IsChecked = false;
            ww3.IsChecked = true;
        }

        private void C3_CheckChanged(object sender, EventArgs e)
        {
            w3.IsChecked = false;
            c3.IsChecked = true;
            ww3.IsChecked = false;
        }
    }
}