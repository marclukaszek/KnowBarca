using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Classes;
using KnowBarca.Pages.Scoreboard;

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
        async void QuizSolved2(object sender, EventArgs e)
        {
            string nickname = nicknameEntry.Text;
            if (String.IsNullOrEmpty(nickname))
            {
                await DisplayAlert("Uwaga!", "Proszę podać swój nickname", "OK");
            }
            else
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
                await Navigation.PushAsync(new ScoreboardPage());
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
            if (c4.IsChecked)
                scorev++;
            if (c5.IsChecked)
                scorev++;
            if (c6.IsChecked)
                scorev++;
            if (c7.IsChecked)
                scorev++;
            if (c8.IsChecked)
                scorev++;
            if (c9.IsChecked)
                scorev++;
            if (c10.IsChecked)
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
        private void W4_CheckChanged(object sender, EventArgs e)
        {
            w4.IsChecked = true;
            c4.IsChecked = false;
            ww4.IsChecked = false;
        }

        private void Ww4_CheckChanged(object sender, EventArgs e)
        {
            w4.IsChecked = false;
            c4.IsChecked = false;
            ww4.IsChecked = true;
        }

        private void C4_CheckChanged(object sender, EventArgs e)
        {
            w4.IsChecked = false;
            c4.IsChecked = true;
            ww4.IsChecked = false;
        }
        private void W5_CheckChanged(object sender, EventArgs e)
        {
            w5.IsChecked = true;
            c5.IsChecked = false;
            ww5.IsChecked = false;
        }

        private void Ww5_CheckChanged(object sender, EventArgs e)
        {
            w5.IsChecked = false;
            c5.IsChecked = false;
            ww5.IsChecked = true;
        }

        private void C5_CheckChanged(object sender, EventArgs e)
        {
            w5.IsChecked = false;
            c5.IsChecked = true;
            ww5.IsChecked = false;
        }
        private void W6_CheckChanged(object sender, EventArgs e)
        {
            w6.IsChecked = true;
            c6.IsChecked = false;
            ww6.IsChecked = false;
        }

        private void Ww6_CheckChanged(object sender, EventArgs e)
        {
            w6.IsChecked = false;
            c6.IsChecked = false;
            ww6.IsChecked = true;
        }

        private void C6_CheckChanged(object sender, EventArgs e)
        {
            w6.IsChecked = false;
            c6.IsChecked = true;
            ww6.IsChecked = false;
        }
        private void W7_CheckChanged(object sender, EventArgs e)
        {
            w7.IsChecked = true;
            c7.IsChecked = false;
            ww7.IsChecked = false;
        }

        private void WW7_CheckChanged(object sender, EventArgs e)
        {
            w7.IsChecked = false;
            c7.IsChecked = false;
            ww7.IsChecked = true;
        }

        private void C7_CheckChanged(object sender, EventArgs e)
        {
            ww7.IsChecked = false;
            c7.IsChecked = true;
            w7.IsChecked = false;
        }
        private void w8_CheckChanged(object sender, EventArgs e)
        {
            w8.IsChecked = true;
            c8.IsChecked = false;
            ww8.IsChecked = false;
        }

        private void Ww8_CheckChanged(object sender, EventArgs e)
        {
            w8.IsChecked = false;
            c8.IsChecked = false;
            ww8.IsChecked = true;
        }

        private void c8_CheckChanged(object sender, EventArgs e)
        {
            w8.IsChecked = false;
            c8.IsChecked = true;
            ww8.IsChecked = false;
        }
        private void w9_CheckChanged(object sender, EventArgs e)
        {
            w9.IsChecked = true;
            c9.IsChecked = false;
            ww9.IsChecked = false;
        }

        private void Ww9_CheckChanged(object sender, EventArgs e)
        {
            w9.IsChecked = false;
            c9.IsChecked = false;
            ww9.IsChecked = true;
        }

        private void c9_CheckChanged(object sender, EventArgs e)
        {
            w9.IsChecked = false;
            c9.IsChecked = true;
            ww9.IsChecked = false;
        }
        private void w10_CheckChanged(object sender, EventArgs e)
        {
            w10.IsChecked = true;
            c10.IsChecked = false;
            ww10.IsChecked = false;
        }

        private void Ww10_CheckChanged(object sender, EventArgs e)
        {
            w10.IsChecked = false;
            c10.IsChecked = false;
            ww10.IsChecked = true;
        }

        private void c10_CheckChanged(object sender, EventArgs e)
        {
            w10.IsChecked = false;
            c10.IsChecked = true;
            ww10.IsChecked = false;
        }
    }
}