using Xamarin.Forms;
using XamarinFormsBug01.ViewModels;
using XamarinFormsBug01.Views;

namespace XamarinFormsBug01
{
    public class App : Application
    {
        public App()
        {
            var mainViewModel = new MainViewModel();
            MainPage = new MainView { BindingContext = mainViewModel };
        }
    }
}
