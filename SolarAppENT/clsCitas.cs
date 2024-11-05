namespace SolarAppENT
{
    public class clsCitas
    {
        #region Propiedades
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public Boolean Completada { get; set; }

        public clsCliente Cliente { get; set; }
        #endregion

        #region Constructores
        public clsCitas() { }

        public clsCitas(int id, string fecha, Boolean completada, clsCliente cliente)
        {
            Id = id;
            Fecha = DateTime.Parse(fecha);
            Completada = completada;
            Cliente = cliente;
        }
        #endregion
    }
}
