using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomThemeDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomTheme : ResourceDictionary
    {
        public MyCustomTheme()
        {
            InitializeComponent();
        }
    }
}