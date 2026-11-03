namespace Ariza.MenuPrincipal
{
    partial class FrmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            btnCerrarSesion = new Button();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            panel2 = new Panel();
            btnUsuarios = new Button();
            btnClientes = new Button();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(234, 220, 185);
            btnCerrarSesion.ForeColor = SystemColors.ActiveCaptionText;
            btnCerrarSesion.Location = new Point(639, 422);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(100, 44);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(234, 220, 185);
            pictureBox1.Image = Properties.Resources.arizat;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 69F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 23);
            label1.Name = "label1";
            label1.Size = new Size(319, 107);
            label1.TabIndex = 3;
            label1.Text = "ARIZA";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(234, 220, 185);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 159);
            panel2.TabIndex = 5;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 220, 185);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 198, 155);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Location = new Point(389, 198);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(112, 50);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 220, 185);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 198, 155);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(389, 264);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(112, 46);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.pedidost;
            pictureBox5.Location = new Point(294, 405);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(81, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.purot;
            pictureBox2.Location = new Point(294, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.clientes;
            pictureBox3.Location = new Point(297, 260);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.usuariost;
            pictureBox4.Location = new Point(291, 198);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(81, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 473);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(btnClientes);
            Controls.Add(pictureBox3);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnUsuarios);
            Name = "FrmMenuPrincipal";
            Text = "Ariza - Menu Principal";
            Load += FrmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label label1;
        private Panel panel2;
        private Button btnUsuarios;
        private Button btnClientes;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}