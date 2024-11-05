using SolarAppUI.Views;

namespace SolarAppUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("home", typeof(Home));
        }
    }
}
