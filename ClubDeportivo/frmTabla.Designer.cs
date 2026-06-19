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
            this.chkSoloVencidos = new System.Windows.Forms.CheckBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnRecordatorio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.lblActividad);
            this.groupBoxFiltros.Controls.Add(this.cboActividad);
            this.groupBoxFiltros.Controls.Add(this.lblPlan);
            this.groupBoxFiltros.Controls.Add(this.cboTipo);
            this.groupBoxFiltros.Controls.Add(this.chkSoloVencidos);
            this.groupBoxFiltros.Controls.Add(this.btnAplicar);
            this.groupBoxFiltros.Controls.Add(this.btnDefault);
            this.groupBoxFiltros.Location = new System.Drawing.Point(27, 25);
            this.groupBoxFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFiltros.Size = new System.Drawing.Size(953, 98);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(28, 42);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(66, 16);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad:";
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(125, 39);
            this.cboActividad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(132, 24);
            this.cboActividad.TabIndex = 1;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(288, 43);
            this.lblPlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(37, 16);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(359, 38);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(132, 24);
            this.cboTipo.TabIndex = 3;
            // 
            // chkSoloVencidos
            // 
            this.chkSoloVencidos.AutoSize = true;
            this.chkSoloVencidos.Location = new System.Drawing.Point(521, 42);
            this.chkSoloVencidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSoloVencidos.Name = "chkSoloVencidos";
            this.chkSoloVencidos.Size = new System.Drawing.Size(115, 20);
            this.chkSoloVencidos.TabIndex = 4;
            this.chkSoloVencidos.Text = "Solo vencidos";
            this.chkSoloVencidos.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(675, 34);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(93, 31);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(797, 33);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(127, 31);
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
            this.dgvDeudas.Location = new System.Drawing.Point(27, 172);
            this.dgvDeudas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDeudas.MultiSelect = false;
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.ReadOnly = true;
            this.dgvDeudas.RowHeadersVisible = false;
            this.dgvDeudas.RowHeadersWidth = 51;
            this.dgvDeudas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeudas.Size = new System.Drawing.Size(953, 265);
            this.dgvDeudas.TabIndex = 1;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(23, 142);
            this.lblResumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(95, 16);
            this.lblResumen.TabIndex = 2;
            this.lblResumen.Text = "Total Registro:";
            // 
            // btnRecordatorio
            // 
            this.btnRecordatorio.Location = new System.Drawing.Point(480, 486);
            this.btnRecordatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecordatorio.Name = "btnRecordatorio";
            this.btnRecordatorio.Size = new System.Drawing.Size(180, 39);
            this.btnRecordatorio.TabIndex = 3;
            this.btnRecordatorio.Text = "Enviar recordatorio";
            this.btnRecordatorio.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 486);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 39);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(673, 486);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(140, 39);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(827, 486);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(153, 39);
            this.btnRegistrarPago.TabIndex = 5;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // FrmTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 564);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRecordatorio);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.dgvDeudas);
            this.Controls.Add(this.groupBoxFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

        private System.Windows.Forms.CheckBox chkSoloVencidos;

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnDefault;

        private System.Windows.Forms.DataGridView dgvDeudas;

        private System.Windows.Forms.Label lblResumen;

        private System.Windows.Forms.Button btnRecordatorio;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnCancelar;
    }
}
