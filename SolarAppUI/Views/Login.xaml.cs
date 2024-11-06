

namespace SolarAppUI.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}


    /// <summary>
    /// Funci�n que al pulsar el bot�n de login comprueba que las credenciales sean correctas,
    /// en caso afirmativo pasa a la siguiente pantalla y en caso negativo, muestra un mensaje de error.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void LoginButton_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (username == "amaro" && password == "1234")
        {
            await DisplayAlert("�xito", "Inicio de sesi�n exitoso", "OK");
            // Cambia la p�gina principal a AppShell
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }
}