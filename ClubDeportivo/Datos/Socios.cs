using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Socios
    {

        /// <summary>
        /// Crea persona, socio e inserta una inscripcion en la misma operación (llama a procedimiento almacenado Nuevo_Socio_Inscripcion)
        /// Devuelve: "1" si el DNI ya existe, "-1" en error, o el idSocio creado como string en caso de éxito.
        /// </summary>
        public string NuevoSocioConInscripcion(Entidades.Socio socio, int idHorario, int idPlan, DateTime fechaInicio, DateTime fechaEntregaCarnet)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Nuevo_Socio_Inscripcion", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = socio.DNI;
                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("p_telefono", MySqlDbType.VarChar).Value = socio.Telefono;

                comando.Parameters.Add("p_idHorario", MySqlDbType.Int32).Value = idHorario;
                comando.Parameters.Add("p_idPlan", MySqlDbType.Int32).Value = idPlan;
                comando.Parameters.Add("p_fechaInicio", MySqlDbType.Date).Value = fechaInicio;

                // fechaEntregaCarnet passed from caller (date only)
                comando.Parameters.Add("p_fechaEntregaCarnet", MySqlDbType.Date).Value = fechaEntregaCarnet.Date;

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
                // Return full exception text to caller for debugging stored procedure failures
                salida = "-1: " + ex.ToString();
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}
