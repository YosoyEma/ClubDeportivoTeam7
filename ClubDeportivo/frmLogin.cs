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

            frmPrincipal ventanaPrincipal = new frmPrincipal();
            ventanaPrincipal.Show();
            this.Hide();

            /* DataTable tablaLogin = new DataTable(); // Es la que recibe los datos desde la base de datos
            Datos.Usuarios dato = new Datos.Usuarios(); // Instanciamos la clase Usuarios que creamos en el paso anterior

            // Llamamos al método Log_Usu pasándole lo que el usuario escribió en las cajas de texto
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // Si la tabla tiene al menos 1 fila, quiere decir que el usuario EXISTE y la clave es correcta
                MessageBox.Show("Ingreso exitoso", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // NOTA: Cuando creen la pantalla del Menú, aquí irá el código para abrirla

                frmPrincipal ventanaPrincipal = new frmPrincipal();
                ventanaPrincipal.Show();
                this.Hide();

            }
            else
            {
                // Si la tabla vuelve vacía, los datos son incorrectos
                MessageBox.Show("Usuario y/o password incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
