using SolarAppENT;

namespace SolarAppDAL
{
    public class clsListadoCitas
    {
        /// <summary>
        /// Función que obtiene todas las citas disponibles y las devuelve como una lista
        /// </summary>
        /// <returns>Lista de las citas disponibles</returns>
        public static List<clsCita> obtenerCitas()
        {
            return new List<clsCita> {
                new clsCita(1, "07/11/2024 12:30", false, new clsCliente(1, "Auri", "Calle Twitch 2, 48100", 123456789)),
                new clsCita(2, "07/11/2024 16:30", false, new clsCliente(2, "Jenri", "Calle Rosa 28, 45120", 987654321)),
                new clsCita(3, "07/11/2024 18:30", false, new clsCliente(3, "Lorenzo", "Calle del Sol", 987654321)),
                new clsCita(4, "08/11/2024 10:30", false, new clsCliente(4, "Marta", "Avenida de la Paz", 912345678)),
                new clsCita(5, "08/11/2024 12:30", false, new clsCliente(5, "Marcos", "Calle Luna", 654321987)),
                new clsCita(6, "08/11/2024 16:30", false, new clsCliente(6, "Sofía", "Paseo del Río", 345678912)),
                new clsCita(7, "08/11/2024 18:30", false, new clsCliente(7, "Raúl", "Calle Esperanza", 678912345)),
                new clsCita(8, "09/11/2024 12:30", false, new clsCliente(8, "María", "Calle Libertad", 789123456)),
                new clsCita(9, "09/11/2024 16:30", false, new clsCliente(9, "Héctor", "Avenida Central", 890234567)),
                new clsCita(10, "09/11/2024 18:30", false, new clsCliente(10, "Elena", "Calle del Mar", 234567890)),

            };
        }

        /// <summary>
        /// Función que obtiene una cita específica por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve una cita específica</returns>
        public static clsCita obtenerCitaByID(int id)
        {
            List<clsCita> citas = obtenerCitas();
            clsCita cita1 = new clsCita();

            foreach (clsCita cita in citas)
            {
                if (cita.Id == id)
                {
                    cita1 = cita;
                }
            }

            return cita1;
        }
    }
}
