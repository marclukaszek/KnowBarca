using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KnowBarca.Pages.CrestAndColors;

namespace KnowBarca.Pages.CrestAndColors
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrestAndColorsTestPage : ContentPage
    {
        public CrestAndColorsTestPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        private void StartPyt2_Clicked(object sender, EventArgs e)
        {
            if (correct.IsChecked && wrong1.IsChecked && wrong2.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (correct.IsChecked && wrong1.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (correct.IsChecked && wrong2.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (wrong1.IsChecked && wrong2.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if ((correct.IsChecked == false) && (wrong1.IsChecked == false) && (wrong2.IsChecked == false))
            {
                DisplayAlert("Uwaga!", "Nie wybrano odpowiedzi", "OK");
            }
            else
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Pyt1.IsVisible = false;
                    Pyt2.IsVisible = true;
                });
            }
        }
        private void StartPyt3_Clicked(object sender, EventArgs e)
        {
            if (Pyt2c.IsChecked && Pyt2w.IsChecked && Pyt2ww.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (Pyt2c.IsChecked && Pyt2w.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (Pyt2c.IsChecked && Pyt2ww.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (Pyt2w.IsChecked && Pyt2ww.IsChecked)
            {
                DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if ((Pyt2c.IsChecked == false) && (Pyt2w.IsChecked == false) && (Pyt2ww.IsChecked == false))
            {
                DisplayAlert("Uwaga!", "Nie wybrano odpowiedzi", "OK");
            }
            else
            {
                Pyt2.IsVisible = false;
                Pyt3.IsVisible = true;
            }
        }

        async void Check_Clicked(object sender, EventArgs e)
        {
            if (Pyt3c.IsChecked && Pyt3w.IsChecked && Pyt3ww.IsChecked)
            {
                await DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (Pyt3c.IsChecked && Pyt3w.IsChecked)
            {
                await DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (Pyt3c.IsChecked && Pyt3ww.IsChecked)
            {
                await DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if (Pyt3w.IsChecked && Pyt3ww.IsChecked)
            {
                await DisplayAlert("Uwaga!", "Wybierz jedną odpowiedź", "OK");
            }
            else if ((Pyt3c.IsChecked == false) && (Pyt3w.IsChecked == false) && (Pyt3ww.IsChecked == false))
            {
                await DisplayAlert("Uwaga!", "Nie wybrano odpowiedzi", "OK");
            }

            else
            {
                if (correct.IsChecked && Pyt2c.IsChecked && Pyt3c.IsChecked)
                {
                    await Navigation.PushAsync(new CrestAndColorsCorrectPage());

                }
                else
                {
                    await Navigation.PushAsync(new CrestAndColorsPage());
                    await DisplayAlert("Niepoprawna odpowiedź!", "Spróbuj jeszcze raz!", "OK");
                }
            }

        }
    }
}