using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    /// <summary>
    /// Repositorio dedicado a ejecutar procedures relacionados con inhabilitaciones automáticas.
    /// </summary>
    internal class InhabilitacionRepositorio
    {
        /// <summary>
        /// Ejecuta el procedimiento almacenado Inhabilitar_Socios_Vencidos.
        /// Este método no lanza excepciones hacia el llamador salvo que la conexión falle gravemente.
        /// </summary>
        public int EjecutarInhabilitarSociosVencidos()
        {
            int resultado = -1;

            try
            {
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand("Inhabilitar_Socios_Vencidos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    var parRespuesta = new MySqlParameter("r_respuesta", MySqlDbType.Int32);
                    parRespuesta.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(parRespuesta);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    // Intentar obtener el parámetro de salida
                    try
                    {
                        resultado = Convert.ToInt32(parRespuesta.Value);
                    }
                    catch
                    {
                        resultado = -1;
                    }
                }
            }
            catch
            {
                // Re-throwing is avoided to keep startup resilient; caller may ignore failures
                throw;
            }

            return resultado;
        }
    }
}
