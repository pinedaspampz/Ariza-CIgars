namespace Ariza.Inventario
{
    partial class FrmInventario
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
            lblTitulo = new Label();
            txtNombreMaterial = new TextBox();
            txtBuscarMaterial = new TextBox();
            txtCostoUnidad = new TextBox();
            cmbCategoria = new ComboBox();
            cmbUnidadMedida = new ComboBox();
            dgvMateriales = new DataGridView();
            btnGuardarMaterial = new Button();
            btnEditarMaterial = new Button();
            btnActualizarMaterial = new Button();
            btnCambiarEstado = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(491, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inventario de Materia Prima";
            lblTitulo.Click += label1_Click;
            // 
            // txtNombreMaterial
            // 
            txtNombreMaterial.Location = new Point(235, 130);
            txtNombreMaterial.Name = "txtNombreMaterial";
            txtNombreMaterial.Size = new Size(299, 27);
            txtNombreMaterial.TabIndex = 1;
            // 
            // txtBuscarMaterial
            // 
            txtBuscarMaterial.Location = new Point(235, 417);
            txtBuscarMaterial.Name = "txtBuscarMaterial";
            txtBuscarMaterial.Size = new Size(718, 27);
            txtBuscarMaterial.TabIndex = 2;
            // 
            // txtCostoUnidad
            // 
            txtCostoUnidad.Location = new Point(668, 239);
            txtCostoUnidad.Name = "txtCostoUnidad";
            txtCostoUnidad.Size = new Size(285, 27);
            txtCostoUnidad.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(668, 129);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(285, 28);
            cmbCategoria.TabIndex = 4;
            // 
            // cmbUnidadMedida
            // 
            cmbUnidadMedida.FormattingEnabled = true;
            cmbUnidadMedida.Location = new Point(235, 238);
            cmbUnidadMedida.Name = "cmbUnidadMedida";
            cmbUnidadMedida.Size = new Size(299, 28);
            cmbUnidadMedida.TabIndex = 5;
            cmbUnidadMedida.SelectedIndexChanged += cmbUnidadMedida_SelectedIndexChanged;
            // 
            // dgvMateriales
            // 
            dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriales.Location = new Point(235, 467);
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.RowHeadersWidth = 51;
            dgvMateriales.Size = new Size(718, 188);
            dgvMateriales.TabIndex = 6;
            // 
            // btnGuardarMaterial
            // 
            btnGuardarMaterial.Location = new Point(235, 319);
            btnGuardarMaterial.Name = "btnGuardarMaterial";
            btnGuardarMaterial.Size = new Size(94, 29);
            btnGuardarMaterial.TabIndex = 7;
            btnGuardarMaterial.Text = "Guardar";
            btnGuardarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnEditarMaterial
            // 
            btnEditarMaterial.Location = new Point(359, 319);
            btnEditarMaterial.Name = "btnEditarMaterial";
            btnEditarMaterial.Size = new Size(94, 29);
            btnEditarMaterial.TabIndex = 8;
            btnEditarMaterial.Text = "Editar";
            btnEditarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnActualizarMaterial
            // 
            btnActualizarMaterial.Location = new Point(491, 319);
            btnActualizarMaterial.Name = "btnActualizarMaterial";
            btnActualizarMaterial.Size = new Size(94, 29);
            btnActualizarMaterial.TabIndex = 9;
            btnActualizarMaterial.Text = "Actualizar";
            btnActualizarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(622, 319);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(180, 29);
            btnCambiarEstado.TabIndex = 10;
            btnCambiarEstado.Text = "Activar / Desactivar";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(841, 319);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 92);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre del material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(717, 92);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 13;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 202);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 14;
            label3.Text = "Unidad de medida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 202);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 15;
            label4.Text = "Costo por unidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(403, 378);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 16;
            label5.Text = "Buscar material";
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 760);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnActualizarMaterial);
            Controls.Add(btnEditarMaterial);
            Controls.Add(btnGuardarMaterial);
            Controls.Add(dgvMateriales);
            Controls.Add(cmbUnidadMedida);
            Controls.Add(cmbCategoria);
            Controls.Add(txtCostoUnidad);
            Controls.Add(txtBuscarMaterial);
            Controls.Add(txtNombreMaterial);
            Controls.Add(lblTitulo);
            Name = "FrmInventario";
            Text = "FrmInventario";
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombreMaterial;
        private TextBox txtBuscarMaterial;
        private TextBox txtCostoUnidad;
        private ComboBox cmbCategoria;
        private ComboBox cmbUnidadMedida;
        private DataGridView dgvMateriales;
        private Button btnGuardarMaterial;
        private Button btnEditarMaterial;
        private Button btnActualizarMaterial;
        private Button btnCambiarEstado;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}