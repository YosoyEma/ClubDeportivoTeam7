using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Ejecutar inhabilitación automática de socios vencidos (procedimiento almacenado)
            try
            {
                var inhRepo = new InhabilitacionRepositorio();
                // Ejecuta el stored procedure; no bloquear el inicio si falla
                try { inhRepo.EjecutarInhabilitarSociosVencidos(); } catch { /* silent */ }
            }
            catch
            {
                // No impedir inicio de la aplicación por errores de conexión/ejecución
            }

            Application.Run(new frmLogin());
        }
    }
}
