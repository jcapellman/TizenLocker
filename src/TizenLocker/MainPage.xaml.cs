using TizenLocker.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenLocker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageVM();
        }
    }
}