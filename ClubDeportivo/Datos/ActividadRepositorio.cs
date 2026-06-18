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
            // ¡AQUÍ ESTÁ EL CAMBIO! Agregamos importeclaseindividual AS Importe
            string sql = "SELECT idActividad AS IdActividad, nombre AS Nombre, importeclaseindividual AS Importe FROM Actividad ORDER BY nombre";

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                tabla.Load(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return tabla;
        }
    }
}
