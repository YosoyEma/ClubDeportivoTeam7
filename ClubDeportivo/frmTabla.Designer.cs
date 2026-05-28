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
            this.cboPlan = new System.Windows.Forms.ComboBox();

            this.chkSoloVencidos = new System.Windows.Forms.CheckBox();

            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();

            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();

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
            this.groupBoxFiltros.Controls.Add(this.cboPlan);

            this.groupBoxFiltros.Controls.Add(this.chkSoloVencidos);

            this.groupBoxFiltros.Controls.Add(this.lblDesde);
            this.groupBoxFiltros.Controls.Add(this.dtpDesde);

            this.groupBoxFiltros.Controls.Add(this.lblHasta);
            this.groupBoxFiltros.Controls.Add(this.dtpHasta);

            this.groupBoxFiltros.Controls.Add(this.btnAplicar);
            this.groupBoxFiltros.Controls.Add(this.btnDefault);

            this.groupBoxFiltros.Location = new System.Drawing.Point(20, 20);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(1105, 80);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";

            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(12, 34);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(56, 13);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";

            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(100, 30);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(100, 21);
            this.cboActividad.TabIndex = 1;

            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(215, 34);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(31, 13);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Plan:";

            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(270, 30);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(100, 21);
            this.cboPlan.TabIndex = 3;

            // 
            // chkSoloVencidos
            // 
            this.chkSoloVencidos.AutoSize = true;
            this.chkSoloVencidos.Location = new System.Drawing.Point(390, 32);
            this.chkSoloVencidos.Name = "chkSoloVencidos";
            this.chkSoloVencidos.Size = new System.Drawing.Size(99, 17);
            this.chkSoloVencidos.TabIndex = 4;
            this.chkSoloVencidos.Text = "Solo vencidos";
            this.chkSoloVencidos.UseVisualStyleBackColor = true;

            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(530, 34);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 5;
            this.lblDesde.Text = "Desde:";

            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(590, 30);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpDesde.TabIndex = 6;

            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(705, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "Hasta:";

            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(760, 30);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpHasta.TabIndex = 8;

            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(885, 28);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(70, 25);
            this.btnAplicar.TabIndex = 9;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;

            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(965, 28);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(95, 25);
            this.btnDefault.TabIndex = 10;
            this.btnDefault.Text = "por defecto";
            this.btnDefault.UseVisualStyleBackColor = true;

            // 
            // dgvDeudas
            // 
            this.dgvDeudas.AllowUserToAddRows = false;
            this.dgvDeudas.AllowUserToDeleteRows = false;
            this.dgvDeudas.AllowUserToResizeRows = false;
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Location = new System.Drawing.Point(20, 120);
            this.dgvDeudas.MultiSelect = false;
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.ReadOnly = true;
            this.dgvDeudas.RowHeadersVisible = false;
            this.dgvDeudas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeudas.Size = new System.Drawing.Size(1105, 215);
            this.dgvDeudas.TabIndex = 1;

            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(20, 375);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(250, 13);
            this.lblResumen.TabIndex = 2;
            this.lblResumen.Text = "Total Vencidos: n   Total dinero: n   Seleccionados: n";

            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(600, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnVolver_Click);

            // btnRecordatorio
            // 
            this.btnRecordatorio.Location = new System.Drawing.Point(740, 360);
            this.btnRecordatorio.Name = "btnRecordatorio";
            this.btnRecordatorio.Size = new System.Drawing.Size(135, 32);
            this.btnRecordatorio.TabIndex = 3;
            this.btnRecordatorio.Text = "Enviar recordatorio";
            this.btnRecordatorio.UseVisualStyleBackColor = true;

            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(885, 360);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(105, 32);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = true;

            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(1000, 360);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(115, 32);
            this.btnRegistrarPago.TabIndex = 5;
            this.btnRegistrarPago.Text = "Registrar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;

            // 
            // deudaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 421);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRecordatorio);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.dgvDeudas);
            this.Controls.Add(this.groupBoxFiltros);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "deudaSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club deportivo - Deudas de socios";

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
        private System.Windows.Forms.ComboBox cboPlan;

        private System.Windows.Forms.CheckBox chkSoloVencidos;

        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;

        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;

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
