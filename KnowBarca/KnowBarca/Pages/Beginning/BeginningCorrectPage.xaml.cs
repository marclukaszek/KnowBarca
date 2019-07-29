using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Pages.Stadium;

namespace KnowBarca.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BeginningCorrectPage : ContentPage
    {
        public BeginningCorrectPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void StartStadiumPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StadiumPage());
        }
    }
}