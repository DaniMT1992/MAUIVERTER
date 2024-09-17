using MAUIVERTER.MVVM.View;

namespace MAUIVERTER
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuView());
        }
    }
}
