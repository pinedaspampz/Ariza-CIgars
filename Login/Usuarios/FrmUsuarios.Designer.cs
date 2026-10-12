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
            ((System.ComponentModel.ISupportInitialize)DatosUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Location = new Point(622, 20);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(166, 23);
            btnMenuPrincipal.TabIndex = 0;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = true;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // DatosUsuarios
            // 
            DatosUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatosUsuarios.Location = new Point(12, 303);
            DatosUsuarios.Name = "DatosUsuarios";
            DatosUsuarios.Size = new Size(778, 148);
            DatosUsuarios.TabIndex = 1;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(622, 131);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(166, 23);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(622, 189);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(166, 23);
            btnEliminarUsuario.TabIndex = 4;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnActualizarUsuario
            // 
            btnActualizarUsuario.Location = new Point(622, 160);
            btnActualizarUsuario.Name = "btnActualizarUsuario";
            btnActualizarUsuario.Size = new Size(166, 23);
            btnActualizarUsuario.TabIndex = 5;
            btnActualizarUsuario.Text = "Actualizar Usuario";
            btnActualizarUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 28);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Usuarios";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(622, 228);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(121, 23);
            cmbRoles.TabIndex = 7;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRoles);
            Controls.Add(label1);
            Controls.Add(btnActualizarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(DatosUsuarios);
            Controls.Add(btnMenuPrincipal);
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
    }
}