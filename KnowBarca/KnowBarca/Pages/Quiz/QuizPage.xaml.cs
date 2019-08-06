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
            await DisplayAlert("Twój wynik to: ", istr+"/3", "OK");
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

        private void W1_CheckChanged(object sender, EventArgs e)
        {
            w1.IsChecked = true;
            c1.IsChecked = false;
            ww1.IsChecked = false;
        }

        private void Ww1_CheckChanged(object sender, EventArgs e)
        {
            w1.IsChecked = false;
            c1.IsChecked = false;
            ww1.IsChecked = true;
        }

        private void C1_CheckChanged(object sender, EventArgs e)
        {
            w1.IsChecked = false;
            c1.IsChecked = true;
            ww1.IsChecked = false;
        }

        private void C2_CheckChanged(object sender, EventArgs e)
        {
            w2.IsChecked = false;
            c2.IsChecked = true;
            ww2.IsChecked = false;
        }

        private void W2_CheckChanged(object sender, EventArgs e)
        {
            w2.IsChecked = true;
            c2.IsChecked = false;
            ww2.IsChecked = false;
        }

        private void Ww2_CheckChanged(object sender, EventArgs e)
        {
            w2.IsChecked = false;
            c2.IsChecked = false;
            ww2.IsChecked = true;
        }

        private void W3_CheckChanged(object sender, EventArgs e)
        {
            w3.IsChecked = true;
            c3.IsChecked = false;
            ww3.IsChecked = false;
        }

        private void Ww3_CheckChanged(object sender, EventArgs e)
        {
            w3.IsChecked = false;
            c3.IsChecked = false;
            ww3.IsChecked = true;
        }

        private void C3_CheckChanged(object sender, EventArgs e)
        {
            w3.IsChecked = false;
            c3.IsChecked = true;
            ww3.IsChecked = false;
        }
    }
}