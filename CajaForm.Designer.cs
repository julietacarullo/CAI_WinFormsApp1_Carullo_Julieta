namespace CAI_WinFormsApp1_Carullo_Julieta
{
    partial class CajaForm
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
            groupCaja = new GroupBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegistrarC = new Button();
            btnCancelar = new Button();
            btnVolverM = new Button();
            groupCaja.SuspendLayout();
            SuspendLayout();
            // 
            // groupCaja
            // 
            groupCaja.Controls.Add(comboBox2);
            groupCaja.Controls.Add(textBox1);
            groupCaja.Controls.Add(comboBox1);
            groupCaja.Controls.Add(label4);
            groupCaja.Controls.Add(label3);
            groupCaja.Controls.Add(label2);
            groupCaja.Controls.Add(label1);
            groupCaja.Location = new Point(80, 79);
            groupCaja.Name = "groupCaja";
            groupCaja.Size = new Size(595, 316);
            groupCaja.TabIndex = 0;
            groupCaja.TabStop = false;
            groupCaja.Text = "Facturación";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            comboBox2.Location = new Point(192, 195);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 244);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 192);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 2;
            label3.Text = "Medio de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 123);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Monto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 60);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // btnRegistrarC
            // 
            btnRegistrarC.Location = new Point(115, 425);
            btnRegistrarC.Name = "btnRegistrarC";
            btnRegistrarC.Size = new Size(209, 34);
            btnRegistrarC.TabIndex = 1;
            btnRegistrarC.Text = "Registrar Cobro";
            btnRegistrarC.UseVisualStyleBackColor = true;
            btnRegistrarC.Click += btnRegistrarC_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(374, 425);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVolverM
            // 
            btnVolverM.Location = new Point(490, 22);
            btnVolverM.Name = "btnVolverM";
            btnVolverM.Size = new Size(185, 34);
            btnVolverM.TabIndex = 3;
            btnVolverM.Text = "Volver al menú";
            btnVolverM.UseVisualStyleBackColor = true;
            btnVolverM.Click += btnVolverM_Click;
            // 
            // CajaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 561);
            Controls.Add(btnVolverM);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarC);
            Controls.Add(groupCaja);
            Name = "CajaForm";
            Text = "Caja";
            groupCaja.ResumeLayout(false);
            groupCaja.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupCaja;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Button btnRegistrarC;
        private Button btnCancelar;
        private Button btnVolverM;
    }
}