using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KnowBarca.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BeginningPage : ContentPage
    {
        public BeginningPage()
        {
            InitializeComponent();

            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
            Barca1903.Source = ImageSource.FromResource("KnowBarca.Images.Barca1903.jpg");
        }

        async void BeginningTest_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BeginningTestPage());
        }
        
    }
}