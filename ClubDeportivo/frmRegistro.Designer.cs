namespace ClubDeportivo
{
    partial class frmRegistro
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSocio = new System.Windows.Forms.TabPage();
            this.socioTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBoxMembresia = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboHorarios = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPlanPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSocio.SuspendLayout();
            this.socioTable.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMembresia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.3203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.6797F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 331);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // tabControl
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.tabPageSocio);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 15);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(613, 266);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabPageSocio
            // 
            this.tabPageSocio.Controls.Add(this.socioTable);
            this.tabPageSocio.Location = new System.Drawing.Point(4, 25);
            this.tabPageSocio.Name = "tabPageSocio";
            this.tabPageSocio.Size = new System.Drawing.Size(605, 237);
            this.tabPageSocio.TabIndex = 0;
            this.tabPageSocio.Text = "Socio";
            // 
            // socioTable
            // 
            this.socioTable.ColumnCount = 2;
            this.socioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.socioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.socioTable.Controls.Add(this.groupBox1, 0, 0);
            this.socioTable.Controls.Add(this.groupBoxMembresia, 1, 0);
            this.socioTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.socioTable.Location = new System.Drawing.Point(0, 0);
            this.socioTable.Margin = new System.Windows.Forms.Padding(0);
            this.socioTable.Name = "socioTable";
            this.socioTable.RowCount = 1;
            this.socioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.socioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.socioTable.Size = new System.Drawing.Size(605, 237);
            this.socioTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(302, 237);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 44);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 93);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 22);
            this.txtApellido.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(22, 143);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(261, 22);
            this.txtDNI.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Télefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 195);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(261, 22);
            this.txtTelefono.TabIndex = 21;
            // 
            // groupBoxMembresia
            // 
            this.groupBoxMembresia.Controls.Add(this.dtpFechaInicio);
            this.groupBoxMembresia.Controls.Add(this.label7);
            this.groupBoxMembresia.Controls.Add(this.cboActividad);
            this.groupBoxMembresia.Controls.Add(this.label8);
            this.groupBoxMembresia.Controls.Add(this.cboHorarios);
            this.groupBoxMembresia.Controls.Add(this.label9);
            this.groupBoxMembresia.Controls.Add(this.cboPlanPago);
            this.groupBoxMembresia.Controls.Add(this.label10);
            this.groupBoxMembresia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMembresia.Location = new System.Drawing.Point(302, 0);
            this.groupBoxMembresia.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxMembresia.Name = "groupBoxMembresia";
            this.groupBoxMembresia.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxMembresia.Size = new System.Drawing.Size(303, 237);
            this.groupBoxMembresia.TabIndex = 27;
            this.groupBoxMembresia.TabStop = false;
            this.groupBoxMembresia.Text = "Membresía";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(21, 196);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(261, 22);
            this.dtpFechaInicio.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Actividad:";
            // 
            // cboActividad
            // 
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(21, 42);
            this.cboActividad.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(261, 24);
            this.cboActividad.TabIndex = 17;
            this.cboActividad.SelectedIndexChanged += new System.EventHandler(this.cboActividad_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Horarios:";
            // 
            // cboHorarios
            // 
            this.cboHorarios.FormattingEnabled = true;
            this.cboHorarios.Location = new System.Drawing.Point(21, 91);
            this.cboHorarios.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cboHorarios.Name = "cboHorarios";
            this.cboHorarios.Size = new System.Drawing.Size(261, 24);
            this.cboHorarios.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Plan de pago:";
            // 
            // cboPlanPago
            // 
            this.cboPlanPago.FormattingEnabled = true;
            this.cboPlanPago.Location = new System.Drawing.Point(21, 141);
            this.cboPlanPago.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cboPlanPago.Name = "cboPlanPago";
            this.cboPlanPago.Size = new System.Drawing.Size(261, 24);
            this.cboPlanPago.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fecha inicio:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(312, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 41);
            this.panel1.TabIndex = 28;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(87, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(198, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Añadir Socio";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmRegistro
            // 
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmRegistro";
            this.Text = "Club Deportivo - Registrar Nuevo Socio";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageSocio.ResumeLayout(false);
            this.socioTable.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMembresia.ResumeLayout(false);
            this.groupBoxMembresia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSocio;
        private System.Windows.Forms.TableLayoutPanel socioTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox groupBoxMembresia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboHorarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboPlanPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}