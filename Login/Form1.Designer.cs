namespace LoginMockup
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtusuario = new TextBox();
            txtclave = new TextBox();
            btningresar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(74, 93, 115);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 625);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 55);
            label1.Name = "label1";
            label1.Size = new Size(167, 56);
            label1.TabIndex = 2;
            label1.Text = "ARIZA";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 97);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(408, 198);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(228, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(408, 300);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(228, 23);
            txtclave.TabIndex = 4;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(476, 378);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(75, 23);
            btningresar.TabIndex = 5;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 93, 115);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 151);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 300);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 198);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 514);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(btningresar);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtusuario;
        private TextBox txtclave;
        private Button btningresar;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label2;
        private Label label3;
    }
}
