using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KnowBarca.Pages.Trophies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrophiesPage : ContentPage
    {
        public TrophiesPage()
        {
            InitializeComponent();
            copa.Source = ImageSource.FromResource("KnowBarca.Images.copa.jpg");
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void TrophiesTest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrophiesTestPage());
        }
    }
}