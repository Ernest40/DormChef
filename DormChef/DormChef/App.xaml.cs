using DormChef.Views;

namespace DormChef
{
    public partial class App : Application
    {
        public static IServiceProvider? Services { get; private set; }

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            Services = serviceProvider;

            MainPage = new NavigationPage(serviceProvider.GetRequiredService<HomePage>());
        }
    }
}