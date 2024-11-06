using System.Drawing;
using System.Reflection.Emit;

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

        public Color ColorCompletado
        {
            get
            {
                return Completada ? Color.Green : Color.Red;
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
