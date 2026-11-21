namespace Ariza._8.Pedidos
{
    partial class FrmPedidos
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
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnMenuPrincipal = new Button();
            label2 = new Label();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox8 = new ComboBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            dgvDisponibilidadBodega = new DataGridView();
            dgvPedidos = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibilidadBodega).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(234, 220, 185);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 159);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 69F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 23);
            label1.Name = "label1";
            label1.Size = new Size(319, 107);
            label1.TabIndex = 3;
            label1.Text = "ARIZA";
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
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Location = new Point(631, 557);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(158, 23);
            btnMenuPrincipal.TabIndex = 7;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = true;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 210);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox8);
            panel1.Controls.Add(comboBox6);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(26, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 348);
            panel1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(40, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(665, 23);
            comboBox2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 31);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 14;
            label5.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 169);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 16;
            label3.Text = "Parametro del pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 86);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 16;
            label4.Text = "Tipo de puro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 206);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 17;
            label6.Text = "Urgencia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 206);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 18;
            label7.Text = "Cantidad de Puros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 143);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 19;
            label8.Text = "Vitola";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 86);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 20;
            label9.Text = "Marca";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 23);
            comboBox1.TabIndex = 21;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(40, 161);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(321, 23);
            comboBox3.TabIndex = 22;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(367, 104);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(338, 23);
            comboBox5.TabIndex = 24;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(367, 161);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(338, 23);
            comboBox6.TabIndex = 25;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(367, 224);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(338, 23);
            comboBox8.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(367, 143);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 28;
            label10.Text = "Presentacion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(367, 251);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 30;
            // 
            // dgvDisponibilidadBodega
            // 
            dgvDisponibilidadBodega.AllowUserToOrderColumns = true;
            dgvDisponibilidadBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisponibilidadBodega.Location = new Point(902, 34);
            dgvDisponibilidadBodega.Name = "dgvDisponibilidadBodega";
            dgvDisponibilidadBodega.Size = new Size(240, 150);
            dgvDisponibilidadBodega.TabIndex = 17;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToOrderColumns = true;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(902, 258);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(240, 150);
            dgvPedidos.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(817, 461);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 19;
            button1.Text = "Registrar Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1009, 461);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 20;
            button2.Text = "Limpiar Campos";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1282, 888);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvPedidos);
            Controls.Add(dgvDisponibilidadBodega);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(panel2);
            Name = "FrmPedidos";
            Text = "Ariza - Pedidos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisponibilidadBodega).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnMenuPrincipal;
        private Label label2;
        private Panel panel1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label3;
        private ComboBox comboBox5;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label10;
        private ComboBox comboBox8;
        private ComboBox comboBox6;
        private Label label11;
        private TextBox textBox1;
        private DataGridView dgvDisponibilidadBodega;
        private DataGridView dgvPedidos;
        private Button button1;
        private Button button2;
    }
}