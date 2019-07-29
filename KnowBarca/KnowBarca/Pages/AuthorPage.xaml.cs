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
    public partial class AuthorPage : ContentPage
    {
        public AuthorPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
            author.Source = ImageSource.FromResource("KnowBarca.Images.author.jpg");
        }

        public Command ClickCommand => new Command<string>((url) =>
        {
            url = "mailto:marlukaszek@gmail.com";
            Device.OpenUri(new System.Uri(url));
        });
    }
}