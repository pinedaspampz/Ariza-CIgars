using Ariza.MenuPrincipal;
using Clases.Clases;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Ariza.Inventario
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();

            this.Load += FrmInventario_Load;
            btnGuardarMaterial.Click += btnGuardarMaterial_Click;
            btnEditarMaterial.Click += btnEditarMaterial_Click;
            btnActualizarMaterial.Click += btnActualizarMaterial_Click;
            txtBuscarMaterial.TextChanged += txtBuscarMaterial_TextChanged;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }


        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            try
            {
                ClaseInventario inventario = new ClaseInventario();

                dgvMateriales.DataSource = inventario.ObtenerMateriales();

                dgvMateriales.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvMateriales.ReadOnly = true;
                dgvMateriales.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvMateriales.MultiSelect = false;
                dgvMateriales.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar materiales: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void btnGuardarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreMaterial.Text.Trim();
                string categoria = cmbCategoria.Text.Trim();
                string unidad = cmbUnidadMedida.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre) ||
                    string.IsNullOrWhiteSpace(categoria) ||
                    string.IsNullOrWhiteSpace(unidad))
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                if (!decimal.TryParse(txtCostoUnidad.Text, out decimal costo)
                    || costo < 0)
                {
                    MessageBox.Show("Ingrese un costo válido.");
                    return;
                }

                ClaseInventario inventario = new ClaseInventario();

                inventario.RegistrarMaterial(
                    categoria, nombre, unidad, costo);

                MessageBox.Show(
                    "Materia prima registrada correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarMateriales();

                txtNombreMaterial.Clear();
                cmbCategoria.SelectedIndex = -1;
                cmbUnidadMedida.SelectedIndex = -1;
                txtCostoUnidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }


        private void cmbUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private int idMaterialSeleccionado = 0;

        private void btnEditarMaterial_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un material de la tabla.");
                return;
            }

            try
            {
                DataGridViewRow fila = dgvMateriales.CurrentRow;

                idMaterialSeleccionado =
                    Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombreMaterial.Text =
                    fila.Cells["Material"].Value.ToString();

                cmbCategoria.Text =
                    fila.Cells["Categoría"].Value.ToString();

                cmbUnidadMedida.Text =
                    fila.Cells["Unidad"].Value.ToString();

                txtCostoUnidad.Text =
                    fila.Cells["Costo"].Value.ToString();

                MessageBox.Show(
                    "Material seleccionado. Ahora puede modificar sus datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar material: " + ex.Message);
            }
        }

        private void btnActualizarMaterial_Click(object sender, EventArgs e)
        {
            if (idMaterialSeleccionado == 0)
            {
                MessageBox.Show("Primero seleccione un material y presione Editar.");
                return;
            }

            string nombre = txtNombreMaterial.Text.Trim();
            string categoria = cmbCategoria.Text.Trim();
            string unidad = cmbUnidadMedida.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(unidad))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtCostoUnidad.Text, out decimal costo)
                || costo < 0)
            {
                MessageBox.Show("Ingrese un costo válido.");
                return;
            }

            try
            {
                ClaseInventario inventario = new ClaseInventario();

                inventario.ActualizarMaterial(
                    idMaterialSeleccionado,
                    categoria,
                    nombre,
                    unidad,
                    costo
                );

                MessageBox.Show(
                    "Materia prima actualizada correctamente.",
                    "Actualización exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarMateriales();

                txtNombreMaterial.Clear();
                cmbCategoria.SelectedIndex = -1;
                cmbUnidadMedida.SelectedIndex = -1;
                txtCostoUnidad.Clear();

                idMaterialSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }


        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un material de la tabla.");
                return;
            }

            try
            {
                DataGridViewRow fila = dgvMateriales.CurrentRow;

                int id = Convert.ToInt32(fila.Cells["ID"].Value);

                string estadoActual =
                    fila.Cells["Estado"].Value.ToString();

                bool activar = estadoActual == "Inactivo";

                string nuevoEstado = activar ? "activar" : "desactivar";

                DialogResult respuesta = MessageBox.Show(
                    "¿Desea " + nuevoEstado + " este material?",
                    "Confirmar cambio",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                ClaseInventario inventario = new ClaseInventario();

                inventario.CambiarEstado(id, activar);

                MessageBox.Show(
                    "Estado del material actualizado correctamente.",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarMateriales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cambiar estado: " + ex.Message
                );
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreMaterial.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = "";
            cmbUnidadMedida.SelectedIndex = -1;
            cmbUnidadMedida.Text = "";
            txtCostoUnidad.Clear();
            txtBuscarMaterial.Clear();

            idMaterialSeleccionado = 0;

            dgvMateriales.ClearSelection();

            CargarMateriales();

            MessageBox.Show("Campos limpiados correctamente.");
        }



        private void txtBuscarMaterial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClaseInventario inventario = new ClaseInventario();

                string buscar = txtBuscarMaterial.Text.Trim();

                if (string.IsNullOrWhiteSpace(buscar))
                {
                    CargarMateriales();
                }
                else
                {
                    dgvMateriales.DataSource =
                        inventario.BuscarMateriales(buscar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar materiales: " + ex.Message
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            Hide();
        }
    }

}






