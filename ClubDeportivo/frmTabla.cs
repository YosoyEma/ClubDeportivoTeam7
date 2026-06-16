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
    }
}
