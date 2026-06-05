using System;
using System.Data;
using MySql.Data.MySqlClient; // Referencia obligatoria para usar MySQL

namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
        // Creamos un método que retorne una tabla con la información
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // Variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                // Llamamos a la clase Conexion que creamos en el paso anterior
                sqlCon = Conexion.GetInstancia().CrearConexion();

                // El comando almacena el nombre del procedimiento almacenado y la referencia a la conexión
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                // Definimos los parámetros que tiene el procedure en la base de datos
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                // Abrimos la conexión
                sqlCon.Open();

                // Ejecutamos la consulta y almacenamos el resultado en la variable
                resultado = comando.ExecuteReader();

                // Cargamos la tabla con el resultado
                tabla.Load(resultado);

                return tabla;
                // De esta forma está asociado el método con el procedure almacenado en MySQL
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}