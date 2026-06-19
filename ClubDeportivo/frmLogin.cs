using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Instanciamos las clases y buscamos el usuario
                DataTable tablaLogin = new DataTable();
                Datos.UsuariosRepositorio dato = new Datos.UsuariosRepositorio();

                tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

                // 2. Evaluamos si el usuario de la app existe
                if (tablaLogin.Rows.Count > 0)
                {
                    MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmPrincipal Principal = new frmPrincipal();
                    Principal.Show();

                    // Also open FrmTabla with the "solo vencidos" filter applied and keep it on top of Principal
                    try
                    {
                        var tabla = new FrmTabla();
                        // Ask FrmTabla to select the "vencen hoy" filter when it loads
                        tabla.SelectPagarHoy();
                        // Show the table as owned by Principal so it stays on top of the main window
                        tabla.Show(Principal);
                    }
                    catch
                    {
                        // If anything fails opening the table, ignore to not block login
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Si la conexión a MySQL falla por una mala contraseña, se ataja el error y se muestra este cartel:
                MessageBox.Show("No se pudo conectar a la base de datos MySQL. Revise que los datos ingresados (Servidor, Puerto, Usuario y Clave) sean los correctos.\n\nDetalle técnico: " + ex.Message,
                                "Error de Conexión a Base de Datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Datos.Conexion.ReiniciarConexion();
            }
        }
    }
}
