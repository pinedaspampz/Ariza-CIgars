namespace Ariza.Usuarios
{
    partial class FrmUsuarios
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
            btnMenuPrincipal = new Button();
            DatosUsuarios = new DataGridView();
            btnAgregarUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnActualizarUsuario = new Button();
            label1 = new Label();
            cmbRoles = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombreCompleto = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnGuardarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)DatosUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Location = new Point(711, 27);
            btnMenuPrincipal.Margin = new Padding(3, 4, 3, 4);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(190, 31);
            btnMenuPrincipal.TabIndex = 0;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = true;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // DatosUsuarios
            // 
            DatosUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosUsuarios.Location = new Point(14, 404);
            DatosUsuarios.Margin = new Padding(3, 4, 3, 4);
            DatosUsuarios.Name = "DatosUsuarios";
            DatosUsuarios.RowHeadersWidth = 51;
            DatosUsuarios.Size = new Size(889, 197);
            DatosUsuarios.TabIndex = 1;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(711, 175);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(190, 31);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(711, 252);
            btnEliminarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(190, 31);
            btnEliminarUsuario.TabIndex = 4;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizarUsuario
            // 
            btnActualizarUsuario.Location = new Point(711, 213);
            btnActualizarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnActualizarUsuario.Name = "btnActualizarUsuario";
            btnActualizarUsuario.Size = new Size(190, 31);
            btnActualizarUsuario.TabIndex = 5;
            btnActualizarUsuario.Text = "Actualizar Usuario";
            btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 37);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 6;
            label1.Text = "Usuarios";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(419, 135);
            cmbRoles.Margin = new Padding(3, 4, 3, 4);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(138, 28);
            cmbRoles.TabIndex = 7;
            cmbRoles.SelectedIndexChanged += cmbRoles_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 95);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre Completo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 135);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 9;
            label3.Text = "Nombre de Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 180);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 10;
            label4.Text = "Contraseña";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(76, 88);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(125, 27);
            txtNombreCompleto.TabIndex = 11;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(76, 132);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(125, 27);
            txtNombreUsuario.TabIndex = 12;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(76, 173);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 13;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(131, 235);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(171, 29);
            btnGuardarUsuario.TabIndex = 14;
            btnGuardarUsuario.Text = "Guardar Usuario";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnGuardarUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbRoles);
            Controls.Add(label1);
            Controls.Add(btnActualizarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(DatosUsuarios);
            Controls.Add(btnMenuPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUsuarios";
            Text = "Ariza - Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)DatosUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuPrincipal;
        private DataGridView DatosUsuarios;
        private Button btnAgregarUsuario;
        private Button btnEliminarUsuario;
        private Button btnActualizarUsuario;
        private Label label1;
        private ComboBox cmbRoles;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCompleto;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasena;
        private Button btnGuardarUsuario;
    }
}