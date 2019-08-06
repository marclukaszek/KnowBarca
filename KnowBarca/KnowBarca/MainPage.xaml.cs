using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using KnowBarca.Pages;
using KnowBarca.Pages.Quiz;

namespace KnowBarca
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
            logo.Source = ImageSource.FromResource("KnowBarca.Images.knowbarca2.png");
        }

        async void History_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage());
        }

        async void Play_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage());
        }

        async void Author_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthorPage());
        }
    }
}
