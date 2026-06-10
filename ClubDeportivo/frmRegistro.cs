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
        // cache of horarios to avoid extra DB calls
        private DataTable _horariosCache;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void CmbHorarios_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbFechaInicio.DataSource = null;

                if (cmbHorarios.SelectedValue == null) return;

                // Determine day of week from selected item's Display or from cached table
                var drv = cmbHorarios.SelectedItem as DataRowView;
                if (drv == null) return;

                // diaSemana stored as numeric 1..7 where 1=Monday
                int diaNumero;
                if (!int.TryParse(drv["diaSemana"].ToString(), out diaNumero)) return;

                // Compute next three dates for that weekday
                var fechas = GetNextOccurrences(diaNumero, 3);

                var tabla = new DataTable();
                tabla.Columns.Add("Fecha", typeof(DateTime));
                tabla.Columns.Add("Display", typeof(string));

                foreach (var d in fechas)
                {
                    var r = tabla.NewRow();
                    r["Fecha"] = d;
                    r["Display"] = d.ToString("dd/MM/yyyy");
                    tabla.Rows.Add(r);
                }

                cmbFechaInicio.DisplayMember = "Display";
                cmbFechaInicio.ValueMember = "Fecha";
                cmbFechaInicio.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculando fechas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Devuelve las próximas 'count' fechas que caen en el día de la semana indicado.
        /// diaNumero: 1=Monday .. 7=Sunday
        /// </summary>
        private List<DateTime> GetNextOccurrences(int diaNumero, int count)
        {
            var result = new List<DateTime>();
            // Map 1=Monday..7=Sunday to DayOfWeek
            DayOfWeek target = DayOfWeek.Monday;
            switch (diaNumero)
            {
                case 1: target = DayOfWeek.Monday; break;
                case 2: target = DayOfWeek.Tuesday; break;
                case 3: target = DayOfWeek.Wednesday; break;
                case 4: target = DayOfWeek.Thursday; break;
                case 5: target = DayOfWeek.Friday; break;
                case 6: target = DayOfWeek.Saturday; break;
                case 7: target = DayOfWeek.Sunday; break;
            }

            DateTime current = DateTime.Today;

            // Find the next date (including today if it matches)
            int daysToAdd = ((int)target - (int)current.DayOfWeek + 7) % 7;
            if (daysToAdd == 0)
            {
                // If today is the target, start from next week to match requirement of 'next three'
                daysToAdd = 7;
            }

            DateTime next = current.AddDays(daysToAdd);
            for (int i = 0; i < count; i++)
            {
                result.Add(next.AddDays(7 * i));
            }

            return result;
        }

        private string MapDiaSemana(object diaValue)
        {
            if (diaValue == null) return string.Empty;

            int dia;
            if (!int.TryParse(diaValue.ToString(), out dia)) return diaValue.ToString();

            switch (dia)
            {
                case 1: return "Lunes";
                case 2: return "Martes";
                case 3: return "Miércoles";
                case 4: return "Jueves";
                case 5: return "Viernes";
                case 6: return "Sábado";
                case 7: return "Domingo";
                default: return diaValue.ToString();
            }
        }

        private string FormatHora(object horaValue)
        {
            if (horaValue == null) return string.Empty;

            // Try parse as TimeSpan or DateTime, otherwise fallback to string and trim seconds
            TimeSpan ts;
            DateTime dt;
            var s = horaValue.ToString();
            if (TimeSpan.TryParse(s, out ts))
            {
                return ts.ToString(@"hh\:mm");
            }
            if (DateTime.TryParse(s, out dt))
            {
                return dt.ToString("HH:mm");
            }

            // Fallback: try to remove seconds if present like HH:mm:ss
            var parts = s.Split(':');
            if (parts.Length >= 2) return parts[0].PadLeft(2, '0') + ":" + parts[1].PadLeft(2, '0');
            return s;
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

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                var repo = new Datos.ActividadRepositorio();
                var tabla = repo.ObtenerActividades();

                cmbActividad.DisplayMember = "Nombre";
                cmbActividad.ValueMember = "IdActividad";
                cmbActividad.DataSource = tabla;

                // Preload horarios cache
                var repoHor = new Datos.HorarioRepositorio();
                _horariosCache = repoHor.ObtenerHorarios();

                // Attach handler for activity changes
                cmbActividad.SelectedValueChanged += CmbActividad_SelectedValueChanged;
                // Trigger initial population
                CmbActividad_SelectedValueChanged(cmbActividad, EventArgs.Empty);

                // Attach handler to populate fecha inicio when horario selected
                cmbHorarios.SelectedValueChanged += CmbHorarios_SelectedValueChanged;

                // Preload plans for cmbPlanPago
                var repoPlan = new Datos.PlanPagoRepositorio();
                var tablaPlanes = repoPlan.ObtenerPlanes();
                // Add a display column combining descripcion and importe
                if (!tablaPlanes.Columns.Contains("Display")) tablaPlanes.Columns.Add("Display", typeof(string));
                foreach (DataRow r in tablaPlanes.Rows)
                {
                    r["Display"] = string.Format("{0} - {1}", r["descripcion"], r["importe"]);
                }
                cmbPlanPago.DisplayMember = "Display";
                cmbPlanPago.ValueMember = "idPlan";
                cmbPlanPago.DataSource = tablaPlanes;

                // Ensure the first input has focus (Nombre)
                this.ActiveControl = txtNombre;
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando actividades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbHorarios.DataSource = null;

                if (cmbActividad.SelectedValue == null) return;

                int idActividad;
                if (!int.TryParse(cmbActividad.SelectedValue.ToString(), out idActividad)) return;

                // Filter cached horarios for the selected activity
                var view = new DataView(_horariosCache);
                view.RowFilter = "idActividad = " + idActividad;

                var tablaFiltrada = view.ToTable();

                // Create a display column for user-friendly text (e.g., Lunes 18:00-19:00)
                if (!tablaFiltrada.Columns.Contains("Display"))
                    tablaFiltrada.Columns.Add("Display", typeof(string));

                foreach (DataRow row in tablaFiltrada.Rows)
                {
                    var diaNombre = MapDiaSemana(row["diaSemana"]);
                    var horaInicio = FormatHora(row["horaInicio"]);
                    var horaFin = FormatHora(row["horaFin"]);
                    row["Display"] = string.Format("{0} {1}-{2}", diaNombre, horaInicio, horaFin);
                }

                cmbHorarios.DisplayMember = "Display";
                cmbHorarios.ValueMember = "idHorario";
                cmbHorarios.DataSource = tablaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando horarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
