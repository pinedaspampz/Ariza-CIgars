namespace Ariza.Principal

{
    partial class FrmPrincipal
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
            PanelContenido = new Panel();
            SuspendLayout();
            // 
            // PanelContenido
            // 
            PanelContenido.Location = new Point(335, 200);
            PanelContenido.Margin = new Padding(3, 4, 3, 4);
            PanelContenido.Name = "PanelContenido";
            PanelContenido.Size = new Size(229, 133);
            PanelContenido.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(PanelContenido);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "ARIZA ";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelContenido;
    }
}