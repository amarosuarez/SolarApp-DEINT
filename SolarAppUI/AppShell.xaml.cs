using SolarAppUI.Views;
using System.Globalization;

namespace SolarAppUI
{
    public partial class AppShell : Shell
    {

        public string Inicio { get; set; } = "Inicio a las " + DateTime.Now.ToString("HH:mm");

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;

            Routing.RegisterRoute("home", typeof(Home));
            Routing.RegisterRoute("informes", typeof(Informes));
            Routing.RegisterRoute("logout", typeof(LogOut));
            Routing.RegisterRoute("detallecita", typeof(DetalleCita));

            
        }
    }
}
