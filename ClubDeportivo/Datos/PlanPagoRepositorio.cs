using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    internal class PlanPagoRepositorio
    {
        public DataTable ObtenerPlanes()
        {
            var tabla = new DataTable();
            string sql = "SELECT idPlan AS idPlan, descripcion AS descripcion, importe AS importe FROM PlanPago ORDER BY idPlan";

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
