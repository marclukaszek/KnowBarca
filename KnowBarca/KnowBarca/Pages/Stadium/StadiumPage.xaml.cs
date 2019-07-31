using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Pages;

namespace KnowBarca.Pages.Stadium
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StadiumPage : ContentPage
    {
        public StadiumPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void Test_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StadiumTestPage());
        }
    }
}