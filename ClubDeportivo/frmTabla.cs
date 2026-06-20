using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FrmTabla : Form
    {
        public FrmTabla()
        {
            InitializeComponent();
            this.Load += FrmTabla_Load;
            // Solo conectar el handler del botón Aplicar aquí (no ejecutar búsquedas automáticamente)
            btnAplicar.Click += BtnAplicar_Click;
            // Asegurar que el botón Limpiar (btnDefault) esté conectado al handler
            btnDefault.Click += btnDefault_Click;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            try
            {
                int? idActividad = null;
                if (cboActividad.DataSource != null && cboActividad.SelectedValue != null)
                {
                    int tmp;
                    if (int.TryParse(cboActividad.SelectedValue.ToString(), out tmp))
                    {
                        // Treat non-positive sentinel (0 or negative) as "Todos" -> no activity filter
                        if (tmp > 0) idActividad = tmp;
                        else idActividad = null;
                    }
                }

                // Tipo: Socios o No socios (control in designer is cboTipo)
                bool tipoSocio = true; // por defecto socios
                if (cboTipo.SelectedItem != null)
                {
                    tipoSocio = cboTipo.SelectedItem.ToString().Equals("Socios", StringComparison.OrdinalIgnoreCase);
                }

                var repo = new Datos.TablaRepositorio();
                DataTable resultado = new DataTable();

                // Apply filters considering activity, tipo, deudores and "solo vencidos"
                DateTime hoy = DateTime.Today;

                // If radioDeudores is selected, show debtors (fechaVencimiento < hoy for socios, fechaAsistencia < hoy for no-socios)
                if (radioDeudores != null && radioDeudores.Checked)
                {
                    if (idActividad.HasValue)
                    {
                        if (tipoSocio)
                        {
                            resultado = repo.ObtenerSociosDeudoresPorActividad(idActividad.Value, hoy);
                        }
                        else
                        {
                            resultado = repo.ObtenerNoSociosDeudoresPorActividad(idActividad.Value, hoy);
                        }
                    }
                    else
                    {
                        if (tipoSocio)
                        {
                            resultado = repo.ObtenerSociosDeudores(hoy);
                        }
                        else
                        {
                            resultado = repo.ObtenerNoSociosDeudores(hoy);
                        }
                    }
                }
                else if (chkVencenHoy.Checked)
                {
                    // Show only those who must pay today
                    if (idActividad.HasValue)
                    {
                        if (tipoSocio)
                        {
                            resultado = repo.ObtenerSociosQueVencenHoyPorActividad(idActividad.Value, hoy);
                        }
                        else
                        {
                            resultado = repo.ObtenerNoSociosQueVencenHoyPorActividad(idActividad.Value, hoy);
                        }
                    }
                    else
                    {
                        if (tipoSocio)
                        {
                            resultado = repo.ObtenerSociosQueVencenHoy(hoy);
                        }
                        else
                        {
                            resultado = repo.ObtenerNoSociosQueVencenHoy(hoy);
                        }
                    }
                }
                else
                {
                    // Not "solo vencidos" nor deudores: list all matching by activity/type
                    if (idActividad.HasValue)
                    {
                        if (tipoSocio)
                        {
                            resultado = repo.ObtenerSociosPorActividad(idActividad.Value);
                        }
                        else
                        {
                            resultado = repo.ObtenerNoSociosPorActividad(idActividad.Value);
                        }
                    }
                    else
                    {
                        if (tipoSocio)
                        {
                            resultado = repo.ObtenerSocios();
                        }
                        else
                        {
                            resultado = repo.ObtenerNoSocios();
                        }
                    }
                }

                // Actualizar UI
                dgvDeudas.DataSource = resultado;
                dgvDeudas.AutoResizeColumns();
                // Actualizar resumen: mostrar total de registros en lblResumen
                try
                {
                    lblResumen.Text = string.Format("Total registros: {0}", resultado.Rows.Count);
                }
                catch { /* gui control may not exist in some layouts */ }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error aplicando filtros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper llamado por frmLogin para abrir FrmTabla con el filtro "Deben Pagar Hoy" activo
        public void SelectPagarHoy()
        {
            // Ensure form shows Socios that vencen hoy after login
            Action applyHoy = () =>
            {
                try
                {
                    // select socios and filter to vencen hoy
                    if (cboTipo.Items.Contains("Socios")) cboTipo.SelectedItem = "Socios";
                    chkVencenHoy.Checked = true;
                    ApplyFilters();
                }
                catch { /* swallow any UI timing errors */ }
            };

            if (this.IsHandleCreated)
            {
                applyHoy();
            }
            else
            {
                this.Load += (s, ev) => applyHoy();
            }
        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {
            try
            {
                // Poblar combobox de actividades (nombre + id) desde la BD
                try
                {
                    var repoAct = new Datos.ActividadRepositorio();
                    var tablaAct = repoAct.ObtenerActividades();

                    // Insertar opción "Todos" al principio para permitir mostrar todas las personas
                    if (tablaAct != null)
                    {
                        DataRow todosRow = tablaAct.NewRow();
                        if (tablaAct.Columns.Contains("Nombre")) todosRow["Nombre"] = "Todos";
                        // Use a sentinel value (0) for "Todos" so we don't insert a DBNull into a non-nullable IdActividad column.
                        if (tablaAct.Columns.Contains("IdActividad"))
                        {
                            try { todosRow["IdActividad"] = 0; } catch { /* ignore if assignment fails */ }
                        }
                        // Some schemas make the Importe column non-nullable; ensure we set a default value for the placeholder row.
                        if (tablaAct.Columns.Contains("Importe"))
                        {
                            try { todosRow["Importe"] = 0; } catch { /* ignore if assignment fails */ }
                        }
                        tablaAct.Rows.InsertAt(todosRow, 0);
                    }

                    cboActividad.DisplayMember = "Nombre";
                    cboActividad.ValueMember = "IdActividad";
                    cboActividad.DataSource = tablaAct;
                    // Seleccionar por defecto "Todos" (primera entrada)
                    if (cboActividad.Items.Count > 0) cboActividad.SelectedIndex = 0;
                }
                catch (Exception exAct)
                {
                    // No interrumpir carga de la grilla si falla la carga de actividades
                    MessageBox.Show("No se pudieron cargar las actividades: " + exAct.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Poblar tipo de persona con opciones fijas
                cboTipo.Items.Clear();
                cboTipo.Items.Add("Socios");
                cboTipo.Items.Add("No socios");
                cboTipo.SelectedIndex = 0;

                var repo = new Datos.TablaRepositorio();
                var tabla = repo.ObtenerSocios();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la tabla socios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvDeudas.DataSource = tabla;
                // Mostrar resumen inicial con la cantidad de registros (consistente con ApplyFilters/Default)
                try { lblResumen.Text = string.Format("Total registros: {0}", tabla.Rows.Count); } catch { }

                // Hacer columnas ocupar ancho completo de la grilla
                dgvDeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDeudas.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Establecer anchos mínimos razonables y peso fill por defecto
                foreach (DataGridViewColumn col in dgvDeudas.Columns)
                {
                    col.MinimumWidth = 60;
                    col.FillWeight = 100; // proporción por defecto
                }

                // Ajustar anchos relativos para columnas conocidas
                if (dgvDeudas.Columns.Contains("NroSocio")) dgvDeudas.Columns["NroSocio"].FillWeight = 10;
                if (dgvDeudas.Columns.Contains("DNI")) dgvDeudas.Columns["DNI"].FillWeight = 20;
                if (dgvDeudas.Columns.Contains("Nombre")) dgvDeudas.Columns["Nombre"].FillWeight = 35;
                if (dgvDeudas.Columns.Contains("Apellido")) dgvDeudas.Columns["Apellido"].FillWeight = 35;
                if (dgvDeudas.Columns.Contains("Telefono")) dgvDeudas.Columns["Telefono"].FillWeight = 20;

                dgvDeudas.AutoResizeColumns();

                // Asegurar que la grilla muestre al menos 6 filas de alto; usar RowTemplate.Height
                const int minVisibleRows = 6;
                int rowHeight = dgvDeudas.RowTemplate.Height;
                if (dgvDeudas.Rows.Count > 0)
                {
                // Si hay filas, usar la altura de la primera fila que puede reflejar autosize
                    rowHeight = dgvDeudas.Rows[0].Height;
                }

                int headerHeight = dgvDeudas.ColumnHeadersHeight;
                int desiredHeight = headerHeight + (rowHeight * minVisibleRows) + 4; // padding pequeño

                // Solo aumentar alto si actual es menor al deseado; sino mantener tamaño diseñador
                if (dgvDeudas.Height < desiredHeight)
                {
                    dgvDeudas.Height = desiredHeight;
                }

                // Habilitar barra scroll vertical si es necesario
                dgvDeudas.ScrollBars = ScrollBars.Vertical;
                // Asegurar que ningun filtro dispare búsquedas automáticas (ya hacemos todo con btnAplicar)
                cboActividad.SelectedValueChanged += (s, ev) => { /* no-op: filtro aplicado solo con botón */ };
                cboTipo.SelectedIndexChanged += (s, ev) => { /* no-op */ };
            }
            catch (MySql.Data.MySqlClient.MySqlException mex)
            {
                if (mex.Number == 1146)
                {
                    // Tabla no existe: mostrar tablas disponibles para diagnóstico
                    try
                    {
                        var repo = new Datos.TablaRepositorio();
                        var tablas = repo.ListarTablas();
                        dgvDeudas.DataSource = tablas;
                        dgvDeudas.AutoResizeColumns();
                        MessageBox.Show("La tabla 'socios' no existe en la base de datos. Mostrando tablas disponibles.", "Tabla no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Error al listar tablas: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Error al cargar datos: " + mex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
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

        private void btnDefault_Click(object sender, EventArgs e)
        {
            // Restablecer filtros y la grilla al estado inicial (mismo comportamiento que FrmTabla_Load)
            try
            {
                ResetToDefaultState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar filtros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Restablece los controles y la grilla al estado inicial usado en FrmTabla_Load.
        /// </summary>
        private void ResetToDefaultState()
        {
            // Seleccionar "Todos" en actividades si está disponible
            if (cboActividad.DataSource != null && cboActividad.Items.Count > 0)
            {
                cboActividad.SelectedIndex = 0;
            }

            // Restablecer tipo a Socios
            if (cboTipo.Items.Count > 0) cboTipo.SelectedIndex = 0;

            // Desmarcar "Solo vencidos"
            try { chkVencenHoy.Checked = false; } catch { }

            // Recargar la grilla con el conjunto por defecto (todos los socios)
            var repo = new Datos.TablaRepositorio();
            var tabla = repo.ObtenerSocios();

            dgvDeudas.DataSource = tabla;

            // Mantener las mismas configuraciones visuales que en Load
            dgvDeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeudas.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn col in dgvDeudas.Columns)
            {
                col.MinimumWidth = 60;
                col.FillWeight = 100;
            }

            if (dgvDeudas.Columns.Contains("NroSocio")) dgvDeudas.Columns["NroSocio"].FillWeight = 10;
            if (dgvDeudas.Columns.Contains("DNI")) dgvDeudas.Columns["DNI"].FillWeight = 20;
            if (dgvDeudas.Columns.Contains("Nombre")) dgvDeudas.Columns["Nombre"].FillWeight = 35;
            if (dgvDeudas.Columns.Contains("Apellido")) dgvDeudas.Columns["Apellido"].FillWeight = 35;
            if (dgvDeudas.Columns.Contains("Telefono")) dgvDeudas.Columns["Telefono"].FillWeight = 20;

            dgvDeudas.AutoResizeColumns();

            // Ajustar alto mínimo como en Load
            const int minVisibleRows = 6;
            int rowHeight = dgvDeudas.RowTemplate.Height;
            if (dgvDeudas.Rows.Count > 0)
            {
                rowHeight = dgvDeudas.Rows[0].Height;
            }

            int headerHeight = dgvDeudas.ColumnHeadersHeight;
            int desiredHeight = headerHeight + (rowHeight * minVisibleRows) + 4;
            if (dgvDeudas.Height < desiredHeight) dgvDeudas.Height = desiredHeight;

            dgvDeudas.ScrollBars = ScrollBars.Vertical;

            // Limpiar selección y llevar vista al inicio
            try
            {
                if (dgvDeudas.Rows.Count > 0)
                {
                    dgvDeudas.CurrentCell = dgvDeudas.Rows[0].Cells[0];
                    dgvDeudas.ClearSelection();
                }
            }
            catch { }

            try { lblResumen.Text = string.Format("Total registros: {0}", tabla.Rows.Count); } catch { }
        }
    }
}
