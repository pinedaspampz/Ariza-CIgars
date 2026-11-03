
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Clases.Clases;

namespace Ariza
{
    public partial class FrmRecetas : Form
    {
        private readonly ClaseRecetas claseRecetas = new ClaseRecetas();
        private int idRecetaSeleccionada = 0;

        public FrmRecetas()
        {
            InitializeComponent();

           
            btnGuardar.Click += btnGuardar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dgvRecetas.CellClick += dgvRecetas_CellClick;

           
            CargarProductos();
            CargarMateriales();
            CargarRecetas();

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        
        private void CargarProductos()
        {
            try
            {
                cmbProducto.DataSource = claseRecetas.ObtenerProductos();
                cmbProducto.DisplayMember = "nombreProducto";
                cmbProducto.ValueMember = "idProducto";
                cmbProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        // Cargar materiales activos
        private void CargarMateriales()
        {
            try
            {
                cmbMaterial.DataSource = claseRecetas.ObtenerMateriales();
                cmbMaterial.DisplayMember = "nombreMaterial";
                cmbMaterial.ValueMember = "idMaterial";
                cmbMaterial.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materiales: " + ex.Message);
            }
        }

       
        private void CargarRecetas()
        {
            try
            {
                dgvRecetas.DataSource = claseRecetas.ObtenerRecetas();
                dgvRecetas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar recetas: " + ex.Message);
            }
        }

       
        private bool ObtenerDatos(
            out int idProducto,
            out int idMaterial,
            out decimal cantidad,
            out decimal? costo)
        {
            idProducto = 0;
            idMaterial = 0;
            cantidad = 0;
            costo = null;

            if (cmbProducto.SelectedIndex == -1 ||
                cmbMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto y un material.");
                return false;
            }

            if (!int.TryParse(
                Convert.ToString(cmbProducto.SelectedValue), out idProducto))
            {
                MessageBox.Show("Seleccione un producto válido.");
                return false;
            }

            if (!int.TryParse(
                Convert.ToString(cmbMaterial.SelectedValue), out idMaterial))
            {
                MessageBox.Show("Seleccione un material válido.");
                return false;
            }

            if (!decimal.TryParse(
                txtCantidad.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor que cero.");
                txtCantidad.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                decimal valorCosto;

                if (!decimal.TryParse(
                    txtCosto.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out valorCosto) || valorCosto < 0)
                {
                    MessageBox.Show("Ingrese un costo válido.");
                    txtCosto.Focus();
                    return false;
                }

                costo = valorCosto;
            }

            return true;
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto;
                int idMaterial;
                decimal cantidad;
                decimal? costo;

                if (!ObtenerDatos(
                    out idProducto,
                    out idMaterial,
                    out cantidad,
                    out costo))
                {
                    return;
                }

                int nuevoId = claseRecetas.RegistrarReceta(
                    idProducto,
                    idMaterial,
                    cantidad,
                    costo);

                MessageBox.Show(
                    "Receta registrada correctamente. ID: " + nuevoId,
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarRecetas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la receta: " + ex.Message);
            }
        }

        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idRecetaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una receta de la tabla.");
                return;
            }

            try
            {
                int idProducto;
                int idMaterial;
                decimal cantidad;
                decimal? costo;

                if (!ObtenerDatos(
                    out idProducto,
                    out idMaterial,
                    out cantidad,
                    out costo))
                {
                    return;
                }

                bool actualizado = claseRecetas.ActualizarReceta(
                    idRecetaSeleccionada,
                    idProducto,
                    idMaterial,
                    cantidad,
                    costo);

                if (actualizado)
                {
                    MessageBox.Show("Receta actualizada correctamente.");
                    CargarRecetas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la receta para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRecetaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una receta de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta receta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                bool eliminado = claseRecetas.EliminarReceta(
                    idRecetaSeleccionada);

                if (eliminado)
                {
                    MessageBox.Show("Receta eliminada correctamente.");
                    CargarRecetas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró la receta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

       
        private void dgvRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = dgvRecetas.Rows[e.RowIndex];

                idRecetaSeleccionada = Convert.ToInt32(
                    fila.Cells["ID"].Value);

                string producto = Convert.ToString(
                    fila.Cells["Producto"].Value);

                string material = Convert.ToString(
                    fila.Cells["Material"].Value);

                txtCantidad.Text = Convert.ToString(
                    fila.Cells["Cantidad requerida"].Value);

                object valorCosto = fila.Cells["Costo unidad"].Value;

                txtCosto.Text = valorCosto == DBNull.Value
                    ? ""
                    : Convert.ToString(valorCosto);

                cmbProducto.SelectedIndex = -1;
                cmbMaterial.SelectedIndex = -1;

                foreach (DataRowView item in cmbProducto.Items)
                {
                    if (Convert.ToString(item["nombreProducto"]) == producto)
                    {
                        cmbProducto.SelectedValue = item["idProducto"];
                        break;
                    }
                }

                foreach (DataRowView item in cmbMaterial.Items)
                {
                    if (Convert.ToString(item["nombreMaterial"]) == material)
                    {
                        cmbMaterial.SelectedValue = item["idMaterial"];
                        break;
                    }
                }

                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la receta: " + ex.Message);
            }
        }

        // Buscar recetas
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvRecetas.DataSource = claseRecetas.BuscarRecetas(
                    txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar recetas: " + ex.Message);
            }
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            idRecetaSeleccionada = 0;

            cmbProducto.SelectedIndex = -1;
            cmbMaterial.SelectedIndex = -1;

            txtCantidad.Clear();
            txtCosto.Clear();
            txtBuscar.Clear();

            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvRecetas.ClearSelection();
        }
    }
}
