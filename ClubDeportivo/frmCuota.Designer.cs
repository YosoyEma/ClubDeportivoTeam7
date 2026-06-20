using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    partial class FrmCuota
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos utilizados.
        /// </summary>
        /// <param name="disposing">true si se deben liberar recursos administrados; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Método requerido para soporte del Diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSocio = new System.Windows.Forms.GroupBox();
            this.buttonLimpiarBusqueda = new System.Windows.Forms.Button();
            this.radioBuscarNoSocio = new System.Windows.Forms.RadioButton();
            this.radioBuscarSocio = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.groupBoxCuota = new System.Windows.Forms.GroupBox();
            this.labelDetalleFecha = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelDetalleCantidad = new System.Windows.Forms.Label();
            this.labelDetalleImporte = new System.Windows.Forms.Label();
            this.labelDetalleEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDetalleTipo = new System.Windows.Forms.Label();
            this.labelEstadoDeuda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDetalleActividad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoSocio = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelEstadoBusqueda = new System.Windows.Forms.Label();
            this.labelVencimiento = new System.Windows.Forms.Label();
            this.groupBoxSocio.SuspendLayout();
            this.groupBoxCuota.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSocio
            // 
            this.groupBoxSocio.Controls.Add(this.buttonLimpiarBusqueda);
            this.groupBoxSocio.Controls.Add(this.radioBuscarNoSocio);
            this.groupBoxSocio.Controls.Add(this.radioBuscarSocio);
            this.groupBoxSocio.Controls.Add(this.btnBuscar);
            this.groupBoxSocio.Controls.Add(this.txtBuscar);
            this.groupBoxSocio.Controls.Add(this.lblBuscar);
            this.groupBoxSocio.Location = new System.Drawing.Point(20, 20);
            this.groupBoxSocio.Name = "groupBoxSocio";
            this.groupBoxSocio.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxSocio.Size = new System.Drawing.Size(399, 110);
            this.groupBoxSocio.TabIndex = 0;
            this.groupBoxSocio.TabStop = false;
            this.groupBoxSocio.Text = "Buscar";
            // 
            // buttonLimpiarBusqueda
            // 
            this.buttonLimpiarBusqueda.Location = new System.Drawing.Point(331, 59);
            this.buttonLimpiarBusqueda.Name = "buttonLimpiarBusqueda";
            this.buttonLimpiarBusqueda.Size = new System.Drawing.Size(60, 23);
            this.buttonLimpiarBusqueda.TabIndex = 5;
            this.buttonLimpiarBusqueda.Text = "Limpiar";
            this.buttonLimpiarBusqueda.UseVisualStyleBackColor = true;
            this.buttonLimpiarBusqueda.Click += new System.EventHandler(this.ButtonLimpiarBusqueda_Click);
            // 
            // radioBuscarNoSocio
            // 
            this.radioBuscarNoSocio.AutoSize = true;
            this.radioBuscarNoSocio.Location = new System.Drawing.Point(69, 32);
            this.radioBuscarNoSocio.Name = "radioBuscarNoSocio";
            this.radioBuscarNoSocio.Size = new System.Drawing.Size(69, 17);
            this.radioBuscarNoSocio.TabIndex = 4;
            this.radioBuscarNoSocio.TabStop = true;
            this.radioBuscarNoSocio.Text = "No Socio";
            this.radioBuscarNoSocio.UseVisualStyleBackColor = true;
            this.radioBuscarNoSocio.CheckedChanged += new System.EventHandler(this.RadioBuscar_CheckedChanged);
            // 
            // radioBuscarSocio
            // 
            this.radioBuscarSocio.AutoSize = true;
            this.radioBuscarSocio.Checked = true;
            this.radioBuscarSocio.Location = new System.Drawing.Point(15, 32);
            this.radioBuscarSocio.Name = "radioBuscarSocio";
            this.radioBuscarSocio.Size = new System.Drawing.Size(52, 17);
            this.radioBuscarSocio.TabIndex = 3;
            this.radioBuscarSocio.TabStop = true;
            this.radioBuscarSocio.Text = "Socio";
            this.radioBuscarSocio.UseVisualStyleBackColor = true;
            this.radioBuscarSocio.CheckedChanged += new System.EventHandler(this.RadioBuscar_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(265, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(114, 62);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 65);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(96, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar(Nro Socio):";
            // 
            // groupBoxCuota
            // 
            this.groupBoxCuota.Controls.Add(this.labelVencimiento);
            this.groupBoxCuota.Controls.Add(this.labelDetalleFecha);
            this.groupBoxCuota.Controls.Add(this.labelCantidad);
            this.groupBoxCuota.Controls.Add(this.labelDetalleCantidad);
            this.groupBoxCuota.Controls.Add(this.labelDetalleImporte);
            this.groupBoxCuota.Controls.Add(this.labelDetalleEstado);
            this.groupBoxCuota.Controls.Add(this.label5);
            this.groupBoxCuota.Controls.Add(this.labelDetalleTipo);
            this.groupBoxCuota.Controls.Add(this.labelEstadoDeuda);
            this.groupBoxCuota.Controls.Add(this.label4);
            this.groupBoxCuota.Controls.Add(this.labelDetalleActividad);
            this.groupBoxCuota.Controls.Add(this.label1);
            this.groupBoxCuota.Controls.Add(this.lblInfoSocio);
            this.groupBoxCuota.Controls.Add(this.dtpFecha);
            this.groupBoxCuota.Controls.Add(this.lblFecha);
            this.groupBoxCuota.Location = new System.Drawing.Point(20, 184);
            this.groupBoxCuota.Name = "groupBoxCuota";
            this.groupBoxCuota.Size = new System.Drawing.Size(399, 188);
            this.groupBoxCuota.TabIndex = 1;
            this.groupBoxCuota.TabStop = false;
            this.groupBoxCuota.Text = "Detalles";
            // 
            // labelDetalleFecha
            // 
            this.labelDetalleFecha.AutoSize = true;
            this.labelDetalleFecha.Location = new System.Drawing.Point(312, 110);
            this.labelDetalleFecha.Name = "labelDetalleFecha";
            this.labelDetalleFecha.Size = new System.Drawing.Size(34, 13);
            this.labelDetalleFecha.TabIndex = 20;
            this.labelDetalleFecha.Text = "fecha";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(69, 110);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 18;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelDetalleCantidad
            // 
            this.labelDetalleCantidad.AutoSize = true;
            this.labelDetalleCantidad.Location = new System.Drawing.Point(6, 110);
            this.labelDetalleCantidad.Name = "labelDetalleCantidad";
            this.labelDetalleCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelDetalleCantidad.TabIndex = 17;
            this.labelDetalleCantidad.Text = "Cantidad:";
            // 
            // labelDetalleImporte
            // 
            this.labelDetalleImporte.AutoSize = true;
            this.labelDetalleImporte.Location = new System.Drawing.Point(276, 79);
            this.labelDetalleImporte.Name = "labelDetalleImporte";
            this.labelDetalleImporte.Size = new System.Drawing.Size(99, 13);
            this.labelDetalleImporte.TabIndex = 16;
            this.labelDetalleImporte.Text = "pagado/no pagado";
            // 
            // labelDetalleEstado
            // 
            this.labelDetalleEstado.AutoSize = true;
            this.labelDetalleEstado.Location = new System.Drawing.Point(69, 79);
            this.labelDetalleEstado.Name = "labelDetalleEstado";
            this.labelDetalleEstado.Size = new System.Drawing.Size(89, 13);
            this.labelDetalleEstado.TabIndex = 15;
            this.labelDetalleEstado.Text = "Activo/inabilitado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Actividad: ";
            // 
            // labelDetalleTipo
            // 
            this.labelDetalleTipo.AutoSize = true;
            this.labelDetalleTipo.Location = new System.Drawing.Point(69, 50);
            this.labelDetalleTipo.Name = "labelDetalleTipo";
            this.labelDetalleTipo.Size = new System.Drawing.Size(78, 13);
            this.labelDetalleTipo.TabIndex = 13;
            this.labelDetalleTipo.Text = "Socio/noSocio";
            // 
            // labelEstadoDeuda
            // 
            this.labelEstadoDeuda.AutoSize = true;
            this.labelEstadoDeuda.Location = new System.Drawing.Point(194, 79);
            this.labelEstadoDeuda.Name = "labelEstadoDeuda";
            this.labelEstadoDeuda.Size = new System.Drawing.Size(76, 13);
            this.labelEstadoDeuda.TabIndex = 12;
            this.labelEstadoDeuda.Text = "Estado deuda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estado:";
            // 
            // labelDetalleActividad
            // 
            this.labelDetalleActividad.AutoSize = true;
            this.labelDetalleActividad.Location = new System.Drawing.Point(276, 50);
            this.labelDetalleActividad.Name = "labelDetalleActividad";
            this.labelDetalleActividad.Size = new System.Drawing.Size(50, 13);
            this.labelDetalleActividad.TabIndex = 10;
            this.labelDetalleActividad.Text = "actividad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo: ";
            // 
            // lblInfoSocio
            // 
            this.lblInfoSocio.AutoSize = true;
            this.lblInfoSocio.Location = new System.Drawing.Point(6, 26);
            this.lblInfoSocio.Name = "lblInfoSocio";
            this.lblInfoSocio.Size = new System.Drawing.Size(67, 13);
            this.lblInfoSocio.TabIndex = 8;
            this.lblInfoSocio.Text = "Info Persona";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(69, 155);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(231, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 155);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(114, 400);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(249, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(339, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // labelEstadoBusqueda
            // 
            this.labelEstadoBusqueda.AutoSize = true;
            this.labelEstadoBusqueda.Location = new System.Drawing.Point(172, 152);
            this.labelEstadoBusqueda.Name = "labelEstadoBusqueda";
            this.labelEstadoBusqueda.Size = new System.Drawing.Size(91, 13);
            this.labelEstadoBusqueda.TabIndex = 5;
            this.labelEstadoBusqueda.Text = "Estado Busqueda";
            // 
            // labelVencimiento
            // 
            this.labelVencimiento.AutoSize = true;
            this.labelVencimiento.Location = new System.Drawing.Point(194, 110);
            this.labelVencimiento.Name = "labelVencimiento";
            this.labelVencimiento.Size = new System.Drawing.Size(112, 13);
            this.labelVencimiento.TabIndex = 21;
            this.labelVencimiento.Text = "fecha de vencimiento:";
            // 
            // FrmCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 454);
            this.Controls.Add(this.labelEstadoBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBoxCuota);
            this.Controls.Add(this.groupBoxSocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Registrar cuota";
            this.groupBoxSocio.ResumeLayout(false);
            this.groupBoxSocio.PerformLayout();
            this.groupBoxCuota.ResumeLayout(false);
            this.groupBoxCuota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSocio;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.GroupBox groupBoxCuota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private Label labelDetalleActividad;
        private Label label1;
        private Label lblInfoSocio;
        private Label labelEstadoBusqueda;
        private RadioButton radioBuscarNoSocio;
        private RadioButton radioBuscarSocio;
        private Button buttonLimpiarBusqueda;
        private Label labelDetalleTipo;
        private Label labelEstadoDeuda;
        private Label label4;
        private Label label5;
        private Label labelDetalleImporte;
        private Label labelDetalleEstado;
        private Label labelCantidad;
        private Label labelDetalleCantidad;
        private Label labelDetalleFecha;
        private Label labelVencimiento;
    }
}
