namespace CAI_WinFormsApp1_Carullo_Julieta
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCaja = new Button();
            btnOdontologo = new Button();
            btnRecepcion = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCaja);
            groupBox1.Controls.Add(btnOdontologo);
            groupBox1.Controls.Add(btnRecepcion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(923, 647);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCaja
            // 
            btnCaja.Location = new Point(306, 438);
            btnCaja.Name = "btnCaja";
            btnCaja.Size = new Size(227, 97);
            btnCaja.TabIndex = 4;
            btnCaja.Text = "Caja";
            btnCaja.UseVisualStyleBackColor = true;
            btnCaja.Click += btnCaja_Click_1;
            // 
            // btnOdontologo
            // 
            btnOdontologo.Location = new Point(306, 303);
            btnOdontologo.Name = "btnOdontologo";
            btnOdontologo.Size = new Size(227, 97);
            btnOdontologo.TabIndex = 3;
            btnOdontologo.Text = "Odontólogo";
            btnOdontologo.UseVisualStyleBackColor = true;
            btnOdontologo.Click += btnOdontologo_Click;
            // 
            // btnRecepcion
            // 
            btnRecepcion.Location = new Point(306, 187);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(227, 97);
            btnRecepcion.TabIndex = 2;
            btnRecepcion.Text = "Recepción";
            btnRecepcion.UseVisualStyleBackColor = true;
            btnRecepcion.Click += btnRecepcion_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 110);
            label2.Name = "label2";
            label2.Size = new Size(413, 30);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el área a la que desea ingresar";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 49);
            label1.Name = "label1";
            label1.Size = new Size(185, 44);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            label1.Click += label1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 774);
            Controls.Add(groupBox1);
            Name = "Menu";
            Text = "Menú";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnOdontologo;
        private Button btnRecepcion;
        private Button btnCaja;
    }
}
