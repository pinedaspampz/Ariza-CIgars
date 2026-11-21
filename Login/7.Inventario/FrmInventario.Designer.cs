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
            btnMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(430, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inventario de Materia Prima";
            lblTitulo.Click += label1_Click;
            // 
            // txtNombreMaterial
            // 
            txtNombreMaterial.Location = new Point(206, 98);
            txtNombreMaterial.Margin = new Padding(3, 2, 3, 2);
            txtNombreMaterial.Name = "txtNombreMaterial";
            txtNombreMaterial.Size = new Size(262, 23);
            txtNombreMaterial.TabIndex = 1;
            // 
            // txtBuscarMaterial
            // 
            txtBuscarMaterial.Location = new Point(206, 313);
            txtBuscarMaterial.Margin = new Padding(3, 2, 3, 2);
            txtBuscarMaterial.Name = "txtBuscarMaterial";
            txtBuscarMaterial.Size = new Size(629, 23);
            txtBuscarMaterial.TabIndex = 2;
            // 
            // txtCostoUnidad
            // 
            txtCostoUnidad.Location = new Point(584, 179);
            txtCostoUnidad.Margin = new Padding(3, 2, 3, 2);
            txtCostoUnidad.Name = "txtCostoUnidad";
            txtCostoUnidad.Size = new Size(250, 23);
            txtCostoUnidad.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(584, 97);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(250, 23);
            cmbCategoria.TabIndex = 4;
            // 
            // cmbUnidadMedida
            // 
            cmbUnidadMedida.FormattingEnabled = true;
            cmbUnidadMedida.Location = new Point(206, 178);
            cmbUnidadMedida.Margin = new Padding(3, 2, 3, 2);
            cmbUnidadMedida.Name = "cmbUnidadMedida";
            cmbUnidadMedida.Size = new Size(262, 23);
            cmbUnidadMedida.TabIndex = 5;
            cmbUnidadMedida.SelectedIndexChanged += cmbUnidadMedida_SelectedIndexChanged;
            // 
            // dgvMateriales
            // 
            dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriales.Location = new Point(206, 350);
            dgvMateriales.Margin = new Padding(3, 2, 3, 2);
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.RowHeadersWidth = 51;
            dgvMateriales.Size = new Size(628, 141);
            dgvMateriales.TabIndex = 6;
            // 
            // btnGuardarMaterial
            // 
            btnGuardarMaterial.Location = new Point(206, 239);
            btnGuardarMaterial.Margin = new Padding(3, 2, 3, 2);
            btnGuardarMaterial.Name = "btnGuardarMaterial";
            btnGuardarMaterial.Size = new Size(82, 22);
            btnGuardarMaterial.TabIndex = 7;
            btnGuardarMaterial.Text = "Guardar";
            btnGuardarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnEditarMaterial
            // 
            btnEditarMaterial.Location = new Point(314, 239);
            btnEditarMaterial.Margin = new Padding(3, 2, 3, 2);
            btnEditarMaterial.Name = "btnEditarMaterial";
            btnEditarMaterial.Size = new Size(82, 22);
            btnEditarMaterial.TabIndex = 8;
            btnEditarMaterial.Text = "Editar";
            btnEditarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnActualizarMaterial
            // 
            btnActualizarMaterial.Location = new Point(430, 239);
            btnActualizarMaterial.Margin = new Padding(3, 2, 3, 2);
            btnActualizarMaterial.Name = "btnActualizarMaterial";
            btnActualizarMaterial.Size = new Size(82, 22);
            btnActualizarMaterial.TabIndex = 9;
            btnActualizarMaterial.Text = "Actualizar";
            btnActualizarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Location = new Point(544, 239);
            btnCambiarEstado.Margin = new Padding(3, 2, 3, 2);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(158, 22);
            btnCambiarEstado.TabIndex = 10;
            btnCambiarEstado.Text = "Activar / Desactivar";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(736, 239);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 69);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre del material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 13;
            label2.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 152);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 14;
            label3.Text = "Unidad de medida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(627, 152);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 15;
            label4.Text = "Costo por unidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 284);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 16;
            label5.Text = "Buscar material";
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Location = new Point(944, 147);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(201, 23);
            btnMenuPrincipal.TabIndex = 17;
            btnMenuPrincipal.Text = "Menu Prinicipal";
            btnMenuPrincipal.UseVisualStyleBackColor = true;
            btnMenuPrincipal.Click += button1_Click;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 570);
            Controls.Add(btnMenuPrincipal);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnMenuPrincipal;
    }
}