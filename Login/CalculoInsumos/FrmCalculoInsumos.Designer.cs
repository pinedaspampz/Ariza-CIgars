using System.Drawing;
using System.Windows.Forms;

namespace Ariza.CalculoInsumos
{
    partial class FrmCalculoInsumos
    {
        private Panel pnlEncabezado = null!;
        private GroupBox grpProduccion = null!;
        private ComboBox cmbCliente = null!;
        private ComboBox cmbMarca = null!;
        private ComboBox cmbTipoPuro = null!;
        private ComboBox cmbVitola = null!;
        private ComboBox cmbPresentacion = null!;
        private NumericUpDown numCantidad = null!;
        private DataGridView dgvInsumos = null!;
        private Button btnCalcular = null!;
        private Button btnLimpiar = null!;

        private void InitializeComponent()
        {
            SuspendLayout();

            Name = nameof(FrmCalculoInsumos);
            Text = "ARIZA - Cálculo de Insumos";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 9F);
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 633);
            MinimumSize = new Size(640, 580);

            pnlEncabezado = new Panel
            {
                Name = nameof(pnlEncabezado),
                Dock = DockStyle.Fill,
                BackColor = Color.Wheat,
                Margin = Padding.Empty
            };
            pnlEncabezado.Controls.Add(new Label
            {
                Name = "lblTituloModulo",
                Text = "CÁLCULO DE INSUMOS",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter
            });
            pnlEncabezado.Controls.Add(new Label
            {
                Name = "lblAriza",
                Text = "ARIZA",
                Font = new Font("Segoe UI", 30F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 67,
                TextAlign = ContentAlignment.MiddleCenter
            });

            grpProduccion = new GroupBox
            {
                Name = nameof(grpProduccion),
                Text = "Datos de producción",
                Dock = DockStyle.Fill,
                Margin = new Padding(24, 12, 24, 12),
                Padding = new Padding(12)
            };

            var campos = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3
            };
            campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            for (int fila = 0; fila < 3; fila++)
            {
                campos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / 3F));
            }

            cmbCliente = CrearCombo(nameof(cmbCliente));
            cmbMarca = CrearCombo(nameof(cmbMarca));
            cmbTipoPuro = CrearCombo(nameof(cmbTipoPuro));
            cmbVitola = CrearCombo(nameof(cmbVitola));
            cmbPresentacion = CrearCombo(nameof(cmbPresentacion));
            numCantidad = new NumericUpDown
            {
                Name = nameof(numCantidad),
                Minimum = 1,
                Maximum = 1000000,
                Value = 1,
                ThousandsSeparator = true,
                TextAlign = HorizontalAlignment.Right
            };

            campos.Controls.Add(CrearCampo("lblCliente", "Cliente", cmbCliente, 0), 0, 0);
            campos.Controls.Add(CrearCampo("lblMarca", "Marca", cmbMarca, 1), 1, 0);
            campos.Controls.Add(CrearCampo("lblTipoPuro", "Tipo de puro", cmbTipoPuro, 2), 0, 1);
            campos.Controls.Add(CrearCampo("lblVitola", "Vitola", cmbVitola, 3), 1, 1);
            campos.Controls.Add(CrearCampo("lblPresentacion", "Presentación", cmbPresentacion, 4), 0, 2);
            campos.Controls.Add(CrearCampo("lblCantidad", "Cantidad de puros", numCantidad, 5), 1, 2);
            grpProduccion.Controls.Add(campos);

            dgvInsumos = new DataGridView
            {
                Name = nameof(dgvInsumos),
                Dock = DockStyle.Fill,
                Margin = new Padding(24, 0, 24, 0),
                BackgroundColor = Color.White,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                TabIndex = 2
            };
            dgvInsumos.Columns.Add("colInsumo", "Insumo");
            dgvInsumos.Columns.Add("colCantidad", "Cantidad necesaria");
            dgvInsumos.Columns.Add("colUnidad", "Unidad de medida");

            btnCalcular = new Button
            {
                Name = nameof(btnCalcular),
                Text = "Calcular insumos",
                Size = new Size(145, 35),
                TabIndex = 0
            };
            btnLimpiar = new Button
            {
                Name = nameof(btnLimpiar),
                Text = "Limpiar",
                Size = new Size(110, 35),
                TabIndex = 1
            };
            var acciones = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                WrapContents = false,
                Margin = new Padding(24, 7, 24, 0),
                TabIndex = 3
            };
            acciones.Controls.Add(btnLimpiar);
            acciones.Controls.Add(btnCalcular);

            var contenido = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4
            };
            contenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 238F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            grpProduccion.TabIndex = 1;
            contenido.Controls.Add(pnlEncabezado, 0, 0);
            contenido.Controls.Add(grpProduccion, 0, 1);
            contenido.Controls.Add(dgvInsumos, 0, 2);
            contenido.Controls.Add(acciones, 0, 3);
            Controls.Add(contenido);

            ResumeLayout(true);
        }

        private static ComboBox CrearCombo(string nombre)
        {
            return new ComboBox
            {
                Name = nombre,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
        }

        private static Panel CrearCampo(string nombreEtiqueta, string texto, Control entrada, int orden)
        {
            var campo = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(5, 2, 5, 2),
                TabIndex = orden
            };
            var etiqueta = new Label
            {
                Name = nombreEtiqueta,
                Text = texto,
                Dock = DockStyle.Top,
                Height = 20
            };
            entrada.AccessibleName = texto;
            entrada.Dock = DockStyle.Top;
            campo.Controls.Add(entrada);
            campo.Controls.Add(etiqueta);
            return campo;
        }
    }
}
