using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarAppENT
{
    public class clsCliente
    {
        #region Atributos
        public int Id {  get; set; }

        public string Nombre { get; set; }

        public string Direccion {  get; set; }

        public int Telefono {
            get { return Telefono; }
            set { 
                if (value.ToString().Length == 9)
                    Telefono = value;
            }
        }
        #endregion

        #region Constructores
        public clsCliente() { }

        public clsCliente(int id, string nombre, string direccion, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        } 
        #endregion

    }
}
