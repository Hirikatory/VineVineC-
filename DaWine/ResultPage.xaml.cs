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
    public partial class ResultPage : ContentPage
    {
        public ResultPage(string res)
        {
            InitializeComponent();

            if (res != "impossible")
            {
                var label = new Label
                {
                    Text = $"Ваш выбор: {res}",
                    FontFamily = "SFUIText-Bold.otf",
                    HorizontalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    TextColor = Color.FromHex("#ffffff"),
                    FontSize = 50
                };
                layout.Children.Add(label);
                Button button = new Button
                {
                    Text = "Принять",
                    FontFamily = "SFUIText-Bold.otf",
                    TextColor = Color.FromHex("#ffffff"),
                    BorderWidth = 2,
                    BorderColor = Color.FromHex("#ffffff"),
                    FontSize = 22,
                    BackgroundColor = Color.FromHex("#f1ba57"),
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.Center,
                    CornerRadius = 22,
                };
                button.Clicked += async (sender, args) => await Navigation.PushAsync(new MainPage());
                layout.Children.Add(button);
            } else
            {
                var label = new Label
                {
                    Text = "Такое сочетание невозможно, попробуйте снова!",
                    FontFamily = "SFUIText-Bold.otf",
                    HorizontalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    TextColor = Color.FromHex("#ffffff"),
                    FontSize = 50
                };
                layout.Children.Add(label);
                Button button = new Button
                {
                    Text = "Принять",
                    FontFamily = "SFUIText-Bold.otf",
                    TextColor = Color.FromHex("#ffffff"),
                    BorderWidth = 2,
                    BorderColor = Color.FromHex("#ffffff"),
                    FontSize = 22,
                    BackgroundColor = Color.FromHex("#f1ba57"),
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.Center,
                    CornerRadius = 22,
                };
                button.Clicked += async (sender, args) => await Navigation.PushAsync(new TestPage());
                layout.Children.Add(button);
            }
        }
    }
}