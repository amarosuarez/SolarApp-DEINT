namespace SolarAppENT
{
    public class clsCitas
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public clsCliente Cliente { get; set; }
        #endregion

        #region Constructores
        public clsCitas() { }

        public clsCitas(int id, string nombre, string ubicacion, string fecha, clsCliente cliente)
        {
            Id = id;
            Nombre = nombre;
            Fecha = DateTime.Parse(fecha);
            Cliente = cliente;
        }
        #endregion
    }
}
