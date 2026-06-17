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
    public partial class frmNoSocio : Form
    {
        public frmNoSocio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que no haya campos vacíos
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtActividad.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Instanciamos la Entidad NoSocio y encapsulamos los datos
            Entidades.NoSocio nuevoNoSocio = new Entidades.NoSocio();
            nuevoNoSocio.Dni = txtDNI.Text;
            nuevoNoSocio.Nombre = txtNombre.Text;
            nuevoNoSocio.Apellido = txtApellido.Text;
            nuevoNoSocio.Telefono = txtTelefono.Text;
            nuevoNoSocio.ActividadAsignada = txtActividad.Text;

            // 3. Instanciamos el repositorio y enviamos los datos a la base de datos
            Datos.NoSocioRepositorio repo = new Datos.NoSocioRepositorio();
            string respuesta = repo.NuevoNoSocioConRegistro(nuevoNoSocio.Dni, nuevoNoSocio.Nombre, nuevoNoSocio.Apellido, nuevoNoSocio.Telefono, nuevoNoSocio.ActividadAsignada);

            // 4. Evaluamos la respuesta del repositorio
            if (respuesta == "1")
            {
                // El repositorio de tu compañero devuelve "1" si la persona ya existe en la BD
                MessageBox.Show("El DNI ingresado ya se encuentra registrado en el sistema.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Visitante diario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos las cajas de texto para una nueva carga
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtActividad.Text = "";
            }
        }
    }
}
