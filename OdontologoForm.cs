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
    public partial class OdontologoForm : Form
    {
        public OdontologoForm()
        {
            InitializeComponent();
        }

        private void OdontologoForm_Load(object sender, EventArgs e)
        {
            Menu frm = new Menu();

            // Mostrar el formulario de recepción
            frm.Show();

            // Opcional: ocultar el formulario actual
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnVolverMnu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();  // oculta Recepcion y muestra el menú
        }
  
        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consulta guardada correctamente.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario del odontólogo
        }

    }
}
