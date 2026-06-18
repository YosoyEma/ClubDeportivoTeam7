using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class HorarioRepositorio
    {
        /// <summary>
        /// Obtiene todos los horarios de actividad: idHorario, idActividad, diaSemana, horaInicio, horaFin
        /// </summary>
        public DataTable ObtenerHorarios()
        {
            var tabla = new DataTable();

            // ¡AQUÍ ESTÁ LA MAGIA! Traducimos el número a día y concatenamos las horas
            string sql = @"SELECT idHorario, idActividad, 
                           CONCAT(
                               CASE diaSemana 
                                   WHEN 1 THEN 'Lunes' 
                                   WHEN 2 THEN 'Martes' 
                                   WHEN 3 THEN 'Miércoles' 
                                   WHEN 4 THEN 'Jueves' 
                                   WHEN 5 THEN 'Viernes' 
                                   WHEN 6 THEN 'Sábado' 
                                   WHEN 7 THEN 'Domingo' 
                               END, 
                               ' (', TIME_FORMAT(horaInicio, '%H:%i'), ' a ', TIME_FORMAT(horaFin, '%H:%i'), ')'
                           ) AS Detalle
                           FROM HorarioActividad 
                           ORDER BY idActividad, diaSemana, horaInicio";

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
