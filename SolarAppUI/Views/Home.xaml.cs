using SolarAppDAL;
using SolarAppENT;

namespace SolarAppUI.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

		List<clsCitas> lista = clsListadoCitas.obtenerCitas();

		listaView.ItemsSource = lista;

	}

    /// <summary>
    /// Función que al pulsar en una cita, la obtiene y va a la pantalla detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnCitaSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var citaSeleccionada = e.SelectedItem as clsCitas;

        if (citaSeleccionada != null)
        {
            await Navigation.PushAsync(new DetalleCita(citaSeleccionada));
        }
    }
}