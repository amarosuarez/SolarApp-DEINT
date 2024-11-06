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
        await DisplayAlert("Cerrando sesi�n...", "Hasta la pr�xima!", "Ciao!");
        // Cambia la p�gina principal a AppShell
        Application.Current.MainPage = new NavigationPage(new Login());
    }
}