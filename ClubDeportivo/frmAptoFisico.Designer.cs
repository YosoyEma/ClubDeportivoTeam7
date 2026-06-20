namespace ClubDeportivo
{
    partial class frmAptoFisico
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos utilizados.
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
        /// Método requerido para soporte del Diseñador - no modifique
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnRegistrarApto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI del Socio:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(248, 120);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // btnRegistrarApto
            // 
            this.btnRegistrarApto.Location = new System.Drawing.Point(248, 172);
            this.btnRegistrarApto.Name = "btnRegistrarApto";
            this.btnRegistrarApto.Size = new System.Drawing.Size(200, 30);
            this.btnRegistrarApto.TabIndex = 2;
            this.btnRegistrarApto.Text = "Registrar Apto Físico";
            this.btnRegistrarApto.UseVisualStyleBackColor = true;
            this.btnRegistrarApto.Click += new System.EventHandler(this.btnRegistrarApto_Click);
            // 
            // frmAptoFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 331);
            this.Controls.Add(this.btnRegistrarApto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Name = "frmAptoFisico";
            this.Text = "Club Deportivo - Registrar Apto Físico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnRegistrarApto;
    }
}