namespace ClubDeportivo
{
    partial class FrmTabla
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        /// <param name="disposing">true si se deben liberar recursos administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        /// <summary>
        /// Método requerido para el diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.chkVencenHoy = new System.Windows.Forms.RadioButton();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnRecordatorio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.radioDeudores = new System.Windows.Forms.RadioButton();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.radioDeudores);
            this.groupBoxFiltros.Controls.Add(this.lblActividad);
            this.groupBoxFiltros.Controls.Add(this.cboActividad);
            this.groupBoxFiltros.Controls.Add(this.lblPlan);
            this.groupBoxFiltros.Controls.Add(this.cboTipo);
            this.groupBoxFiltros.Controls.Add(this.chkVencenHoy);
            this.groupBoxFiltros.Controls.Add(this.btnAplicar);
            this.groupBoxFiltros.Controls.Add(this.btnDefault);
            this.groupBoxFiltros.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(715, 80);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(8, 34);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad:";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(75, 32);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(100, 21);
            this.cboActividad.TabIndex = 1;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(188, 35);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(31, 13);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(232, 32);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(100, 21);
            this.cboTipo.TabIndex = 3;
            // 
            // chkVencenHoy
            // 
            this.chkVencenHoy.AutoSize = true;
            this.chkVencenHoy.Location = new System.Drawing.Point(430, 34);
            this.chkVencenHoy.Name = "chkVencenHoy";
            this.chkVencenHoy.Size = new System.Drawing.Size(85, 17);
            this.chkVencenHoy.TabIndex = 4;
            this.chkVencenHoy.TabStop = true;
            this.chkVencenHoy.Text = "Vencen Hoy";
            this.chkVencenHoy.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(528, 28);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(70, 25);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(611, 27);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(95, 25);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "Por defecto";
            this.btnDefault.UseVisualStyleBackColor = true;
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.AllowUserToAddRows = false;
            this.dgvDeudas.AllowUserToDeleteRows = false;
            this.dgvDeudas.AllowUserToResizeRows = false;
            this.dgvDeudas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Location = new System.Drawing.Point(20, 140);
            this.dgvDeudas.MultiSelect = false;
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.ReadOnly = true;
            this.dgvDeudas.RowHeadersVisible = false;
            this.dgvDeudas.RowHeadersWidth = 51;
            this.dgvDeudas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeudas.Size = new System.Drawing.Size(715, 215);
            this.dgvDeudas.TabIndex = 1;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(17, 115);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(76, 13);
            this.lblResumen.TabIndex = 2;
            this.lblResumen.Text = "Total Registro:";
            // 
            // btnRecordatorio
            // 
            this.btnRecordatorio.Location = new System.Drawing.Point(360, 395);
            this.btnRecordatorio.Name = "btnRecordatorio";
            this.btnRecordatorio.Size = new System.Drawing.Size(135, 32);
            this.btnRecordatorio.TabIndex = 3;
            this.btnRecordatorio.Text = "Enviar recordatorio";
            this.btnRecordatorio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(220, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(505, 395);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 32);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(620, 395);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(115, 32);
            this.btnRegistrarPago.TabIndex = 5;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // radioDeudores
            // 
            this.radioDeudores.AutoSize = true;
            this.radioDeudores.Location = new System.Drawing.Point(340, 34);
            this.radioDeudores.Name = "radioDeudores";
            this.radioDeudores.Size = new System.Drawing.Size(71, 17);
            this.radioDeudores.TabIndex = 12;
            this.radioDeudores.TabStop = true;
            this.radioDeudores.Text = "Deudores";
            this.radioDeudores.UseVisualStyleBackColor = true;
            // 
            // FrmTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 458);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRecordatorio);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.dgvDeudas);
            this.Controls.Add(this.groupBoxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Listado de vencimientos";
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cboActividad;

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboTipo;

        private System.Windows.Forms.RadioButton chkVencenHoy;

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnDefault;

        private System.Windows.Forms.DataGridView dgvDeudas;

        private System.Windows.Forms.Label lblResumen;

        private System.Windows.Forms.Button btnRecordatorio;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton radioDeudores;
    }
}
