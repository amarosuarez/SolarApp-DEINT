namespace SolarAppUI.Views;

public partial class LogOut : ContentPage
{
	public LogOut()
	{
		InitializeComponent();
        
        cerrarSesion();
    }

    public async void cerrarSesion()
    {
        await DisplayAlert("Cerrando sesión...", "Hasta la próxima!", "Ciao!");
        // Cambia la página principal a AppShell
        Application.Current.MainPage = new NavigationPage(new Login());
    }
}