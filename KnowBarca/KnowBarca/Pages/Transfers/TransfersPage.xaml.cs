﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KnowBarca.Pages.Transfers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransfersPage : ContentPage
    {
        public TransfersPage()
        {
            InitializeComponent();
            background.Source = ImageSource.FromResource("KnowBarca.Images.Background.png");
        }

        async void TransfersTest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransfersTestPage());
        }
    }
}