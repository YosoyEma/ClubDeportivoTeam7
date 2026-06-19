using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class SociosRepositorio
    {
        public string Nuevo_Socio_Inscripcion(string dni, string nombre, string apellido, string telefono, int idHorario, int idPlan, DateTime fechaInicio, DateTime fechaEntregaCarnet)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Nuevo_Socio_Inscripcion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // 8 Parámetros de entrada EXACTAMENTE como se llaman en MySQL
                comando.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = apellido;
                comando.Parameters.Add("p_telefono", MySqlDbType.VarChar).Value = telefono;
                comando.Parameters.Add("p_idHorario", MySqlDbType.Int32).Value = idHorario;
                comando.Parameters.Add("p_idPlan", MySqlDbType.Int32).Value = idPlan;
                comando.Parameters.Add("p_fechaInicio", MySqlDbType.Date).Value = fechaInicio;
                comando.Parameters.Add("p_fechaEntregaCarnet", MySqlDbType.Date).Value = fechaEntregaCarnet;

                // Parámetro de salida EXACTAMENTE como lo pide MySQL (ESTO SOLUCIONA EL ERROR)
                MySqlParameter parRespuesta = new MySqlParameter();
                parRespuesta.ParameterName = "r_respuesta";
                parRespuesta.MySqlDbType = MySqlDbType.Int32;
                parRespuesta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parRespuesta);

                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parRespuesta.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }
            return salida;
        }
    }
}