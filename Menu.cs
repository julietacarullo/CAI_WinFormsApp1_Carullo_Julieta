namespace CAI_WinFormsApp1_Carullo_Julieta
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void btnRecepcion_Click_1(object sender, EventArgs e)
        {
            RecepcionForm frm = new RecepcionForm();

            // Mostrar el formulario de recepción
            frm.Show();

            // Opcional: ocultar el formulario actual
            this.Hide();
        }

        private void btnOdontologo_Click(object sender, EventArgs e)
        {
            OdontologoForm frm = new OdontologoForm();
            frm.Show();
            this.Hide();
        }
        private void btnCaja_Click_1(object sender, EventArgs e)
        {
            CajaForm frm = new CajaForm();

            // Mostrar el formulario de recepción
            frm.Show();

            // Opcional: ocultar el formulario actual
            this.Hide();
        }
    }
}
