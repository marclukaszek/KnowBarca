using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Pages.Transfers;

namespace KnowBarca.Pages.Trophies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrophiesCorrectPage : ContentPage
    {
        public TrophiesCorrectPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void TransfersPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransfersPage());
        }
    }
}