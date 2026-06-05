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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            // Show the main form instead of exiting the application
            var main = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();
            if (main != null)
            {
                main.Show();
            }
            else
            {
                var principal = new frmPrincipal();
                principal.Show();
            }
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Controlamos que todos los datos requeridos tengan información
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Corta la ejecución si faltan datos
            }

            // 2. Instanciamos un objeto de la clase Socio y le pasamos los datos de las cajas de texto
            Entidades.Socio nuevoSocio = new Entidades.Socio();
            nuevoSocio.DNI = txtDNI.Text;
            nuevoSocio.Nombre = txtNombre.Text;
            nuevoSocio.Apellido = txtApellido.Text;
            nuevoSocio.Telefono = txtTelefono.Text;

            // 3. Instanciamos la clase Socios de la capa Datos y llamamos al método
            Datos.Socios dato = new Datos.Socios();
            string respuesta = dato.NuevoSocio(nuevoSocio);

            // 4. Analizamos la respuesta de la base de datos (Recordemos que 1 significa que ya existe)
            if (respuesta == "1")
            {
                MessageBox.Show("El DNI ingresado ya se encuentra registrado en el sistema.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Socio registrado exitosamente. Su número de socio es: " + respuesta, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos los campos para una nueva carga
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
            }
        }
    }
}
