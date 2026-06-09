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
            string sql = "SELECT idHorario AS idHorario, idActividad AS idActividad, diaSemana AS diaSemana, horaInicio AS horaInicio, horaFin AS horaFin FROM HorarioActividad ORDER BY idActividad, diaSemana, horaInicio";

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
