using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaWine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPageWhite : ContentPage
    {

        bool[] Choice = new bool[] { false, false, false, false, false, false, false, false, false };
        int choices = 0;
        public TestPageWhite()
        {
            InitializeComponent();

        }


        private async void redwineButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPage());
        }

        private void appleButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[0] == false && choices < 2)
            {
                appleButton.Opacity = 1;
                Choice[0] = true;
                choices++;
            }
            else if (Choice[0] == true)
            {
                appleButton.Opacity = 0.7;
                Choice[0] = false;
                choices--;
            }
        }

        private void honeyButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[1] == false && choices < 2)
            {
                honeyButton.Opacity = 1;
                Choice[1] = true;
                choices++;
            }
            else if (Choice[1] == true)
            {
                honeyButton.Opacity = 0.7;
                Choice[1] = false;
                choices--;
            }
        }

        private void flowerButton_Clicked(object sender, System.EventArgs e)
        {
            if (Choice[2] == false && choices < 2)
            {
                flowerButton.Opacity = 1;
                Choice[2] = true;
                choices++;
            }
            else if (Choice[2] == true)
            {
                flowerButton.Opacity = 0.7;
                Choice[2] = false;
                choices--;
            }
        }

        private void fruitButton_Clicked(object sender, System.EventArgs e)
        {
            if (Choice[3] == false && choices < 2)
            {
                fruitButton.Opacity = 1;
                Choice[3] = true;
                choices++;
            }
            else if (Choice[3] == true)
            {
                fruitButton.Opacity = 0.7;
                Choice[3] = false;
                choices--;
            }
        }

        private void legkoewhiteButton_Clicked(object sender, System.EventArgs e)
        {
            if (Choice[4] == false && choices < 2)
            {
                legkoewhiteButton.Opacity = 1;
                Choice[4] = true;
                choices++;
            }
            else if (Choice[4] == true)
            {
                legkoewhiteButton.Opacity = 0.7;
                Choice[4] = false;
                choices--;
            }

        }

        private void polnoteloewhiteButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[5] == false && choices < 2)
            {
                polnoteloewhiteButton.Opacity = 1;
                Choice[5] = true;
                choices++;
            }
            else if (Choice[5] == true)
            {
                polnoteloewhiteButton.Opacity = 0.7;
                Choice[5] = false;
                choices--;
            }
        }

        private void creamButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[6] == false && choices < 2)
            {
                creamButton.Opacity = 1;
                Choice[6] = true;
                choices++;
            }
            else if (Choice[6] == true)
            {
                creamButton.Opacity = 0.7;
                Choice[6] = false;
                choices--;
            }
        }

        private void limeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[7] == false && choices < 2)
            {
                limeButton.Opacity = 1;
                Choice[7] = true;
                choices++;
            }
            else if (Choice[7] == true)
            {
                limeButton.Opacity = 0.7;
                Choice[7] = false;
                choices--;
            }
        }

        private void freshButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[8] == false && choices < 2)
            {
                freshButton.Opacity = 1;
                Choice[8] = true;
                choices++;
            }
            else if (Choice[8] == true)
            {
                freshButton.Opacity = 0.7;
                Choice[8] = false;
                choices--;
            }
        }

        private void resetButton_Clicked(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Choice[i] = false;
                appleButton.Opacity = 0.7;
                honeyButton.Opacity = 0.7;
                flowerButton.Opacity = 0.7;
                fruitButton.Opacity = 0.7;
                legkoewhiteButton.Opacity = 0.7;
                polnoteloewhiteButton.Opacity = 0.7;
                creamButton.Opacity = 0.7;
                limeButton.Opacity = 0.7;
                freshButton.Opacity = 0.7;
                choices = 0;
            }
        }
        private async void nextButton_Clicked(object sender, System.EventArgs e)
        {
            //Здесь должен быть алгоритм выбора вина исходя из состояния булева массива Choice

            string result = "";

            if (Choice[0] && Choice[1])
            {
                result = "Verdejo";
            }

            if (Choice[0] && Choice[2])
            {
                result = "Verdejo";
            }

            if (Choice[0] && Choice[3])
            {
                result = "impossible";
            }

            if (Choice[0] && Choice[4])
            {
                result = "Orvieto";
            }

            if (Choice[0] && Choice[5])
            {
                result = "Verdejo";
            }

            if (Choice[0] && Choice[6])
            {
                result = "Verdejo";
            }

            if (Choice[0] && Choice[7])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[0] && Choice[8])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[1] && Choice[2])
            {
                result = "Riesling";
            }

            if (Choice[1] && Choice[3])
            {
                result = "Riesling";
            }

            if (Choice[1] && Choice[4])
            {
                result = "Riesling";
            }

            if (Choice[1] && Choice[5])
            {
                result = "Verdejo";
            }

            if (Choice[1] && Choice[6])
            {
                result = "Verdejo";
            }

            if (Choice[1] && Choice[7])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[1] && Choice[8])
            {
                result = "Riesling";
            }

            if (Choice[2] && Choice[3])
            {
                result = "Riesling";
            }

            if (Choice[2] && Choice[4])
            {
                result = "Orvieto";
            }

            if (Choice[2] && Choice[5])
            {
                result = "impossible";
            }

            if (Choice[2] && Choice[6])
            {
                result = "impossible";
            }

            if (Choice[2] && Choice[7])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[2] && Choice[8])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[3] && Choice[4])
            {
                result = "Orvieto";
            }

            if (Choice[3] && Choice[5])
            {
                result = "Verdejo";
            }

            if (Choice[3] && Choice[6])
            {
                result = "Verdejo";
            }

            if (Choice[3] && Choice[7])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[3] && Choice[8])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[4] && Choice[5])
            {
                result = "impossible";
            }

            if (Choice[4] && Choice[6])
            {
                result = "impossible";
            }

            if (Choice[4] && Choice[7])
            {
                result = "Sauvignon Blanc";
            }

            if (Choice[4] && Choice[8])
            {
                result = "Orvieto";
            }

            if (Choice[5] && Choice[6])
            {
                result = "Verdejo";
            }

            if (Choice[5] && Choice[7])
            {
                result = "impossible";
            }

            if (Choice[5] && Choice[8])
            {
                result = "impossible";
            }

            if (Choice[6] && Choice[7])
            {
                result = "Verdejo";
            }

            if (Choice[6] && Choice[8])
            {
                result = "impossible";
            }

            if (Choice[7] && Choice[8])
            {
                result = "Sauvignon Blanc";
            }

            await Navigation.PushAsync(new ResultPage(result));

        }
    }
}
