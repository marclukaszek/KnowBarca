using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using KnowBarca.Classes;

namespace KnowBarca.Pages.Scoreboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScoreboardPage : ContentPage
    {
        public ScoreboardPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            SQLiteConnection conn = new SQLiteConnection(App.FilePath);
            {
                conn.CreateTable<Score>();
                var score = conn.Query<Score>("Select * from [Score] order by ScoreVal desc  limit 10 ");
                scoreListView.ItemsSource = score;
                scoreListViewScore.ItemsSource = score;


            }
            List<int> places = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            scoreListViewPlace.ItemsSource = places;

        }
    }
}