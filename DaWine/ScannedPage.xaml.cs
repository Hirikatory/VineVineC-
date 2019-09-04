using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaWine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScannedPage : ContentPage
    {
        public ScannedPage()
        {
            InitializeComponent();
        }
        private async void onScanAgainButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ScanPage());
        }

        private async void onNextButton_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PopToRootAsync();
        }
        private async void OnBackClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}