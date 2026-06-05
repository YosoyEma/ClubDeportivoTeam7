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
        public string NuevoSocio(Entidades.Socio socio)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("Nuevo_Socio", sqlCon);
                // Especificamos que se usa un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;

                // Le pasamos los datos al procedimiento
                comando.Parameters.Add("p_dni", MySqlDbType.VarChar).Value = socio.DNI;
                comando.Parameters.Add("p_nombre", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("p_apellido", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("p_telefono", MySqlDbType.VarChar).Value = socio.Telefono;

                // Configuramos el parámetro de salida (OUT r_respuesta)
                MySqlParameter parRespuesta = new MySqlParameter();
                parRespuesta.ParameterName = "r_respuesta";
                parRespuesta.MySqlDbType = MySqlDbType.Int32;
                parRespuesta.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parRespuesta);

                sqlCon.Open();
                comando.ExecuteNonQuery(); // Ejecutamos el insert

                salida = Convert.ToString(parRespuesta.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
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
