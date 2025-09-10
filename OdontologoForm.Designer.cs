namespace CAI_WinFormsApp1_Carullo_Julieta
{
    partial class OdontologoForm
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
            groupTurno = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupConsulta = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnGuardarConsulta = new Button();
            btnVolverMnu = new Button();
            btnCancelar = new Button();
            groupTurno.SuspendLayout();
            groupConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // groupTurno
            // 
            groupTurno.Controls.Add(textBox1);
            groupTurno.Controls.Add(label2);
            groupTurno.Controls.Add(comboBox1);
            groupTurno.Controls.Add(label1);
            groupTurno.Location = new Point(38, 65);
            groupTurno.Name = "groupTurno";
            groupTurno.Size = new Size(718, 195);
            groupTurno.TabIndex = 0;
            groupTurno.TabStop = false;
            groupTurno.Text = "Turno";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 31);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 130);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 2;
            label2.Text = "Motivo de consulta";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 51);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            label1.Click += label1_Click;
            // 
            // groupConsulta
            // 
            groupConsulta.Controls.Add(dateTimePicker1);
            groupConsulta.Controls.Add(textBox3);
            groupConsulta.Controls.Add(textBox2);
            groupConsulta.Controls.Add(label5);
            groupConsulta.Controls.Add(label4);
            groupConsulta.Controls.Add(label3);
            groupConsulta.Location = new Point(47, 275);
            groupConsulta.Name = "groupConsulta";
            groupConsulta.Size = new Size(709, 381);
            groupConsulta.TabIndex = 1;
            groupConsulta.TabStop = false;
            groupConsulta.Text = "Consulta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(207, 319);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(366, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(154, 181);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(533, 97);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 46);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(533, 103);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 319);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 2;
            label5.Text = "Próxima revisión";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 181);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 1;
            label4.Text = "Tratamiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 45);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 0;
            label3.Text = "Diagnóstico";
            // 
            // btnGuardarConsulta
            // 
            btnGuardarConsulta.Location = new Point(71, 662);
            btnGuardarConsulta.Name = "btnGuardarConsulta";
            btnGuardarConsulta.Size = new Size(246, 67);
            btnGuardarConsulta.TabIndex = 2;
            btnGuardarConsulta.Text = "Guardar Consulta";
            btnGuardarConsulta.UseVisualStyleBackColor = true;
            btnGuardarConsulta.Click += btnGuardarConsulta_Click;
            // 
            // btnVolverMnu
            // 
            btnVolverMnu.Location = new Point(593, 35);
            btnVolverMnu.Name = "btnVolverMnu";
            btnVolverMnu.Size = new Size(157, 34);
            btnVolverMnu.TabIndex = 3;
            btnVolverMnu.Text = "Volver al menú";
            btnVolverMnu.UseVisualStyleBackColor = true;
            btnVolverMnu.Click += btnVolverMnu_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(435, 667);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(204, 62);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // OdontologoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 755);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolverMnu);
            Controls.Add(btnGuardarConsulta);
            Controls.Add(groupConsulta);
            Controls.Add(groupTurno);
            Name = "OdontologoForm";
            Text = "OdontologoForm";
            Load += OdontologoForm_Load;
            groupTurno.ResumeLayout(false);
            groupTurno.PerformLayout();
            groupConsulta.ResumeLayout(false);
            groupConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupTurno;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupConsulta;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnGuardarConsulta;
        private Button btnVolverMnu;
        private Button btnCancelar;
    }
}