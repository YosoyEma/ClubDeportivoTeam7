namespace ClubDeportivo
{
    partial class frmNoSocio
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNoSocio = new System.Windows.Forms.TabPage();
            this.noSocioTable = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1_n = new System.Windows.Forms.GroupBox();
            this.label1_n = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2_n = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3_n = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5_n = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBoxMembresia_n = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.Label();
            this.labelActivityNoSocio = new System.Windows.Forms.Label();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.labelHorarioNoSocio = new System.Windows.Forms.Label();
            this.cboHorarios = new System.Windows.Forms.ComboBox();
            this.labelFechaAsistencia = new System.Windows.Forms.Label();
            this.labelImporte = new System.Windows.Forms.Label();
            this.dtpFechaAsistencia = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.tabPageNoSocio.SuspendLayout();
            this.noSocioTable.SuspendLayout();
            this.groupBox1_n.SuspendLayout();
            this.groupBoxMembresia_n.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageNoSocio);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(48, 21);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(619, 331);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "";
            // 
            // tabPageNoSocio
            // 
            this.tabPageNoSocio.Controls.Add(this.noSocioTable);
            this.tabPageNoSocio.Location = new System.Drawing.Point(4, 25);
            this.tabPageNoSocio.Name = "tabPageNoSocio";
            this.tabPageNoSocio.Size = new System.Drawing.Size(611, 302);
            this.tabPageNoSocio.TabIndex = 1;
            this.tabPageNoSocio.Text = "No Socio";
            // 
            // noSocioTable
            // 
            this.noSocioTable.ColumnCount = 2;
            this.noSocioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.noSocioTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.noSocioTable.Controls.Add(this.groupBox1_n, 0, 0);
            this.noSocioTable.Controls.Add(this.groupBoxMembresia_n, 1, 0);
            this.noSocioTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noSocioTable.Location = new System.Drawing.Point(0, 0);
            this.noSocioTable.Name = "noSocioTable";
            this.noSocioTable.RowCount = 1;
            this.noSocioTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.noSocioTable.Size = new System.Drawing.Size(611, 302);
            this.noSocioTable.TabIndex = 0;
            // 
            // groupBox1_n
            // 
            this.groupBox1_n.Controls.Add(this.label1_n);
            this.groupBox1_n.Controls.Add(this.txtNombre);
            this.groupBox1_n.Controls.Add(this.label2_n);
            this.groupBox1_n.Controls.Add(this.txtApellido);
            this.groupBox1_n.Controls.Add(this.label3_n);
            this.groupBox1_n.Controls.Add(this.txtDNI);
            this.groupBox1_n.Controls.Add(this.label5_n);
            this.groupBox1_n.Controls.Add(this.txtTelefono);
            this.groupBox1_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1_n.Location = new System.Drawing.Point(0, 0);
            this.groupBox1_n.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1_n.Name = "groupBox1_n";
            this.groupBox1_n.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1_n.Size = new System.Drawing.Size(305, 302);
            this.groupBox1_n.TabIndex = 0;
            this.groupBox1_n.TabStop = false;
            this.groupBox1_n.Text = "Detalles Personales";
            // 
            // label1_n
            // 
            this.label1_n.AutoSize = true;
            this.label1_n.Location = new System.Drawing.Point(19, 25);
            this.label1_n.Name = "label1_n";
            this.label1_n.Size = new System.Drawing.Size(59, 16);
            this.label1_n.TabIndex = 0;
            this.label1_n.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label2_n
            // 
            this.label2_n.AutoSize = true;
            this.label2_n.Location = new System.Drawing.Point(19, 74);
            this.label2_n.Name = "label2_n";
            this.label2_n.Size = new System.Drawing.Size(60, 16);
            this.label2_n.TabIndex = 2;
            this.label2_n.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(22, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // label3_n
            // 
            this.label3_n.AutoSize = true;
            this.label3_n.Location = new System.Drawing.Point(19, 124);
            this.label3_n.Name = "label3_n";
            this.label3_n.Size = new System.Drawing.Size(33, 16);
            this.label3_n.TabIndex = 4;
            this.label3_n.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(22, 143);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(261, 22);
            this.txtDNI.TabIndex = 5;
            // 
            // label5_n
            // 
            this.label5_n.AutoSize = true;
            this.label5_n.Location = new System.Drawing.Point(19, 177);
            this.label5_n.Name = "label5_n";
            this.label5_n.Size = new System.Drawing.Size(64, 16);
            this.label5_n.TabIndex = 6;
            this.label5_n.Text = "Télefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 195);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(261, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // groupBoxMembresia_n
            // 
            this.groupBoxMembresia_n.Controls.Add(this.dtpFechaAsistencia);
            this.groupBoxMembresia_n.Controls.Add(this.panel1);
            this.groupBoxMembresia_n.Controls.Add(this.txtImporte);
            this.groupBoxMembresia_n.Controls.Add(this.labelActivityNoSocio);
            this.groupBoxMembresia_n.Controls.Add(this.cboActividad);
            this.groupBoxMembresia_n.Controls.Add(this.labelHorarioNoSocio);
            this.groupBoxMembresia_n.Controls.Add(this.cboHorarios);
            this.groupBoxMembresia_n.Controls.Add(this.labelFechaAsistencia);
            this.groupBoxMembresia_n.Controls.Add(this.labelImporte);
            this.groupBoxMembresia_n.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMembresia_n.Location = new System.Drawing.Point(305, 0);
            this.groupBoxMembresia_n.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxMembresia_n.Name = "groupBoxMembresia_n";
            this.groupBoxMembresia_n.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxMembresia_n.Size = new System.Drawing.Size(306, 302);
            this.groupBoxMembresia_n.TabIndex = 1;
            this.groupBoxMembresia_n.TabStop = false;
            this.groupBoxMembresia_n.Text = "Visita";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(2, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 41);
            this.panel1.TabIndex = 29;
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
            this.btnGuardar.Text = "Añadir Visita";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.AutoSize = true;
            this.txtImporte.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtImporte.Location = new System.Drawing.Point(23, 202);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(61, 16);
            this.txtImporte.TabIndex = 29;
            this.txtImporte.Text = "Cantidad";
            // 
            // labelActivityNoSocio
            // 
            this.labelActivityNoSocio.AutoSize = true;
            this.labelActivityNoSocio.Location = new System.Drawing.Point(18, 25);
            this.labelActivityNoSocio.Name = "labelActivityNoSocio";
            this.labelActivityNoSocio.Size = new System.Drawing.Size(66, 16);
            this.labelActivityNoSocio.TabIndex = 22;
            this.labelActivityNoSocio.Text = "Actividad:";
            // 
            // cboActividad
            // 
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(21, 42);
            this.cboActividad.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(261, 24);
            this.cboActividad.TabIndex = 26;
            this.cboActividad.Click += new System.EventHandler(this.cboActividad_SelectedIndexChanged);
            // 
            // labelHorarioNoSocio
            // 
            this.labelHorarioNoSocio.AutoSize = true;
            this.labelHorarioNoSocio.Location = new System.Drawing.Point(18, 74);
            this.labelHorarioNoSocio.Name = "labelHorarioNoSocio";
            this.labelHorarioNoSocio.Size = new System.Drawing.Size(62, 16);
            this.labelHorarioNoSocio.TabIndex = 23;
            this.labelHorarioNoSocio.Text = "Horarios:";
            // 
            // cboHorarios
            // 
            this.cboHorarios.FormattingEnabled = true;
            this.cboHorarios.Location = new System.Drawing.Point(21, 91);
            this.cboHorarios.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cboHorarios.Name = "cboHorarios";
            this.cboHorarios.Size = new System.Drawing.Size(261, 24);
            this.cboHorarios.TabIndex = 27;
            // 
            // labelFechaAsistencia
            // 
            this.labelFechaAsistencia.AutoSize = true;
            this.labelFechaAsistencia.Location = new System.Drawing.Point(18, 124);
            this.labelFechaAsistencia.Name = "labelFechaAsistencia";
            this.labelFechaAsistencia.Size = new System.Drawing.Size(131, 16);
            this.labelFechaAsistencia.TabIndex = 24;
            this.labelFechaAsistencia.Text = "Fecha de asistencia:";
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(18, 177);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(55, 16);
            this.labelImporte.TabIndex = 25;
            this.labelImporte.Text = "Importe:";
            // 
            // dtpFechaAsistencia
            // 
            this.dtpFechaAsistencia.Location = new System.Drawing.Point(21, 143);
            this.dtpFechaAsistencia.Name = "dtpFechaAsistencia";
            this.dtpFechaAsistencia.Size = new System.Drawing.Size(261, 22);
            this.dtpFechaAsistencia.TabIndex = 30;
            // 
            // frmNoSocio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.tabControl);
            this.Name = "frmNoSocio";
            this.Text = "Club Deportivo - Registrar Visita";
            this.Load += new System.EventHandler(this.frmNoSocio_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageNoSocio.ResumeLayout(false);
            this.noSocioTable.ResumeLayout(false);
            this.groupBox1_n.ResumeLayout(false);
            this.groupBox1_n.PerformLayout();
            this.groupBoxMembresia_n.ResumeLayout(false);
            this.groupBoxMembresia_n.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNoSocio;
        private System.Windows.Forms.TableLayoutPanel noSocioTable;
        private System.Windows.Forms.GroupBox groupBox1_n;
        private System.Windows.Forms.Label label1_n;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2_n;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3_n;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5_n;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox groupBoxMembresia_n;
        private System.Windows.Forms.Label txtImporte;
        private System.Windows.Forms.Label labelActivityNoSocio;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.Label labelHorarioNoSocio;
        private System.Windows.Forms.ComboBox cboHorarios;
        private System.Windows.Forms.Label labelFechaAsistencia;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFechaAsistencia;
    }
}