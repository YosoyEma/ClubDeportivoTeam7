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
            string sql = "SELECT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM socio s INNER JOIN persona p ON s.persona_dni = p.dni ORDER BY s.idSocio ASC";

            try
            {
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var comando = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(comando))
                {
                    comando.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                return tabla;
            }
            catch (MySqlException mex)
            {
                if (mex.Number == 1146) throw;
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

        /// <summary>
        /// Obtiene socios que están inscriptos en una actividad específica.
        /// </summary>
        public DataTable ObtenerSociosPorActividad(int idActividad)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM socio s INNER JOIN persona p ON s.persona_dni = p.dni JOIN inscripcion i ON i.idSocio = s.idSocio JOIN horarioactividad h ON i.idHorario = h.idHorario WHERE h.idActividad = @id ORDER BY s.idSocio ASC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", idActividad);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene registros de nosocios (visitas) para mostrar en una grilla.
        /// </summary>
        public DataTable ObtenerNoSocios()
        {
            var tabla = new DataTable();
            string sql = "SELECT n.nroVisita AS NroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM nosocio n INNER JOIN persona p ON n.persona_dni = p.dni ORDER BY n.nroVisita DESC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var comando = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(comando))
            {
                comando.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene nosocios que asistieron a una actividad específica (basado en visitaactividad).
        /// </summary>
        public DataTable ObtenerNoSociosPorActividad(int idActividad)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT n.nroVisita AS NroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM visitaactividad v JOIN nosocio n ON v.nroVisita = n.nroVisita JOIN persona p ON n.persona_dni = p.dni JOIN horarioactividad h ON v.idHorario = h.idHorario WHERE h.idActividad = @id ORDER BY n.nroVisita DESC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", idActividad);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene los datos de un socio por su id (incluye datos de persona y estadoActivo).
        /// </summary>
        public DataRow ObtenerSocioPorId(int idSocio)
        {
            var tabla = new DataTable();
            string sql = "SELECT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono, s.estadoActivo AS estadoActivo FROM socio s INNER JOIN persona p ON s.persona_dni = p.dni WHERE s.idSocio = @id";
            try
            {
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@id", idSocio);
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                if (tabla.Rows.Count > 0) return tabla.Rows[0];
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene el registro más reciente de nosocio asociado a un DNI (si existe).
        /// </summary>
        public DataRow ObtenerNoSocioPorDni(string dni)
        {
            var tabla = new DataTable();
            string sql = "SELECT n.nroVisita AS nroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM nosocio n INNER JOIN persona p ON n.persona_dni = p.dni WHERE p.dni = @dni ORDER BY n.nroVisita DESC LIMIT 1";
            try
            {
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                if (tabla.Rows.Count > 0) return tabla.Rows[0];
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene el nombre de la actividad asociada a la última inscripción del socio.
        /// </summary>
        public string ObtenerActividadPorInscripcionSocio(int idSocio)
        {
            try
            {
                var tabla = new DataTable();
                string sql = "SELECT a.nombre AS actividad FROM inscripcion i JOIN horarioactividad h ON i.idHorario = h.idHorario JOIN actividad a ON h.idActividad = a.idActividad WHERE i.idSocio = @id ORDER BY i.fechaInicio DESC LIMIT 1";
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@id", idSocio);
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                if (tabla.Rows.Count > 0) return tabla.Rows[0]["actividad"].ToString();
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Obtiene la visita por nroVisita (incluye persona y actividad y importe)
        /// </summary>
        public DataRow ObtenerVisitaPorNro(int nroVisita)
        {
            try
            {
                var tabla = new DataTable();
                string sql = "SELECT v.idVisitaActividad AS idVisitaActividad, v.nroVisita AS nroVisita, v.idHorario AS idHorario, v.fechaAsistencia AS fechaAsistencia, v.importe AS importe, v.pagado AS pagado, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, a.nombre AS actividad FROM visitaactividad v JOIN nosocio n ON v.nroVisita = n.nroVisita JOIN persona p ON n.persona_dni = p.dni JOIN horarioactividad h ON v.idHorario = h.idHorario JOIN actividad a ON h.idActividad = a.idActividad WHERE v.nroVisita = @nro LIMIT 1";
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@nro", nroVisita);
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                if (tabla.Rows.Count > 0) return tabla.Rows[0];
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene socios que tienen cuotas sin pagar con vencimiento en la fecha indicada.
        /// </summary>
        public DataTable ObtenerSociosQueVencenHoy(DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM cuota c JOIN socio s ON c.idSocio = s.idSocio JOIN persona p ON s.persona_dni = p.dni WHERE c.pagada = 0 AND DATE(c.fechaVencimiento) = @fecha ORDER BY s.idSocio ASC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene socios que vencen hoy y además están inscriptos en una actividad específica.
        /// </summary>
        public DataTable ObtenerSociosQueVencenHoyPorActividad(int idActividad, DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM cuota c JOIN socio s ON c.idSocio = s.idSocio JOIN persona p ON s.persona_dni = p.dni JOIN inscripcion i ON i.idSocio = s.idSocio JOIN horarioactividad h ON i.idHorario = h.idHorario WHERE c.pagada = 0 AND DATE(c.fechaVencimiento) = @fecha AND h.idActividad = @id ORDER BY s.idSocio ASC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@id", idActividad);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene no-socios (visitas) con pago pendiente en la fecha indicada.
        /// </summary>
        public DataTable ObtenerNoSociosQueVencenHoy(DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT n.nroVisita AS NroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM visitaactividad v JOIN nosocio n ON v.nroVisita = n.nroVisita JOIN persona p ON n.persona_dni = p.dni WHERE v.pagado = 0 AND DATE(v.fechaAsistencia) = @fecha ORDER BY n.nroVisita DESC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene no-socios con pago pendiente en la fecha indicada y filtrados por actividad.
        /// </summary>
        public DataTable ObtenerNoSociosQueVencenHoyPorActividad(int idActividad, DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT n.nroVisita AS NroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM visitaactividad v JOIN nosocio n ON v.nroVisita = n.nroVisita JOIN persona p ON n.persona_dni = p.dni JOIN horarioactividad h ON v.idHorario = h.idHorario WHERE v.pagado = 0 AND DATE(v.fechaAsistencia) = @fecha AND h.idActividad = @id ORDER BY n.nroVisita DESC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@id", idActividad);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene socios que tienen cuotas impagas con fechaVencimiento anterior a la fecha indicada (deudores).
        /// </summary>
        public DataTable ObtenerSociosDeudores(DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM cuota c JOIN socio s ON c.idSocio = s.idSocio JOIN persona p ON s.persona_dni = p.dni WHERE c.pagada = 0 AND DATE(c.fechaVencimiento) < @fecha ORDER BY s.idSocio ASC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene socios deudores filtrados por actividad.
        /// </summary>
        public DataTable ObtenerSociosDeudoresPorActividad(int idActividad, DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT s.idSocio AS NroSocio, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM cuota c JOIN socio s ON c.idSocio = s.idSocio JOIN persona p ON s.persona_dni = p.dni JOIN inscripcion i ON i.idSocio = s.idSocio JOIN horarioactividad h ON i.idHorario = h.idHorario WHERE c.pagada = 0 AND DATE(c.fechaVencimiento) < @fecha AND h.idActividad = @id ORDER BY s.idSocio ASC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@id", idActividad);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene nosocios (visitas) con pago pendiente y fechaAsistencia anterior a la fecha indicada (deudores).
        /// </summary>
        public DataTable ObtenerNoSociosDeudores(DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT n.nroVisita AS NroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM visitaactividad v JOIN nosocio n ON v.nroVisita = n.nroVisita JOIN persona p ON n.persona_dni = p.dni WHERE v.pagado = 0 AND DATE(v.fechaAsistencia) < @fecha ORDER BY n.nroVisita DESC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene nosocios deudores filtrados por actividad.
        /// </summary>
        public DataTable ObtenerNoSociosDeudoresPorActividad(int idActividad, DateTime fecha)
        {
            var tabla = new DataTable();
            string sql = "SELECT DISTINCT n.nroVisita AS NroVisita, p.dni AS DNI, p.nombre AS Nombre, p.apellido AS Apellido, p.telefono AS Telefono FROM visitaactividad v JOIN nosocio n ON v.nroVisita = n.nroVisita JOIN persona p ON n.persona_dni = p.dni JOIN horarioactividad h ON v.idHorario = h.idHorario WHERE v.pagado = 0 AND DATE(v.fechaAsistencia) < @fecha AND h.idActividad = @id ORDER BY n.nroVisita DESC";

            using (var conexion = Conexion.GetInstancia().CrearConexion())
            using (var cmd = new MySqlCommand(sql, conexion))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                cmd.Parameters.AddWithValue("@id", idActividad);
                cmd.CommandType = CommandType.Text;
                adapter.Fill(tabla);
            }

            return tabla;
        }

        /// <summary>
        /// Obtiene la última cuota asociada a un socio (monto, pagada y fechaVencimiento).
        /// </summary>
        public DataRow ObtenerUltimaCuotaPorSocio(int idSocio)
        {
            try
            {
                var tabla = new DataTable();
                string sql = "SELECT monto, pagada, fechaVencimiento FROM cuota WHERE idSocio = @id ORDER BY fechaVencimiento DESC, idCuota DESC LIMIT 1";
                using (var conexion = Conexion.GetInstancia().CrearConexion())
                using (var cmd = new MySqlCommand(sql, conexion))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    cmd.Parameters.AddWithValue("@id", idSocio);
                    cmd.CommandType = CommandType.Text;
                    adapter.Fill(tabla);
                }

                if (tabla.Rows.Count > 0) return tabla.Rows[0];
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
