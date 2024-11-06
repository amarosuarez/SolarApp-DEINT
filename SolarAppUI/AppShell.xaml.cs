using SolarAppUI.Views;

namespace SolarAppUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("home", typeof(Home));
            Routing.RegisterRoute("informes", typeof(Informes));
            Routing.RegisterRoute("logout", typeof(LogOut));
        }
    }
}
