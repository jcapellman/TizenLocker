using TizenLocker.Tizen.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenLocker.Tizen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private MainPageVM viewModel => (MainPageVM) BindingContext;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();

            viewModel.LoadData();
        }
    }
}