using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    partial class FrmCuota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxSocio = new GroupBox();
            lblInfoSocio = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            groupBoxCuota = new GroupBox();
            cboPeriodo = new ComboBox();
            dtpFecha = new DateTimePicker();
            txtCantidad = new TextBox();
            cboConcepto = new ComboBox();
            lblPeriodo = new Label();
            lblFecha = new Label();
            lblCantidad = new Label();
            lblConcepto = new Label();
            btnImprimir = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBoxSocio.SuspendLayout();
            groupBoxCuota.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSocio
            // 
            groupBoxSocio.Controls.Add(lblInfoSocio);
            groupBoxSocio.Controls.Add(btnBuscar);
            groupBoxSocio.Controls.Add(txtBuscar);
            groupBoxSocio.Controls.Add(lblBuscar);
            groupBoxSocio.Location = new Point(23, 23);
            groupBoxSocio.Margin = new Padding(4, 3, 4, 3);
            groupBoxSocio.Name = "groupBoxSocio";
            groupBoxSocio.Padding = new Padding(4, 3, 4, 3);
            groupBoxSocio.Size = new Size(516, 150);
            groupBoxSocio.TabIndex = 0;
            groupBoxSocio.TabStop = false;
            groupBoxSocio.Text = "Socio";
            // 
            // lblInfoSocio
            // 
            lblInfoSocio.AutoSize = true;
            lblInfoSocio.Location = new Point(29, 90);
            lblInfoSocio.Margin = new Padding(4, 0, 4, 0);
            lblInfoSocio.Name = "lblInfoSocio";
            lblInfoSocio.Size = new Size(224, 30);
            lblInfoSocio.TabIndex = 3;
            lblInfoSocio.Text = "Info Socio\r\nPlan: Anual   Estado: activo   deuda: $0.00";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(379, 38);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(111, 40);
            txtBuscar.Margin = new Padding(4, 3, 4, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(29, 44);
            lblBuscar.Margin = new Padding(4, 0, 4, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // groupBoxCuota
            // 
            groupBoxCuota.Controls.Add(cboPeriodo);
            groupBoxCuota.Controls.Add(dtpFecha);
            groupBoxCuota.Controls.Add(txtCantidad);
            groupBoxCuota.Controls.Add(cboConcepto);
            groupBoxCuota.Controls.Add(lblPeriodo);
            groupBoxCuota.Controls.Add(lblFecha);
            groupBoxCuota.Controls.Add(lblCantidad);
            groupBoxCuota.Controls.Add(lblConcepto);
            groupBoxCuota.Location = new Point(23, 196);
            groupBoxCuota.Margin = new Padding(4, 3, 4, 3);
            groupBoxCuota.Name = "groupBoxCuota";
            groupBoxCuota.Padding = new Padding(4, 3, 4, 3);
            groupBoxCuota.Size = new Size(516, 208);
            groupBoxCuota.TabIndex = 1;
            groupBoxCuota.TabStop = false;
            groupBoxCuota.Text = "Detalles de la cuota";
            // 
            // cboPeriodo
            // 
            cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriodo.FormattingEnabled = true;
            cboPeriodo.Location = new Point(175, 158);
            cboPeriodo.Margin = new Padding(4, 3, 4, 3);
            cboPeriodo.Name = "cboPeriodo";
            cboPeriodo.Size = new Size(297, 23);
            cboPeriodo.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(175, 118);
            dtpFecha.Margin = new Padding(4, 3, 4, 3);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(297, 23);
            dtpFecha.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(175, 77);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(297, 23);
            txtCantidad.TabIndex = 5;
            // 
            // cboConcepto
            // 
            cboConcepto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConcepto.FormattingEnabled = true;
            cboConcepto.Location = new Point(175, 37);
            cboConcepto.Margin = new Padding(4, 3, 4, 3);
            cboConcepto.Name = "cboConcepto";
            cboConcepto.Size = new Size(297, 23);
            cboConcepto.TabIndex = 4;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(29, 162);
            lblPeriodo.Margin = new Padding(4, 0, 4, 0);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(51, 15);
            lblPeriodo.TabIndex = 3;
            lblPeriodo.Text = "Periodo:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(29, 121);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(29, 81);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(29, 40);
            lblConcepto.Margin = new Padding(4, 0, 4, 0);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(62, 15);
            lblConcepto.TabIndex = 0;
            lblConcepto.Text = "Concepto:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(182, 439);
            btnImprimir.Margin = new Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(140, 35);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir Factura";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(339, 439);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 35);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(445, 439);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new EventHandler(this.BtnCancelar_Click);
            // 
            // frCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 498);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnImprimir);
            Controls.Add(groupBoxCuota);
            Controls.Add(groupBoxSocio);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Registrar cuota";
            groupBoxSocio.ResumeLayout(false);
            groupBoxSocio.PerformLayout();
            groupBoxCuota.ResumeLayout(false);
            groupBoxCuota.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSocio;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblInfoSocio;

        private System.Windows.Forms.GroupBox groupBoxCuota;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPeriodo;

        private System.Windows.Forms.ComboBox cboConcepto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboPeriodo;

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
