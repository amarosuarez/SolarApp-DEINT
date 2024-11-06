using SolarAppDAL;
using SolarAppENT;

namespace SolarAppUI.Views;

public partial class Home : ContentPage
{

    public string FechaHoy { get; set; } = DateTime.Now.ToString("dd/MM/yyyy \n HH:mm");


    public Home()
	{
		InitializeComponent();

        BindingContext = this;

        List<clsCita> lista = clsListadoCitas.obtenerCitas();

		listaView.ItemsSource = lista;
	}

    /// <summary>
    /// Función que al pulsar en una cita, la obtiene y va a la pantalla detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnCitaSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var citaSeleccionada = e.SelectedItem as clsCita;

        if (citaSeleccionada != null)
        {
            await Navigation.PushAsync(new DetalleCita(citaSeleccionada));
        }
    }
}