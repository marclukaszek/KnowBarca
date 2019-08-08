using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Pages.Trophies;

namespace KnowBarca.Pages.CrestAndColors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrestAndColorsCorrectPage : ContentPage
    {
        public CrestAndColorsCorrectPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void TrophiesPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrophiesPage());
        }
    }
}