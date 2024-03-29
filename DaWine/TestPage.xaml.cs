﻿
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace DaWine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        bool[] Choice = new bool[] { false, false, false, false, false, false, false, false, false };
        int choices = 0;
        public  TestPage()
        {
            InitializeComponent();

        }
        
        
        private async void whitewineButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestPageWhite());
        }

        private void redteaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[0] == false && choices < 2)
            {
                redteaButton.Opacity = 1;
                Choice[0] = true;
                choices++;
            }
            else if (Choice[0] == true)
            {
                redteaButton.Opacity = 0.7;
                Choice[0] = false;
                choices--;
            }
        }

        private void shelkovicaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[1] == false && choices < 2)
            {
                shelkovicaButton.Opacity = 1;
                Choice[1] = true;
                choices++;
            }
            else if (Choice[1] == true)
            {
                shelkovicaButton.Opacity = 0.7;
                Choice[1] = false;
                choices--;
            }
        }

        private void gvozdikaButton_Clicked(object sender, System.EventArgs e)
        { 
                if (Choice[2] == false && choices < 2)
            {
                gvozdikaButton.Opacity = 1;
                Choice[2] = true;
                choices++;
            }
            else if (Choice[2] == true)
            {
                gvozdikaButton.Opacity = 0.7;
                Choice[2] = false;
                choices--;
            }
        }

        private void legkoeButton_Clicked(object sender, System.EventArgs e)
        {
            if (Choice[3] == false && choices < 2)
            {
                legkoeButton.Opacity = 1;
                Choice[3] = true;
                choices++;
            }
            else if (Choice[3] == true)
            {
                legkoeButton.Opacity = 0.7;
                Choice[3] = false;
                choices--;
            }
        }

        private void pryanoeButton_Clicked(object sender, System.EventArgs e)
        {
            if (Choice[4] == false && choices < 2)
            {
                pryanoeButton.Opacity = 1;
                Choice[4] = true;
                choices++;
            }
            else if (Choice[4] == true)
            {
                pryanoeButton.Opacity = 0.7;
                Choice[4] = false;
                choices--;
            }
            
        }

        private void polnoteloeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[5] == false && choices < 2)
            {
                polnoteloeButton.Opacity = 1;
                Choice[5] = true;
                choices++;
            }
            else if (Choice[5] == true)
            {
                polnoteloeButton.Opacity = 0.7;
                Choice[5] = false;
                choices--;
            }
        }

        private void vishnyaButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[6] == false && choices < 2)
            {
                vishnyaButton.Opacity = 1;
                Choice[6] = true;
                choices++;
            }
            else if (Choice[6] == true)
            {
                vishnyaButton.Opacity = 0.7;
                Choice[6] = false;
                choices--;
            }
        }

        private void kofeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[7] == false && choices < 2)
            {
                kofeButton.Opacity = 1;
                Choice[7] = true;
                choices++;
            }
            else if (Choice[7] == true)
            {
                kofeButton.Opacity = 0.7;
                Choice[7] = false;
                choices--;
            }
        }

        private void fruktovoeButton_Clicked(object sender, System.EventArgs e)
        {

            if (Choice[8] == false && choices < 2)
            {
                fruktovoeButton.Opacity = 1;
                Choice[8] = true;
                choices++;
            }
            else if (Choice[8] == true)
            {
                fruktovoeButton.Opacity = 0.7;
                Choice[8] = false;
                choices--;
            }
        }

        private void resetButton_Clicked(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Choice[i] = false;
                redteaButton.Opacity = 0.7;
                shelkovicaButton.Opacity = 0.7;
                gvozdikaButton.Opacity = 0.7;
                legkoeButton.Opacity = 0.7;
                pryanoeButton.Opacity = 0.7;
                polnoteloeButton.Opacity = 0.7;
                vishnyaButton.Opacity = 0.7;
                kofeButton.Opacity = 0.7;
                fruktovoeButton.Opacity = 0.7;
                choices = 0;
            }
        }

        private async void nextButton_Clicked(object sender, System.EventArgs e)
        {
            //Здесь должен быть алгоритм выбора вина исходя из состояния булева массива Choice
            string result = "";

            if (Choice[0] && Choice[1])
            {
                result = "Pinot Noir";
            }

            if (Choice[0] && Choice[2])
            {
                result = "Zinfandel";
            }

            if (Choice[0] && Choice[3])
            {
                result = "Pinot Noir";
            }

            if (Choice[0] && Choice[4])
            {
                result = "Zinfandel";
            }

            if (Choice[0] && Choice[5])
            {
                result = "Shiraz";
            }

            if (Choice[0] && Choice[6])
            {
                result = "Zinfandel";
            }

            if (Choice[0] && Choice[7])
            {
                result = "Zinfandel";
            }

            if (Choice[0] && Choice[8])
            {
                result = "Pinot Noir";
            }

            if (Choice[1] && Choice[2])
            {
                result = "Corvos De Lisboa";
            }

            if (Choice[1] && Choice[3])
            {
                result = "Pinot Noir";
            }

            if (Choice[1] && Choice[4])
            {
                result = "Zinfandel";
            }

            if (Choice[1] && Choice[5])
            {
                result = "impossible";
            }

            if (Choice[1] && Choice[6])
            {
                result = "Corvos De Lisboa";
            }

            if (Choice[1] && Choice[7])
            {
                result = "Zinfandel";
            }

            if (Choice[1] && Choice[8])
            {
                result = "Corvos De Lisboa";
            }

            if (Choice[2] && Choice[3])
            {
                result = "Pinot Noir";
            }

            if (Choice[2] && Choice[4])
            {
                result = "impossible";
            }

            if (Choice[2] && Choice[5])
            {
                result = "Shiraz";
            }

            if (Choice[2] && Choice[6])
            {
                result = "Corvos De Lisboa";
            }

            if (Choice[2] && Choice[7])
            {
                result = "Zinfandel";
            }

            if (Choice[2] && Choice[8])
            {
                result = "Corvos De Lisboa";
            }

            if (Choice[3] && Choice[4])
            {
                result = "Pinot Noir";
            }

            if (Choice[3] && Choice[5])
            {
                result = "impossible";
            }

            if (Choice[3] && Choice[6])
            {
                result = "Pinot Noir";
            }

            if (Choice[3] && Choice[7])
            {
                result = "Pinot Noir";
            }

            if (Choice[3] && Choice[8])
            {
                result = "Pinot Noir";
            }

            if (Choice[4] && Choice[5])
            {
                result = "Shiraz";
            }

            if (Choice[4] && Choice[6])
            {
                result = "Shiraz";
            }

            if (Choice[4] && Choice[7])
            {
                result = "Zinfandel";
            }

            if (Choice[4] && Choice[8])
            {
                result = "Shiraz";
            }

            if (Choice[5] && Choice[6])
            {
                result = "Shiraz";
            }

            if (Choice[5] && Choice[7])
            {
                result = "Zinfandel";
            }

            if (Choice[5] && Choice[8])
            {
                result = "Shiraz";
            }

            if (Choice[6] && Choice[7])
            {
                result = "Zinfandel";
            }

            if (Choice[6] && Choice[8])
            {
                result = "Pinot Noir";
            }

            if (Choice[7] && Choice[8])
            {
                result = "Zinfandel";
            }

            await Navigation.PushAsync(new ResultPage(result));

        }
    }
}