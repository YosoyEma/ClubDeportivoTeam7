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
    public partial class frmAptoFisico : Form
    {
        public frmAptoFisico()
        {
            InitializeComponent();
        }

        private void btnRegistrarApto_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Por favor, ingrese el DNI del socio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Datos.AptoRepositorio repo = new Datos.AptoRepositorio();
            string respuesta = repo.RegistrarApto(txtDNI.Text);

            if (respuesta == "1")
            {
                MessageBox.Show("Certificado de Apto Físico registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDNI.Text = ""; // Limpiamos la caja de texto
            }
            else
            {
                MessageBox.Show("Error: No se encontró un socio registrado con ese DNI.", "Socio no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
