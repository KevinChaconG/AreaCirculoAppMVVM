using AreaCirculoAppMVVM.Views;

namespace AreaCirculoAppMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AreaCirculoView());
        }
    }
}
