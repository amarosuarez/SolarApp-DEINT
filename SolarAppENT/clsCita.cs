using System.Drawing;

namespace SolarAppENT
{
    public class clsCita
    {
        #region Propiedades
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public Boolean Completada { get; set; }

        public clsCliente Cliente { get; set; }

        public string TextoCompletado
        {
            get
            {
                return Completada ? "COMPLETADA" : "POR COMPLETAR";
            }
        }
        #endregion

        #region Constructores
        public clsCita() { }

        public clsCita(int id, string fecha, Boolean completada, clsCliente cliente)
        {
            Id = id;
            Fecha = DateTime.Parse(fecha);
            Completada = completada;
            Cliente = cliente;
        }
        #endregion
    }
}
