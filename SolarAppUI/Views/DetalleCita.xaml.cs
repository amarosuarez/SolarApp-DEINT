using SolarAppENT;

namespace SolarAppUI.Views
{
    public partial class DetalleCita : ContentPage
    {
        public DetalleCita(clsCitas cita)
        {
            InitializeComponent();

            BindingContext = cita;
        }

        /// <summary>
        /// Función que 'guarda' la información
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnGuardarInformeClicked(object sender, EventArgs e)
        {

            await DisplayAlert("Guardado!", "Datos guardados correctamente", "OK");

        }
    }
}
