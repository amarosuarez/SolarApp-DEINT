using SolarAppENT;

namespace SolarAppDAL
{
    public class clsListadoCitas
    {
        /// <summary>
        /// Función que obtiene todas las citas disponibles y las devuelve como una lista
        /// </summary>
        /// <returns>Lista de las citas disponibles</returns>
        public static List<clsCitas> obtenerCitas()
        {
            return new List<clsCitas> {
                new clsCitas(1, "07/11/2024 12:30", new clsCliente(1, "Auri", "Calle Twitch 2, 48100", 123456789)),
                new clsCitas(2, "07/11/2024 16:30", new clsCliente(2, "Jenri", "Calle Rosa 28, 45120", 987654321)),
                new clsCitas(3, "07/11/2024 18:30", new clsCliente(3, "Lorenzo", "Calle del Sol", 987654321)),
                new clsCitas(4, "08/11/2024 10:30", new clsCliente(4, "Marta", "Avenida de la Paz", 912345678)),
                new clsCitas(5, "08/11/2024 12:30", new clsCliente(5, "Marcos", "Calle Luna", 654321987)),
                new clsCitas(6, "08/11/2024 16:30", new clsCliente(6, "Sofía", "Paseo del Río", 345678912)),
                new clsCitas(7, "08/11/2024 18:30", new clsCliente(7, "Raúl", "Calle Esperanza", 678912345)),
                new clsCitas(8, "09/11/2024 12:30", new clsCliente(8, "María", "Calle Libertad", 789123456)),
                new clsCitas(9, "09/11/2024 16:30", new clsCliente(9, "Héctor", "Avenida Central", 890234567)),
                new clsCitas(10, "09/11/2024 18:30", new clsCliente(10, "Elena", "Calle del Mar", 234567890)),

            };
        }
    }
}
