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
    public partial class RecepcionForm : Form
    {
        public RecepcionForm()
        {
            InitializeComponent();
        }

        // private void RecepcionForm_Load(object sender, EventArgs e)
        //{
        Menu frm = new Menu();

        // Mostrar el formulario de recepción
        //  frm.Show();

        // Opcional: ocultar el formulario actual
        //this.Hide();
        //}

        private void btnVolver_Click2(object sender, EventArgs e)
        {
            Menu frm = new Menu();

            // Mostrar el formulario de recepción
            frm.Show();

            // Opcional: ocultar el formulario actual
            this.Hide();
        }
        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();

            // Mostrar el formulario de recepción
            frm.Show();

            // Opcional: ocultar el formulario actual
            this.Hide();

        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrar paciente nuevo.");
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editar paciente seleccionado.");
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eliminar paciente.");
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eliminar turno.");
        }

        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asignar nuevo turno.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // o limpiar campos, depende de lo que quieras
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acción confirmada.");
        }



    }
}

