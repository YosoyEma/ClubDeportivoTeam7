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
    public partial class FrmCuota : Form
    {
        public FrmCuota()
        {
            InitializeComponent();
        }

        private void RadioBuscar_CheckedChanged(object sender, EventArgs e)
        {
            // Cuando cambia radio, limpiar entrada y detalles mostrados
            txtBuscar.Text = string.Empty;
            ClearSearchResults();
        }

        private void ClearSearchResults()
        {
            labelEstadoBusqueda.Text = string.Empty;
            labelDetalleTipo.Text = "-";
            labelDetalleEstado.Text = "-";
            labelDetalleActividad.Text = string.Empty;
            labelDetalleImporte.Text = string.Empty;
            labelCantidad.Text = "";
            labelDetalleFecha.Text = string.Empty;
        }

        private void ButtonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            ClearSearchResults();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var repo = new Datos.TablaRepositorio();

            // verificar tipo de búsqueda seleccionado
            if (!radioBuscarSocio.Checked && !radioBuscarNoSocio.Checked)
            {
                labelEstadoBusqueda.Text = "Seleccione tipo de búsqueda!";
                labelEstadoBusqueda.ForeColor = Color.Red;
                labelCantidad.Text = "";
                labelDetalleFecha.Text = string.Empty;
                return;
            }

            var input = txtBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                labelEstadoBusqueda.Text = "Ingrese valor de búsqueda!";
                labelEstadoBusqueda.ForeColor = Color.Red;
                labelCantidad.Text = "";
                labelDetalleFecha.Text = string.Empty;
                return;
            }

            if (radioBuscarSocio.Checked)
            {
                int nro;
                if (!int.TryParse(input, out nro))
                {
                    labelEstadoBusqueda.Text = "Socio no fue encontrado!";
                    labelEstadoBusqueda.ForeColor = Color.Red;
                    labelCantidad.Text = "";
                    labelDetalleFecha.Text = string.Empty;
                    return;
                }

                var row = repo.ObtenerSocioPorId(nro);
                if (row != null)
                {
                    labelEstadoBusqueda.Text = "Socio encontrado!";
                    labelEstadoBusqueda.ForeColor = Color.Green;
                    labelDetalleTipo.Text = "Socio";
                    labelDetalleEstado.Text = row.IsNull("estadoActivo")
                        ? "-"
                        : (Convert.ToInt32(row["estadoActivo"]) == 1 ? "Activo" : "Inactivo");
                    
                    var actividad = repo.ObtenerActividadPorInscripcionSocio(nro);
                    labelDetalleActividad.Text = string.IsNullOrEmpty(actividad) ? string.Empty : actividad;

                    // show latest cuota monto and pagada status
                    var cuotaRow = repo.ObtenerUltimaCuotaPorSocio(nro);
                    if (cuotaRow != null)
                    {
                        // monto may be null
                        if (!cuotaRow.IsNull("monto"))
                        {
                            double monto = Convert.ToDouble(cuotaRow["monto"]);
                            labelCantidad.Text = monto.ToString("N2", System.Globalization.CultureInfo.CurrentCulture);
                        }
                        else
                        {
                            labelCantidad.Text = "";
                        }

                        // pagada: tinyint(1)
                        if (!cuotaRow.IsNull("pagada"))
                        {
                            int pagada = Convert.ToInt32(cuotaRow["pagada"]);
                            labelDetalleImporte.Text = pagada == 1 ? "Pagada" : "Pendiente";
                        }
                        else
                        {
                            labelDetalleImporte.Text = string.Empty;
                        }
                        if (!cuotaRow.IsNull("fechaVencimiento"))
                        {
                            DateTime fv = Convert.ToDateTime(cuotaRow["fechaVencimiento"]);
                            labelDetalleFecha.Text = fv.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            labelDetalleFecha.Text = string.Empty;
                        }
                    }
                    else
                    {
                        labelCantidad.Text = "";
                        labelDetalleImporte.Text = string.Empty;
                        labelDetalleFecha.Text = string.Empty;
                    }
                }
                else
                {
                    labelEstadoBusqueda.Text = "Socio no fue encontrado!";
                    labelEstadoBusqueda.ForeColor = Color.Red;
                    
                    labelDetalleTipo.Text = "-";
                    labelDetalleEstado.Text = "-";
                    labelDetalleActividad.Text = string.Empty;
                    labelDetalleImporte.Text = string.Empty;
                    labelCantidad.Text = "";
                    labelDetalleFecha.Text = string.Empty;
                }
            }
            else if (radioBuscarNoSocio.Checked)
            {
                // search by nroVisita for no socio
                int nroVisita;
                if (!int.TryParse(input, out nroVisita))
                {
                    labelEstadoBusqueda.Text = "No Socio no fue encontrado!";
                    labelEstadoBusqueda.ForeColor = Color.Red;
                    labelCantidad.Text = "";
                    labelDetalleFecha.Text = string.Empty;
                    return;
                }

                var row = repo.ObtenerVisitaPorNro(nroVisita);
                if (row != null)
                {
                    labelEstadoBusqueda.Text = "No Socio encontrado!";
                    labelEstadoBusqueda.ForeColor = Color.Green;
                    labelDetalleTipo.Text = "No Socio";
                    labelDetalleEstado.Text = "-";
                    labelDetalleActividad.Text = row.IsNull("actividad") ? string.Empty : row["actividad"].ToString();

                    // show importe and pagado for visita
                    if (!row.IsNull("importe"))
                    {
                        decimal importe = Convert.ToDecimal(row["importe"]);
                        labelCantidad.Text = importe.ToString("N2", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    else
                    {
                        labelCantidad.Text = "Cantidad";
                    }

                    if (!row.IsNull("pagado"))
                    {
                        int pagado = Convert.ToInt32(row["pagado"]);
                        labelDetalleImporte.Text = pagado == 1 ? "Pagada" : "Pendiente";
                    }
                    else
                    {
                        labelDetalleImporte.Text = string.Empty;
                    }
                    if (!row.IsNull("fechaAsistencia"))
                    {
                        DateTime fa = Convert.ToDateTime(row["fechaAsistencia"]);
                        labelDetalleFecha.Text = fa.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        labelDetalleFecha.Text = string.Empty;
                    }
                }
                else
                {
                    labelEstadoBusqueda.Text = "No Socio no fue encontrado!";
                    labelEstadoBusqueda.ForeColor = Color.Red;

                    
                    labelDetalleTipo.Text = "-";
                    labelDetalleEstado.Text = "-";
                    labelDetalleActividad.Text = string.Empty;
                    labelDetalleImporte.Text = string.Empty;
                    labelCantidad.Text = "";
                    labelDetalleFecha.Text = string.Empty;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
