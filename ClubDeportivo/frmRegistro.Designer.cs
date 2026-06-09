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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBoxMembresia = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbActividad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPlanPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFechaInicio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxMembresia, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.3203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.6797F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 278);
            this.tableLayoutPanel2.TabIndex = 26;
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
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 0, 2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox1.Size = new System.Drawing.Size(296, 226);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Personales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre *";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(23, 41);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido *";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(23, 90);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 20);
            this.txtApellido.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI *";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(23, 139);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(261, 20);
            this.txtDNI.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Télefono *";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(287, 202);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(22, 189);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.groupBoxMembresia.Controls.Add(this.label7);
            this.groupBoxMembresia.Controls.Add(this.cmbActividad);
            this.groupBoxMembresia.Controls.Add(this.label8);
            this.groupBoxMembresia.Controls.Add(this.cmbHorarios);
            this.groupBoxMembresia.Controls.Add(this.label9);
            this.groupBoxMembresia.Controls.Add(this.cmbPlanPago);
            this.groupBoxMembresia.Controls.Add(this.label10);
            this.groupBoxMembresia.Controls.Add(this.cmbFechaInicio);
            this.groupBoxMembresia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMembresia.Location = new System.Drawing.Point(310, 12);
            this.groupBoxMembresia.Margin = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.groupBoxMembresia.Name = "groupBoxMembresia";
            this.groupBoxMembresia.Padding = new System.Windows.Forms.Padding(12);
            this.groupBoxMembresia.Size = new System.Drawing.Size(297, 226);
            this.groupBoxMembresia.TabIndex = 27;
            this.groupBoxMembresia.TabStop = false;
            this.groupBoxMembresia.Text = "Membresía";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Actividad *";
            // 
            // cmbActividad
            // 
            this.cmbActividad.FormattingEnabled = true;
            this.cmbActividad.Location = new System.Drawing.Point(22, 41);
            this.cmbActividad.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbActividad.Name = "cmbActividad";
            this.cmbActividad.Size = new System.Drawing.Size(261, 21);
            this.cmbActividad.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Horarios *";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(22, 90);
            this.cmbHorarios.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(261, 21);
            this.cmbHorarios.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Plan de pago *";
            // 
            // cmbPlanPago
            // 
            this.cmbPlanPago.FormattingEnabled = true;
            this.cmbPlanPago.Location = new System.Drawing.Point(22, 139);
            this.cmbPlanPago.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbPlanPago.Name = "cmbPlanPago";
            this.cmbPlanPago.Size = new System.Drawing.Size(261, 21);
            this.cmbPlanPago.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fecha inicio *";
            // 
            // cmbFechaInicio
            // 
            this.cmbFechaInicio.FormattingEnabled = true;
            this.cmbFechaInicio.Location = new System.Drawing.Point(22, 188);
            this.cmbFechaInicio.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.cmbFechaInicio.Name = "cmbFechaInicio";
            this.cmbFechaInicio.Size = new System.Drawing.Size(261, 21);
            this.cmbFechaInicio.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(311, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 34);
            this.panel1.TabIndex = 28;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(90, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(196, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Añadir Socio";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // frmRegistro
            // 
            this.ClientSize = new System.Drawing.Size(617, 278);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmRegistro";
            this.Text = "Club deportivo - Registro de socios";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMembresia.ResumeLayout(false);
            this.groupBoxMembresia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxMembresia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbActividad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPlanPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFechaInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}