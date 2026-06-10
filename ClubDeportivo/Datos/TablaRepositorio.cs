using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class TablaRepositorio
    {
        /// <summary>
        /// Obtiene registros de la tabla socios para mostrar en una grilla.
        /// </summary>
        public DataTable ObtenerSocios()
        {
            var tabla = new DataTable();
            // Selección explícita de columnas: unir socio con persona para incluir nroSocio
            string sql = "SELECT s.nroSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM socio s INNER JOIN persona p ON s.persona_dni = p.dni ORDER BY s.nroSocio ASC";

            try
            {
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(comando))
                {
                    comando.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                // If we retrieved rows, return them
                if (tabla.Rows.Count > 0)
                    return tabla;

                // If socios exists but empty, return empty table
                return tabla;
            }
            catch (MySqlException mex)
            {
                // MySQL error 1146 = table doesn't exist
                if (mex.Number == 1146)
                {
                    // Let caller handle listing tables via ListarTablas()
                    throw;
                }

                // For other MySQL exceptions, rethrow
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Devuelve la lista de tablas de la base de datos para diagnosticar problemas de esquema.
        /// </summary>
        public DataTable ListarTablas()
        {
            var tablas = new DataTable();
            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand("SHOW TABLES", conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tablas);
            }

            if (tablas.Columns.Count > 0)
                tablas.Columns[0].ColumnName = "Tabla";

            return tablas;
        }
        }
    }

