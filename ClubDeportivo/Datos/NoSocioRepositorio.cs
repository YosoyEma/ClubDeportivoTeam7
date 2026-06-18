using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class NoSocioRepositorio
    {
        public string Nuevo_NoSocio_Visita(string dni, string nombre, string apellido, string telefono, int idHorario, DateTime fechaAsistencia, decimal importe)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // 1. Instanciamos la conexión
                sqlCon = Conexion.GetInstancia().CrearConexion();

                // 2. Apuntamos al Procedimiento Almacenado de Enzo
                MySqlCommand comando = new MySqlCommand("Nuevo_NoSocio_Visita", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // 3. Pasamos los 7 parámetros de entrada EXACTAMENTE como los pide MySQL
                comando.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = apellido;
                comando.Parameters.Add("p_telefono", MySqlDbType.VarChar).Value = telefono;
                comando.Parameters.Add("p_idHorario", MySqlDbType.Int32).Value = idHorario;
                comando.Parameters.Add("p_fechaAsistencia", MySqlDbType.Date).Value = fechaAsistencia;
                comando.Parameters.Add("p_importe", MySqlDbType.Decimal).Value = importe;

                // 4. Configuramos el parámetro de salida (el número de visita o el error)
                MySqlParameter parRespuesta = new MySqlParameter();
                parRespuesta.ParameterName = "r_respuesta";
                parRespuesta.MySqlDbType = MySqlDbType.Int32;
                parRespuesta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parRespuesta);

                // 5. Abrimos, ejecutamos y capturamos la respuesta
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parRespuesta.Value);
            }
            catch (Exception ex)
            {
                // Si falla la BD, atajamos el error técnico
                salida = ex.Message;
            }
            finally
            {
                // Pase lo que pase, cerramos la conexión para no saturar el servidor
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return salida;
        }
    }
}