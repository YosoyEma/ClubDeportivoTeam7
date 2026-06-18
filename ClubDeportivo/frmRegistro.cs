using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ClubDeportivo
{
    public partial class frmRegistro : Form
    {
        // Caché de horarios para evitar llamadas extra a BD (creado por Enzo)
        private DataTable _horariosCache;
        // Generador aleatorio para importes
        private static readonly Random _rand = new Random();

        public frmRegistro()
        {
            InitializeComponent();
        }

        // --- Botón Cancelar ---
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Botón Añadir Socio ---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que los datos personales básicos y selecciones no estén vacíos
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" ||
                cboHorarios.SelectedIndex == -1 || cboPlanPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los datos personales y opciones de membresía.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Instanciamos la Entidad Socio (Heredada de Persona)
                Entidades.Socio nuevoSocio = new Entidades.Socio();
                nuevoSocio.Dni = txtDNI.Text;
                nuevoSocio.Nombre = txtNombre.Text;
                nuevoSocio.Apellido = txtApellido.Text;
                nuevoSocio.Telefono = txtTelefono.Text;

                // 3. Capturamos los datos específicos de los controles de Membresía
                // (Se asume que Enzo ya configuró el 'ValueMember' de estos combos para que guarden el ID)
                int idHorario = Convert.ToInt32(cboHorarios.SelectedValue);
                int idPlan = Convert.ToInt32(cboPlanPago.SelectedValue);
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaEntregaCarnet = DateTime.Now; // Fecha actual de entrega

                // 4. Enviamos al repositorio (Capa de Datos)
                Datos.Socios repo = new Datos.Socios();

                // Conectamos con el método que llama al Stored Procedure de Enzo
                string respuesta = repo.Nuevo_Socio_Inscripcion(
                    nuevoSocio.Dni,
                    nuevoSocio.Nombre,
                    nuevoSocio.Apellido,
                    nuevoSocio.Telefono,
                    idHorario,
                    idPlan,
                    fechaInicio,
                    fechaEntregaCarnet
                );

                // Evaluamos si la respuesta es verdaderamente un número (ID de socio) o un texto de error
                bool esNumero = int.TryParse(respuesta, out int codigo);

                if (esNumero)
                {
                    if (codigo == 1) // 1 significa que el DNI ya existe
                    {
                        MessageBox.Show("El DNI ingresado ya se encuentra registrado en el sistema.", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Socio registrado exitosamente con el número: " + respuesta, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpieza de campos
                        txtDNI.Text = "";
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtTelefono.Text = "";
                        cboActividad.SelectedIndex = -1;
                        cboHorarios.SelectedIndex = -1;
                        cboPlanPago.SelectedIndex = -1;
                        dtpFechaInicio.Value = DateTime.Now;
                    }
                }
                else
                {
                    // Si no es número, es el texto del error de MySQL
                    MessageBox.Show("Error en la base de datos: " + respuesta, "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Llenar el ComboBox de Actividades
                Datos.ActividadRepositorio repoAct = new Datos.ActividadRepositorio();
                cboActividad.DataSource = repoAct.ObtenerActividades();
                cboActividad.DisplayMember = "Nombre";      // Lo que lee el usuario
                cboActividad.ValueMember = "IdActividad";   // El ID real que va a la base de datos
                cboActividad.SelectedIndex = -1;            // Lo dejamos en blanco al principio

                // 2. Llenar el ComboBox de Planes de Pago
                Datos.PlanPagoRepositorio repoPlan = new Datos.PlanPagoRepositorio();
                cboPlanPago.DataSource = repoPlan.ObtenerPlanes();
                cboPlanPago.DisplayMember = "descripcion";
                cboPlanPago.ValueMember = "idPlan";
                cboPlanPago.SelectedIndex = -1;

                // 3. Traer los Horarios a la memoria caché de Enzo
                Datos.HorarioRepositorio repoHorario = new Datos.HorarioRepositorio();
                _horariosCache = repoHorario.ObtenerHorarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si se eligió una actividad y la caché de horarios ya está cargada
            if (cboActividad.SelectedIndex != -1 && _horariosCache != null)
            {
                int idActividadElegida = Convert.ToInt32(cboActividad.SelectedValue);

                // Filtramos la tabla de horarios
                DataView dvHorarios = _horariosCache.DefaultView;
                dvHorarios.RowFilter = "idActividad = " + idActividadElegida;

                cboHorarios.DataSource = dvHorarios.ToTable();
                // ¡ACÁ ESTÁ EL CAMBIO! Ahora lee la frase completa armada en la BD
                cboHorarios.DisplayMember = "Detalle";
                cboHorarios.ValueMember = "idHorario";
                cboHorarios.SelectedIndex = -1;
            }
        }
    }
}