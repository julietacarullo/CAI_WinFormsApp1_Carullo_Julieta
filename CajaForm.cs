using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAI_WinFormsApp1_Carullo_Julieta
{
    public partial class CajaForm : Form
    {
        public CajaForm()
        {
            InitializeComponent();
        }

        private void btnVolverM_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();

            // Mostrar el formulario de recepción
            frm.Show();

            // Opcional: ocultar el formulario actual
            this.Hide();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cobro registrado exitosamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario de caja
        }
    }

}
