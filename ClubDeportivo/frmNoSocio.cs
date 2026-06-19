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
        // Caché de horarios para evitar consultas continuas a la BD
        private DataTable _horariosCache;

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
            // 1. Validamos que no haya campos vacíos (incluyendo los nuevos)
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" ||
                cboActividad.SelectedIndex == -1 || cboHorarios.SelectedIndex == -1 || txtImporte.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Instanciamos la Entidad
            Entidades.NoSocio nuevoNoSocio = new Entidades.NoSocio();
            nuevoNoSocio.Dni = txtDNI.Text;
            nuevoNoSocio.Nombre = txtNombre.Text;
            nuevoNoSocio.Apellido = txtApellido.Text;
            nuevoNoSocio.Telefono = txtTelefono.Text;

            // 3. Capturamos los datos específicos de los controles nuevos
            int idHorario = Convert.ToInt32(cboHorarios.SelectedValue);
            DateTime fechaAsistencia = dtpFechaAsistencia.Value;

            // Intentamos convertir el texto a decimal. Si falla, avisamos y cortamos la ejecución.
            bool esImporteValido = decimal.TryParse(txtImporte.Text, out decimal importe);

            if (!esImporteValido)
            {
                MessageBox.Show("El importe ingresado no tiene un formato válido. Asegúrese de ingresar solo números.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Instanciamos el repositorio y enviamos a la BD usando el Stored Procedure
            Datos.NoSocioRepositorio repo = new Datos.NoSocioRepositorio();
            string respuesta = repo.Nuevo_NoSocio_Visita(nuevoNoSocio.Dni, nuevoNoSocio.Nombre, nuevoNoSocio.Apellido, nuevoNoSocio.Telefono, idHorario, fechaAsistencia, importe);

            // 5. Evaluamos respuesta
            bool esNumero = int.TryParse(respuesta, out int codigo);

            if (esNumero)
            {
                // NOTA: Para visitantes, el SP de MySQL siempre inserta la visita, aunque la persona ya exista (pueden venir varias veces)
                MessageBox.Show("Visitante diario registrado exitosamente con el número de visita: " + respuesta, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos todo
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtImporte.Text = "";
                cboActividad.SelectedIndex = -1;
                cboHorarios.SelectedIndex = -1;
                dtpFechaAsistencia.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Error en la base de datos: " + respuesta, "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNoSocio_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga de actividades
                Datos.ActividadRepositorio repoAct = new Datos.ActividadRepositorio();
                cboActividad.DataSource = repoAct.ObtenerActividades();
                cboActividad.DisplayMember = "Nombre";
                cboActividad.ValueMember = "IdActividad";
                cboActividad.SelectedIndex = -1;

                // Carga de la caché de horarios
                Datos.HorarioRepositorio repoHorario = new Datos.HorarioRepositorio();
                _horariosCache = repoHorario.ObtenerHorarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //: Filtra los horarios cuando elegís una actividad
        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya una actividad seleccionada
            if (cboActividad.SelectedIndex != -1)
            {
                // 1. Extraemos el importe oculto en la fila seleccionada y lo mostramos en el TextBox
                DataRowView rowView = (DataRowView)cboActividad.SelectedItem;
                txtImporte.Text = rowView["Importe"].ToString();

                // 2. Filtramos la tabla de horarios para esa actividad
                if (_horariosCache != null)
                {
                    int idActividadElegida = Convert.ToInt32(cboActividad.SelectedValue);

                    DataView dvHorarios = _horariosCache.DefaultView;
                    dvHorarios.RowFilter = "idActividad = " + idActividadElegida;

                    cboHorarios.DataSource = dvHorarios.ToTable();
                    cboHorarios.DisplayMember = "Detalle";
                    cboHorarios.ValueMember = "idHorario";
                    cboHorarios.SelectedIndex = -1;
                }
            }
            else
            {
                // Si se limpia el combo, limpiamos también la caja del importe
                txtImporte.Text = "";
            }
        }
    }
}