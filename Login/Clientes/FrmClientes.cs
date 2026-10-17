
using Ariza.MenuPrincipal;
using Clases.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ariza.Clientes
{
    public partial class FrmClientes : Form
    {
        private int idClienteSeleccionado = 0;

        public FrmClientes()
        {
            InitializeComponent();

            this.Load += FrmClientes_Load;

            btnGuardarCliente.Click += btnGuardarCliente_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnEditarCliente.Click += btnEditarCliente_Click;
            btnActualizarCliente.Click += btnActualizarCliente_Click;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            btnEliminarCliente.Click += btnEliminarCliente_Click;

            // Asegurar que los controles de búsqueda sean visibles.
            txtBuscarCliente.Visible = true;
            txtBuscarCliente.Enabled = true;
            btnBuscarCliente.Visible = true;
            btnBuscarCliente.Enabled = true;

            // Evitar que queden detrás de otros controles.
            txtBuscarCliente.BringToFront();
            btnBuscarCliente.BringToFront();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol == RolUsuario.Invitado ||
                ClaseSesionUsuario.Rol == RolUsuario.Nadie)
            {
                MessageBox.Show("No tienes permisos para acceder a Clientes.");
                Close();
                return;
            }

            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                ClaseClientes clientes = new ClaseClientes();
                dvgClientes.DataSource = clientes.ObtenerClientes();

                dvgClientes.ReadOnly = true;
                dvgClientes.AllowUserToAddRows = false;
                dvgClientes.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dvgClientes.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador &&
                ClaseSesionUsuario.Rol != RolUsuario.Gestor)
            {
                MessageBox.Show("Tu rol solo permite consultar clientes.");
                return;
            }

            string nombre = txtNombreCompleto.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre completo es obligatorio.");
                txtNombreCompleto.Focus();
                return;
            }

            if (nombre.Length > 150 ||
                telefono.Length > 20 ||
                correo.Length > 100)
            {
                MessageBox.Show("Uno de los campos supera la longitud permitida.");
                return;
            }

            try
            {
                ClaseClientes clientes = new ClaseClientes();
                clientes.RegistrarCliente(nombre, telefono, correo);

                MessageBox.Show("Cliente registrado correctamente.");

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dvgClientes.CurrentRow == null ||
                dvgClientes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            idClienteSeleccionado = Convert.ToInt32(
                dvgClientes.CurrentRow.Cells["ID"].Value);

            txtNombreCompleto.Text = Convert.ToString(
                dvgClientes.CurrentRow.Cells["Nombre completo"].Value);

            txtTelefono.Text = Convert.ToString(
                dvgClientes.CurrentRow.Cells["Teléfono"].Value);

            txtCorreo.Text = Convert.ToString(
                dvgClientes.CurrentRow.Cells["Correo"].Value);

            MessageBox.Show("Modifica los datos y pulsa Guardar cambios.");
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador &&
                ClaseSesionUsuario.Rol != RolUsuario.Gestor)
            {
                MessageBox.Show("No tienes permisos para editar clientes.");
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Primero selecciona un cliente y pulsa Editar cliente.");
                return;
            }

            string nombre = txtNombreCompleto.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre completo es obligatorio.");
                return;
            }

            if (nombre.Length > 150 ||
                telefono.Length > 20 ||
                correo.Length > 100)
            {
                MessageBox.Show("Uno de los campos supera la longitud permitida.");
                return;
            }

            try
            {
                ClaseClientes clientes = new ClaseClientes();

                clientes.ActualizarCliente(
                    idClienteSeleccionado,
                    nombre,
                    telefono,
                    correo);

                MessageBox.Show("Cliente actualizado correctamente.");

                idClienteSeleccionado = 0;
                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            try
            {
                ClaseClientes clientes = new ClaseClientes();

                dvgClientes.DataSource = clientes.BuscarClientes(
                    txtBuscarCliente.Text.Trim());

                dvgClientes.ReadOnly = true;
                dvgClientes.AllowUserToAddRows = false;
                dvgClientes.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dvgClientes.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombreCompleto.Focus();
            idClienteSeleccionado = 0;
        }

        private void btnMenuPrincpal_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            Hide();
        }
    
    private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador)
            {
                MessageBox.Show("Solo el Administrador puede eliminar clientes.");
                return;
            }

            if (dvgClientes.CurrentRow == null ||
                dvgClientes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            int idCliente = Convert.ToInt32(
                dvgClientes.CurrentRow.Cells["ID"].Value);

            string nombre = Convert.ToString(
                dvgClientes.CurrentRow.Cells["Nombre completo"].Value);

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que deseas eliminar al cliente {nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                ClaseClientes clientes = new ClaseClientes();
                clientes.EliminarCliente(idCliente);

                MessageBox.Show("Cliente eliminado correctamente.");

                idClienteSeleccionado = 0;
                txtNombreCompleto.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();

                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
