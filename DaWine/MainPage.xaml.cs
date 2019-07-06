using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace DaWine
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /*
         Ниже - код для навигационных кнопок
         */
        private async void OnFavClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FavPage());
        }

        private async void OnScanClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScanPage());
        }

        private async void OnPhotoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PhotoPage());
        }

        private async void OnTestClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }

    }
}
