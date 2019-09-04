
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaWine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanPage : ContentPage
    {
        public ScanPage()
        {
            InitializeComponent();

        }
        private void onScanButton_Clicked(object sender, System.EventArgs e)
        {
            uiImage.Source = "uiCaptured";
            scanAgain.IsEnabled = true;
            scan.IsEnabled = false;
            nextButton.IsEnabled = true;
        }
        private void onScanAgainButton_Clicked(object sender, System.EventArgs e)
        {
            uiImage.Source = "ui";
            scan.IsEnabled = true;
            scanAgain.IsEnabled = false;
            nextButton.IsEnabled = false;
        }

        private async void onNextButton_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new ScannedPage());
        }
        private async void OnBackClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}