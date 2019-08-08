using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KnowBarca.Pages.CrestAndColors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrestAndColorsPage : ContentPage
    {
        public CrestAndColorsPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
            herb.Source = ImageSource.FromResource("KnowBarca.Images.herb.png");
        }

        async void CrestAndColorsTest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrestAndColorsTestPage());
        }
    }
}