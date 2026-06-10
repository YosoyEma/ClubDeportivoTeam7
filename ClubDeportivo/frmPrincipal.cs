using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro ventanaRegistro = new frmRegistro();
            ventanaRegistro.Show();
            this.Hide();
        }

        private void BtnRegistrarPago_Click(object sender, EventArgs e)
        {
            // Open the payment form (FrmCuota)
            FrmCuota ventanaPago = new FrmCuota();
            ventanaPago.Show();
            this.Hide();
        }

        private void BtnListadoVencimientos_Click(object sender, EventArgs e)
        {
            FrmTabla ventanaTabla = new FrmTabla();
            ventanaTabla.Show();
            this.Hide();
        }

    }
}
