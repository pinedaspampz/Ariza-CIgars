namespace Ariza.Clientes
{
    partial class FrmClientes
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
            btnMenuPrincpal = new Button();
            txtNombreCompleto = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnGuardarCliente = new Button();
            btnLimpiar = new Button();
            dvgClientes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEditarCliente = new Button();
            btnActualizarCliente = new Button();
            btnBuscarCliente = new Button();
            button2 = new Button();
            txtBuscarCliente = new TextBox();
            btnEliminarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgClientes).BeginInit();
            SuspendLayout();
            // 
            // btnMenuPrincpal
            // 
            btnMenuPrincpal.Location = new Point(615, 53);
            btnMenuPrincpal.Margin = new Padding(3, 4, 3, 4);
            btnMenuPrincpal.Name = "btnMenuPrincpal";
            btnMenuPrincpal.Size = new Size(239, 31);
            btnMenuPrincpal.TabIndex = 0;
            btnMenuPrincpal.Text = "Menu Principal";
            btnMenuPrincpal.UseVisualStyleBackColor = true;
            btnMenuPrincpal.Click += btnMenuPrincpal_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(44, 97);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(217, 27);
            txtNombreCompleto.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(44, 256);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(217, 27);
            txtCorreo.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(44, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(217, 27);
            txtTelefono.TabIndex = 3;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.Location = new Point(44, 312);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(94, 29);
            btnGuardarCliente.TabIndex = 4;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(167, 312);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dvgClientes
            // 
            dvgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgClientes.Location = new Point(12, 371);
            dvgClientes.Name = "dvgClientes";
            dvgClientes.RowHeadersWidth = 51;
            dvgClientes.Size = new Size(474, 141);
            dvgClientes.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 64);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre Completo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 141);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 8;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 220);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 9;
            label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 29);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 10;
            label4.Text = "Ariza - Clientes";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(640, 117);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(177, 29);
            btnEditarCliente.TabIndex = 11;
            btnEditarCliente.Text = "Editar cliente";
            btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.Location = new Point(640, 164);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(177, 29);
            btnActualizarCliente.TabIndex = 12;
            btnActualizarCliente.Text = "Guardar Cambios";
            btnActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(671, 474);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(146, 29);
            btnBuscarCliente.TabIndex = 13;
            btnBuscarCliente.Tag = "";
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(692, 522);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(680, 422);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(125, 27);
            txtBuscarCliente.TabIndex = 15;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(640, 220);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(177, 29);
            btnEliminarCliente.TabIndex = 16;
            btnEliminarCliente.Tag = "";
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEliminarCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(button2);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnActualizarCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgClientes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardarCliente);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombreCompleto);
            Controls.Add(btnMenuPrincpal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            Text = "Ariza - Clientes";
            ((System.ComponentModel.ISupportInitialize)dvgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuPrincpal;
        private TextBox txtNombreCompleto;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnGuardarCliente;
        private Button btnLimpiar;
        private DataGridView dvgClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private void label1_Click(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas lógica específica
        }
        private Button btnEditarCliente;
        private Button btnActualizarCliente;
        private Button btnBuscarCliente;
        private Button button2;
        private TextBox txtBuscarCliente;
        private Button button1;
        private Button btnEliminarCliente;
    }
}