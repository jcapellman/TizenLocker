using TizenLocker.Tizen.Views;

using Xamarin.Forms;

namespace TizenLocker.Tizen
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}