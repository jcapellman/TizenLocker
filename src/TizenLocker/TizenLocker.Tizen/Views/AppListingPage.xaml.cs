using TizenLocker.Tizen.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenLocker.Tizen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppListingPage : ContentPage
    {
        private MainPageVM viewModel => (MainPageVM) BindingContext;

        public AppListingPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();

            viewModel.LoadData();
        }
    }
}