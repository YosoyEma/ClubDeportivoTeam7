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

            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();

            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // El resultado tiene 1 fila, por lo que el usuario EXISTE en MySQL
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal Principal = new frmPrincipal();
                // (Opcional) Si en frmPrincipal definiste variables para recibir el rol, se pasan aquí.

                Principal.Show(); // Abre el menú
                this.Hide();      // Oculta el login
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
