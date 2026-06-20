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
            // limpiar entradas
            if (txtBuscar != null) txtBuscar.Text = string.Empty;
            if (dtpFecha != null) dtpFecha.Value = DateTime.Today;
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

                    // mostrar monto de la última cuota y estado de pago
                    var cuotaRow = repo.ObtenerUltimaCuotaPorSocio(nro);
                    if (cuotaRow != null)
                    {
                        // monto may be null
                        // el monto puede ser nulo
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
                // buscar por nroVisita para no socio
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

                    // mostrar importe y estado de pago para la visita
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Manejar pago de socio
            if (radioBuscarSocio.Checked)
            {
                // parsear nro de socio desde txtBuscar
                int nro;
                if (!int.TryParse(txtBuscar.Text.Trim(), out nro))
                {
                    MessageBox.Show("Ingrese número de socio válido antes de cobrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var repo = new Datos.CuotaRepositorio();
                DateTime ahora = DateTime.Now;
                string resp = repo.CobrarCuotaSocio(nro, ahora);

                if (resp == "1")
                {
                    MessageBox.Show("Pago registrado correctamente.", "Pago OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Volver a ejecutar la búsqueda para refrescar los datos del socio y mostrar el estado actualizado
                    BtnBuscar_Click(this, EventArgs.Empty);
                    // No limpiar los resultados inmediatamente: mantener los datos visibles
                    // para que el usuario pueda ver la re-activación (estadoActivo) realizada por el procedimiento.
                }
                else if (resp == "0")
                {
                    MessageBox.Show("No existen cuotas pendientes para este socio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error registrando pago: " + resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }

            // Manejar pago de no socio
            if (radioBuscarNoSocio.Checked)
            {
                int nroVisita;
                if (!int.TryParse(txtBuscar.Text.Trim(), out nroVisita))
                {
                    MessageBox.Show("Ingrese número de visita válido antes de cobrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tablaRepo = new Datos.TablaRepositorio();
                var visitaRow = tablaRepo.ObtenerVisitaPorNro(nroVisita);
                if (visitaRow == null)
                {
                    MessageBox.Show("Visita no encontrada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validate pending
                if (!visitaRow.IsNull("pagado") && Convert.ToInt32(visitaRow["pagado"]) == 1)
                {
                    MessageBox.Show("La visita ya fue abonada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (visitaRow.IsNull("idVisitaActividad"))
                {
                    MessageBox.Show("Id de visita inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idVisitaActividad = Convert.ToInt32(visitaRow["idVisitaActividad"]);
                DateTime fechaPago = dtpFecha != null ? dtpFecha.Value : DateTime.Now;

                var visitaRepo = new Datos.VisitaRepositorio();
                string respuesta = visitaRepo.CobrarVisitaNoSocio(idVisitaActividad, fechaPago);

                if (respuesta == "1")
                {
                    MessageBox.Show("Pago registrado correctamente.", "Pago OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnBuscar_Click(this, EventArgs.Empty);
                    ClearSearchResults();
                }
                else if (respuesta == "0")
                {
                    MessageBox.Show("La visita no existe o ya fue abonada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error registrando pago: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }
        }

    }
}
