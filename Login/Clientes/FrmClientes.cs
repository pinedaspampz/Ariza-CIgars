using Ariza.MenuPrincipal;
using Clases.Clases;
using System;
using System.Drawing;
using System.Net.Mail;
using System.Windows.Forms;

namespace Ariza.Clientes
{
    public partial class FrmClientes : Form
    {
        private int idClienteSeleccionado = 0;
        private string nombreClienteSeleccionado = "";

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

            
            dvgClientes.CellClick += dvgClientes_CellClick;

           
            txtBuscarCliente.Visible = true;
            txtBuscarCliente.Enabled = true;
            btnBuscarCliente.Visible = true;
            btnBuscarCliente.Enabled = true;

           
            txtBuscarCliente.BringToFront();
            btnBuscarCliente.BringToFront();
        }

        private void FrmClientes_Load(object? sender, EventArgs e)
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

        private void ConfigurarGrid()
        {
            dvgClientes.ReadOnly = true;
            dvgClientes.AllowUserToAddRows = false;
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarClientes()
        {
            try
            {
                ClaseClientes clientes = new ClaseClientes();
                dvgClientes.DataSource = clientes.ObtenerClientes();
                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnBuscarCliente_Click(object? sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void txtBuscarCliente_TextChanged(object? sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            try
            {
           
                LimpiarFormulario();

                ClaseClientes clientes = new ClaseClientes();
                dvgClientes.DataSource = clientes.BuscarClientes(
                    txtBuscarCliente.Text.Trim());
                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
            }
        }

       
        private void dvgClientes_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // clic en el encabezado

            DataGridViewRow fila = dvgClientes.Rows[e.RowIndex];

            idClienteSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
            nombreClienteSeleccionado = Convert.ToString(fila.Cells["Nombre completo"].Value) ?? "";

            txtNombreCompleto.Text = nombreClienteSeleccionado;
            txtTelefono.Text = Convert.ToString(fila.Cells["Teléfono"].Value);
            txtCorreo.Text = Convert.ToString(fila.Cells["Correo"].Value);
        }

       

        private void btnGuardarCliente_Click(object? sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador &&
                ClaseSesionUsuario.Rol != RolUsuario.Gestor)
            {
                MessageBox.Show("Tu rol solo permite consultar clientes.");
                return;
            }

            if (idClienteSeleccionado != 0)
            {
                MessageBox.Show(
                    "Hay un cliente seleccionado. Pulsa Limpiar para registrar uno nuevo " +
                    "o Guardar cambios para actualizarlo.");
                return;
            }

            string nombre = txtNombreCompleto.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (!ValidarCampos(nombre, telefono, correo))
                return;

            try
            {
                ClaseClientes clientes = new ClaseClientes();
                int nuevoId = clientes.RegistrarCliente(nombre, telefono, correo);

                if (nuevoId > 0)
                {
                    MessageBox.Show(
                        "Cliente registrado correctamente. ID asignado: " + nuevoId);
                    LimpiarCampos();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        // ---------- Editar / actualizar ----------

        private void btnEditarCliente_Click(object? sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            // Los datos ya se cargaron al seleccionar la fila
            txtNombreCompleto.Focus();
            MessageBox.Show("Modifica los datos y pulsa Guardar cambios.");
        }

        private void btnActualizarCliente_Click(object? sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador &&
                ClaseSesionUsuario.Rol != RolUsuario.Gestor)
            {
                MessageBox.Show("No tienes permisos para editar clientes.");
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Primero selecciona un cliente de la tabla.");
                return;
            }

            string nombre = txtNombreCompleto.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (!ValidarCampos(nombre, telefono, correo))
                return;

            try
            {
                ClaseClientes clientes = new ClaseClientes();

                bool actualizado = clientes.ActualizarCliente(
                    idClienteSeleccionado,
                    nombre,
                    telefono,
                    correo);

                if (actualizado)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    LimpiarCampos();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message);
            }
        }


        private void btnEliminarCliente_Click(object? sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador)
            {
                MessageBox.Show("Solo el Administrador puede eliminar clientes.");
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Seguro que deseas eliminar al cliente {nombreClienteSeleccionado}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                ClaseClientes clientes = new ClaseClientes();
                bool eliminado = clientes.EliminarCliente(idClienteSeleccionado);

                if (eliminado)
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                    LimpiarCampos();
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente.");
                }
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

        private bool ValidarCampos(string nombre, string telefono, string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre completo es obligatorio.");
                txtNombreCompleto.Focus();
                return false;
            }

            if (nombre.Length > 150 || telefono.Length > 20 || correo.Length > 100)
            {
                MessageBox.Show("Uno de los campos supera la longitud permitida.");
                return false;
            }

            
            if (correo != "" && !CorreoValido(correo))
            {
                MessageBox.Show("El formato del correo no es válido.");
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private static bool CorreoValido(string correo)
        {
            return MailAddress.TryCreate(correo, out MailAddress? direccion)
                   && direccion.Address == correo;
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
        }

       
        private void LimpiarFormulario()
        {
            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            idClienteSeleccionado = 0;
            nombreClienteSeleccionado = "";
        }

        private void LimpiarCampos()
        {
            LimpiarFormulario();
            txtNombreCompleto.Focus();
        }

        private void btnMenuPrincpal_Click(object? sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            Hide();
        }
    }
}