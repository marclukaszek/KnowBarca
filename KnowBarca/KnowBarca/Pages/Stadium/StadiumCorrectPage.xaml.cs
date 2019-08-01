using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Pages.CrestAndColors;

namespace KnowBarca.Pages.Stadium
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StadiumCorrectPage : ContentPage
    {
        public StadiumCorrectPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void CrestAndColors_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrestAndColorsPage());
        }
    }
}