using Microsoft.Extensions.DependencyInjection;

namespace Mauisqlite20135783
{
    public partial class App : Application
    {
        public App(MainPage mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
        }
    }
}