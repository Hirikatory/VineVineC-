using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaWine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public FavPage()
        {
            InitializeComponent();

        }
    }
}
