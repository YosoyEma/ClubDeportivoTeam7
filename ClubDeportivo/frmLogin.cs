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

                    // También abrir FrmTabla con el filtro "vencen hoy" aplicado y mantenerla encima de Principal
                    try
                    {
                        var tabla = new FrmTabla();
                        // Indicar a FrmTabla que seleccione el filtro "vencen hoy" al cargarse
                        tabla.SelectPagarHoy();
                        // Mostrar la tabla como ventana hija de Principal para que permanezca encima
                        tabla.Show(Principal);
                    }
                    catch
                    {
                        // Si falla abrir la tabla, ignorar para no bloquear el ingreso
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
