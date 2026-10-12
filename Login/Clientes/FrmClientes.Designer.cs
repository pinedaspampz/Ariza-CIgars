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
            SuspendLayout();
            // 
            // btnMenuPrincpal
            // 
            btnMenuPrincpal.Location = new Point(538, 40);
            btnMenuPrincpal.Name = "btnMenuPrincpal";
            btnMenuPrincpal.Size = new Size(209, 23);
            btnMenuPrincpal.TabIndex = 0;
            btnMenuPrincpal.Text = "Menu Principal";
            btnMenuPrincpal.UseVisualStyleBackColor = true;
            btnMenuPrincpal.Click += btnMenuPrincpal_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenuPrincpal);
            Name = "FrmClientes";
            Text = "Ariza - Clientes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenuPrincpal;
    }
}