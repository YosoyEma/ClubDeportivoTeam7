using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class ActividadRepositorio
    {
        /// <summary>
        /// Obtiene las actividades (id y nombre) para poblar comboboxes.
        /// </summary>
        public DataTable ObtenerActividades()
        {
            var tabla = new DataTable();
            string sql = "SELECT idActividad AS IdActividad, nombre AS Nombre FROM Actividad ORDER BY nombre";

            try
            {
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
