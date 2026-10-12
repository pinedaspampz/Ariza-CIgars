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
            btnCerrarSesion = new Button();
            btnUsuarios = new Button();
            btnClientes = new Button();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(264, 140);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(222, 23);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(264, 215);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(75, 23);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(411, 215);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(75, 23);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClientes);
            Controls.Add(btnUsuarios);
            Controls.Add(btnCerrarSesion);
            Name = "FrmMenuPrincipal";
            Text = "Ariza - Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private Button btnUsuarios;
        private Button btnClientes;
    }
}