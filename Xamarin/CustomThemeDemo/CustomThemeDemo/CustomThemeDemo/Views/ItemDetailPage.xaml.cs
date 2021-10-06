using CustomThemeDemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CustomThemeDemo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}