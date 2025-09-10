
namespace CAI_WinFormsApp1_Carullo_Julieta
{
    partial class RecepcionForm
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
            groupDatosPaciente = new GroupBox();
            btnEliminarPaciente = new Button();
            btnEditarDatos = new Button();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            btnRegistrarPaciente = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupTurnos = new GroupBox();
            btnAsignarTurno = new Button();
            btnEliminarTurno = new Button();
            label8 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            btnVolverMenu = new Button();
            groupDatosPaciente.SuspendLayout();
            groupTurnos.SuspendLayout();
            SuspendLayout();
            // 
            // groupDatosPaciente
            // 
            groupDatosPaciente.Controls.Add(btnEliminarPaciente);
            groupDatosPaciente.Controls.Add(btnEditarDatos);
            groupDatosPaciente.Controls.Add(dateTimePicker1);
            groupDatosPaciente.Controls.Add(label6);
            groupDatosPaciente.Controls.Add(label5);
            groupDatosPaciente.Controls.Add(btnRegistrarPaciente);
            groupDatosPaciente.Controls.Add(textBox5);
            groupDatosPaciente.Controls.Add(textBox4);
            groupDatosPaciente.Controls.Add(label4);
            groupDatosPaciente.Controls.Add(label3);
            groupDatosPaciente.Controls.Add(label2);
            groupDatosPaciente.Controls.Add(label1);
            groupDatosPaciente.Controls.Add(textBox3);
            groupDatosPaciente.Controls.Add(textBox2);
            groupDatosPaciente.Controls.Add(textBox1);
            groupDatosPaciente.Location = new Point(56, 101);
            groupDatosPaciente.Name = "groupDatosPaciente";
            groupDatosPaciente.Size = new Size(715, 377);
            groupDatosPaciente.TabIndex = 0;
            groupDatosPaciente.TabStop = false;
            groupDatosPaciente.Text = "Datos del Paciente";
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Location = new Point(478, 310);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(188, 34);
            btnEliminarPaciente.TabIndex = 13;
            btnEliminarPaciente.Text = "Eliminar Paciente";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += this.btnEliminarPaciente_Click;
            // 
            // btnEditarDatos
            // 
            btnEditarDatos.Location = new Point(279, 310);
            btnEditarDatos.Name = "btnEditarDatos";
            btnEditarDatos.Size = new Size(152, 34);
            btnEditarDatos.TabIndex = 12;
            btnEditarDatos.Text = "Editar datos";
            btnEditarDatos.UseVisualStyleBackColor = true;
            btnEditarDatos.Click += this.btnEditarPaciente_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(43, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(340, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 131);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 10;
            label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 209);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 9;
            label5.Text = "Dirección";
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.Location = new Point(64, 310);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new Size(165, 34);
            btnRegistrarPaciente.TabIndex = 2;
            btnRegistrarPaciente.Text = "Registrar Paciente";
            btnRegistrarPaciente.UseVisualStyleBackColor = true;
            btnRegistrarPaciente.Click += this.btnRegistrarPaciente_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(43, 237);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(388, 31);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(443, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 131);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 6;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 39);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 39);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(493, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // groupTurnos
            // 
            groupTurnos.Controls.Add(btnAsignarTurno);
            groupTurnos.Controls.Add(btnEliminarTurno);
            groupTurnos.Controls.Add(label8);
            groupTurnos.Controls.Add(comboBox1);
            groupTurnos.Controls.Add(dateTimePicker2);
            groupTurnos.Controls.Add(label7);
            groupTurnos.Location = new Point(60, 503);
            groupTurnos.Name = "groupTurnos";
            groupTurnos.Size = new Size(711, 345);
            groupTurnos.TabIndex = 1;
            groupTurnos.TabStop = false;
            groupTurnos.Text = "Turnos";
            // 
            // btnAsignarTurno
            // 
            btnAsignarTurno.Location = new Point(370, 216);
            btnAsignarTurno.Name = "btnAsignarTurno";
            btnAsignarTurno.Size = new Size(165, 91);
            btnAsignarTurno.TabIndex = 3;
            btnAsignarTurno.Text = "Asignar Turno";
            btnAsignarTurno.UseVisualStyleBackColor = true;
            btnAsignarTurno.Click += this.btnAsignarTurno_Click;
            // 
            // btnEliminarTurno
            // 
            btnEliminarTurno.Location = new Point(114, 216);
            btnEliminarTurno.Name = "btnEliminarTurno";
            btnEliminarTurno.Size = new Size(182, 91);
            btnEliminarTurno.TabIndex = 5;
            btnEliminarTurno.Text = "Eliminar Turno";
            btnEliminarTurno.UseVisualStyleBackColor = true;
            btnEliminarTurno.Click += this.btnEliminarTurno_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 129);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 3;
            label8.Text = "Odontólogo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(39, 82);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(340, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 54);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 0;
            label7.Text = "Fecha y Hora";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(518, 877);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(181, 56);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += this.btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(246, 877);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 56);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += this.btnCancelar_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(595, 35);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(159, 46);
            btnVolverMenu.TabIndex = 4;
            btnVolverMenu.Text = "Volver al menú";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // RecepcionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 1010);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupTurnos);
            Controls.Add(groupDatosPaciente);
            Name = "RecepcionForm";
            Text = "Recepción";
            groupDatosPaciente.ResumeLayout(false);
            groupDatosPaciente.PerformLayout();
            groupTurnos.ResumeLayout(false);
            groupTurnos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupDatosPaciente;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private GroupBox groupTurnos;
        private Label label8;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private Button btnRegistrarPaciente;
        private Button btnAsignarTurno;
        private Button btnEliminarTurno;
        private Button btnEliminarPaciente;
        private Button btnEditarDatos;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button btnVolverMenu;
        private EventHandler btnVovlerMenu_Click;
    }
}