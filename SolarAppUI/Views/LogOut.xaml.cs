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
       
        Application.Current.MainPage = new NavigationPage(new Login());
    }
}