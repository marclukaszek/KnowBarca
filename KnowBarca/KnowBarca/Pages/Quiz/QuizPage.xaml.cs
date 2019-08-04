using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KnowBarca.Pages.Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        int i = 0;
        public QuizPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void QuizSolved(object sender, EventArgs e)
        {
            i = 0;
            Mark();
            string istr = i.ToString();
            DisplayAlert("Twój wynik to: ", istr+"/3", "OK");
        }

        public int Mark()
        {
            if (c1.IsChecked)
                i++;
            if (c2.IsChecked)
                i++;
            if (c3.IsChecked)
                i++;


            return i;
        }
    }
}