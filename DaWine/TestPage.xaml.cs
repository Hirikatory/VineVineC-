
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaWine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        bool[] Choice = new bool[] { false, false, false, false, false, false, false, false, false };
        public  TestPage()
        {
            InitializeComponent();

        }
        
        
        private void whitewineButton_Clicked(object sender, System.EventArgs e)
        {
            this.IsVisible = false;
            PageBackgroundImage.Source = "whitewinePage.png";
            redwineButton.IsVisible = true;
        }

        private void redwineButton_Clicked(object sender, System.EventArgs e)
        {
            this.IsVisible = false;
            PageBackgroundImage.Source = "redwinePage.png";
            whitewineButton.IsVisible = true;
        }

        private void redteaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[0] == false)
            {
                redteaButton.Opacity = 0.6;
                Choice[0] = true;
            }
            else
            {
                redteaButton.Opacity = 0.1;
                Choice[0] = false;
            }
        }

        private void shelkovicaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[1] == false)
            {
                shelkovicaButton.Opacity = 0.6;
                Choice[1] = true;
            }
            else
            {
                shelkovicaButton.Opacity = 0.1;
                Choice[1] = false;
            }
        }

        private void gvozdikaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[2] == false)
            {
                gvozdikaButton.Opacity = 0.6;
                Choice[2] = true;
            }
            else
            {
                gvozdikaButton.Opacity = 0.1;
                Choice[2] = false;
            }
        }

        private void legkoeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[3] == false)
            {
                legkoeButton.Opacity = 0.6;
                Choice[3] = true;
            }
            else
            {
                legkoeButton.Opacity = 0.1;
                Choice[3] = false;
            }
        }

        private void pryanoeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[4] == false)
            {
                pryanoeButton.Opacity = 0.6;
                Choice[4] = true;
            }
            else
            {
                pryanoeButton.Opacity = 0.1;
                Choice[4] = false;
            }
        }

        private void polnoteloeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[5] == false)
            {
                polnoteloeButton.Opacity = 0.6;
                Choice[5] = true;
            }
            else
            {
                polnoteloeButton.Opacity = 0.1;
                Choice[5] = false;
            }
        }

        private void vishnyaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[6] == false)
            {
                vishnyaButton.Opacity = 0.6;
                Choice[6] = true;
            }
            else
            {
                vishnyaButton.Opacity = 0.1;
                Choice[6] = false;
            }
        }

        private void kofeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[7] == false)
            {
                kofeButton.Opacity = 0.6;
                Choice[7] = true;
            }
            else
            {
                kofeButton.Opacity = 0.1;
                Choice[7] = false;
            }
        }

        private void fruktovoeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[8] == false)
            {
                fruktovoeButton.Opacity = 0.6;
                Choice[8] = true;
            }
            else
            {
                fruktovoeButton.Opacity = 0.1;
                Choice[8] = false;
            }
        }

        private void resetButton_Clicked(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Choice[i] = false;
                redteaButton.Opacity = 0.1;
                shelkovicaButton.Opacity = 0.1;
                gvozdikaButton.Opacity = 0.1;
                legkoeButton.Opacity = 0.1;
                pryanoeButton.Opacity = 0.1;
                polnoteloeButton.Opacity = 0.1;
                vishnyaButton.Opacity = 0.1;
                kofeButton.Opacity = 0.1;
                fruktovoeButton.Opacity = 0.1;
            }
        }

        private void nextButton_Clicked(object sender, System.EventArgs e)
        {
            //Здесь должен быть алгоритм выбора вина исходя из состояния булева массива Choice
        }
    }
}