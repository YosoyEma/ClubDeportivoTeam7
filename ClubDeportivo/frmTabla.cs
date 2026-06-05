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
        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {
            try
            {
                var repo = new Datos.TablaRepositorio();
                var tabla = repo.ObtenerSocios();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la tabla socios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvDeudas.DataSource = tabla;

                // Make columns fill the full width of the grid
                dgvDeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDeudas.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Set sensible minimum widths and default fill weight
                foreach (DataGridViewColumn col in dgvDeudas.Columns)
                {
                    col.MinimumWidth = 60;
                    col.FillWeight = 100; // default proportion
                }

                // Adjust relative widths for known columns
                if (dgvDeudas.Columns.Contains("NroSocio")) dgvDeudas.Columns["NroSocio"].FillWeight = 10;
                if (dgvDeudas.Columns.Contains("DNI")) dgvDeudas.Columns["DNI"].FillWeight = 20;
                if (dgvDeudas.Columns.Contains("Nombre")) dgvDeudas.Columns["Nombre"].FillWeight = 35;
                if (dgvDeudas.Columns.Contains("Apellido")) dgvDeudas.Columns["Apellido"].FillWeight = 35;
                if (dgvDeudas.Columns.Contains("Telefono")) dgvDeudas.Columns["Telefono"].FillWeight = 20;

                dgvDeudas.AutoResizeColumns();

                // Ensure the grid shows at least 6 rows in height; use RowTemplate.Height as baseline
                const int minVisibleRows = 6;
                int rowHeight = dgvDeudas.RowTemplate.Height;
                if (dgvDeudas.Rows.Count > 0)
                {
                    // If rows exist, use the first row height which may reflect autosizing
                    rowHeight = dgvDeudas.Rows[0].Height;
                }

                int headerHeight = dgvDeudas.ColumnHeadersHeight;
                int desiredHeight = headerHeight + (rowHeight * minVisibleRows) + 4; // small padding

                // Only increase height if current height is smaller than desired; otherwise keep designer size
                if (dgvDeudas.Height < desiredHeight)
                {
                    dgvDeudas.Height = desiredHeight;
                }

                // Enable vertical scrollbar if needed
                dgvDeudas.ScrollBars = ScrollBars.Vertical;
            }
            catch (MySql.Data.MySqlClient.MySqlException mex)
            {
                if (mex.Number == 1146)
                {
                    // Table doesn't exist: show available tables to help diagnose
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
    }
}
