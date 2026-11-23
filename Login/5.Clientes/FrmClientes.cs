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
        private bool creandoCliente = false;

        private bool PuedeEditarClientes()
        {
            return ClaseSesionUsuario.Rol == RolUsuario.Administrador ||
                   ClaseSesionUsuario.Rol == RolUsuario.Gestor;
        }

        public FrmClientes()
        {
            InitializeComponent();

            txtTelefono.MaxLength = 9; //siempre validación telefono 
            txtTelefono.TextChanged += txtTelefono_TextChanged; //validación del tefono 
            ConfigurarDiseno();

            // Dejar una sola conexión para cada evento.
            Load -= FrmClientes_Load;
            Load += FrmClientes_Load;

            btnGuardarCliente.Click -= btnGuardarCliente_Click;
            btnGuardarCliente.Click += btnGuardarCliente_Click;

            btnLimpiar.Click -= btnLimpiar_Click;
            btnLimpiar.Click += btnLimpiar_Click;

            btnEditarCliente.Click -= btnEditarCliente_Click;
            btnEditarCliente.Click += btnEditarCliente_Click;

            btnActualizarCliente.Click -= btnActualizarCliente_Click;
            btnActualizarCliente.Click += btnActualizarCliente_Click;

            btnBuscarCliente.Click -= btnBuscarCliente_Click;
            btnBuscarCliente.Click += btnBuscarCliente_Click;

            txtBuscarCliente.TextChanged -= txtBuscarCliente_TextChanged;
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;

            btnEliminarCliente.Click -= btnEliminarCliente_Click;
            btnEliminarCliente.Click += btnEliminarCliente_Click;

            btnMenuPrincpal.Click -= btnMenuPrincpal_Click;
            btnMenuPrincpal.Click += btnMenuPrincpal_Click;

            dvgClientes.CellClick -= dvgClientes_CellClick;
            dvgClientes.CellClick += dvgClientes_CellClick;

            dvgClientes.ReadOnly = true;
            dvgClientes.AllowUserToAddRows = false;
            dvgClientes.AllowUserToDeleteRows = false;
            dvgClientes.MultiSelect = false;
            dvgClientes.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dvgClientes.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            ActualizarBotones();
        }

        private void ConfigurarDiseno()
        {
            Color beigeAriza = Color.FromArgb(234, 220, 185);

            ClientSize = new Size(914, 650);
            MinimumSize = Size;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(248, 246, 241);

            button2.Visible = false;

            Panel encabezado = new Panel
            {
                Dock = DockStyle.Top,
                Height = 108,
                BackColor = beigeAriza
            };

            PictureBox logoAriza = new PictureBox
            {
                Image = Properties.Resources.arizat,
                SizeMode = PictureBoxSizeMode.Zoom,
                Bounds = new Rectangle(30, 8, 78, 92)
            };

            Label marcaAriza = new Label
            {
                Text = "ARIZA",
                AutoSize = false,
                Font = new Font("Segoe UI", 34F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(350, 108)
            };

            encabezado.Controls.Add(logoAriza);
            encabezado.Controls.Add(marcaAriza);
            Controls.Add(encabezado);

            encabezado.Controls.Add(btnMenuPrincpal);

            btnMenuPrincpal.Text = "Menú Principal";
            btnMenuPrincpal.Size = new Size(160, 38);
            btnMenuPrincpal.Anchor =
                AnchorStyles.Top | AnchorStyles.Left;

            encabezado.Resize += (sender, e) =>
            {
                marcaAriza.Left =
                    (encabezado.ClientSize.Width - marcaAriza.Width) / 2;

                btnMenuPrincpal.Location =
                    new Point(encabezado.ClientSize.Width - 180, 35);
            };

            marcaAriza.Left =
                (encabezado.ClientSize.Width - marcaAriza.Width) / 2;

            btnMenuPrincpal.Location =
                new Point(encabezado.ClientSize.Width - 180, 35);

            btnMenuPrincpal.BringToFront();

            label4.Text = "Clientes";
            label4.Font = new Font(
                "Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(30, 125);

            label1.Text = "Nombre completo";
            label1.Location = new Point(30, 176);
            txtNombreCompleto.SetBounds(30, 200, 410, 28);

            label2.Text = "Teléfono";
            label2.Location = new Point(470, 176);
            txtTelefono.SetBounds(470, 200, 414, 28);

            label3.Text = "Correo electrónico";
            label3.Location = new Point(30, 238);
            txtCorreo.SetBounds(30, 262, 410, 28);

            Controls.Add(new Label
            {
                Text = "Buscar cliente",
                AutoSize = true,
                Location = new Point(470, 238)
            });

            txtBuscarCliente.SetBounds(470, 262, 264, 28);
            btnBuscarCliente.SetBounds(744, 260, 140, 32);

            txtBuscarCliente.Visible = true;
            txtBuscarCliente.Enabled = true;
            btnBuscarCliente.Visible = true;
            btnBuscarCliente.Enabled = true;

            // Reutilizar el botón Editar como Agregar.
            btnEditarCliente.Text = "Agregar cliente";
            btnActualizarCliente.Text = "Actualizar cliente";
            btnGuardarCliente.Text = "Guardar cliente";
            btnLimpiar.Text = "Cancelar";

            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.BackColor = beigeAriza;

            dvgClientes.SetBounds(30, 378, 854, 242);
            dvgClientes.Anchor =
                AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Left | AnchorStyles.Right;
        }

        private void ActualizarBotones()
        {
            bool puedeEditar = PuedeEditarClientes();
            bool haySeleccion = idClienteSeleccionado > 0;

            btnEditarCliente.Visible = puedeEditar;

            btnGuardarCliente.Visible =
                puedeEditar && creandoCliente;

            btnActualizarCliente.Visible =
                puedeEditar && haySeleccion && !creandoCliente;

            btnEliminarCliente.Visible =
                ClaseSesionUsuario.Rol == RolUsuario.Administrador &&
                haySeleccion && !creandoCliente;

            btnLimpiar.Visible = creandoCliente || haySeleccion;

            txtNombreCompleto.ReadOnly = !puedeEditar;
            txtTelefono.ReadOnly = !puedeEditar;
            txtCorreo.ReadOnly = !puedeEditar;

            // Acomodar solo los botones visibles, sin dejar huecos.
            int posicionX = 30;

            Button[] botones =
            {
                btnEditarCliente,
                btnGuardarCliente,
                btnActualizarCliente,
                btnEliminarCliente,
                btnLimpiar
            };

            foreach (Button boton in botones)
            {
                // Se consulta la visibilidad local al abrir el formulario.
                bool mostrar;

                if (boton == btnEditarCliente)
                {
                    mostrar = puedeEditar;
                }
                else if (boton == btnGuardarCliente)
                {
                    mostrar = puedeEditar && creandoCliente;
                }
                else if (boton == btnActualizarCliente)
                {
                    mostrar = puedeEditar &&
                              haySeleccion && !creandoCliente;
                }
                else if (boton == btnEliminarCliente)
                {
                    mostrar =
                        ClaseSesionUsuario.Rol == RolUsuario.Administrador &&
                        haySeleccion && !creandoCliente;
                }
                else
                {
                    mostrar = creandoCliente || haySeleccion;
                }

                if (mostrar)
                {
                    boton.SetBounds(posicionX, 315, 200, 38);
                    posicionX += 218;
                }
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador &&
                ClaseSesionUsuario.Rol != RolUsuario.Gestor &&
                ClaseSesionUsuario.Rol != RolUsuario.Consultor)
            {
                MessageBox.Show(
                    "No tienes permisos para acceder a Clientes.");
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

                // Mantener el filtro de búsqueda al recargar.
                if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
                {
                    dvgClientes.DataSource = clientes.ObtenerClientes();
                }
                else
                {
                    dvgClientes.DataSource = clientes.BuscarClientes(
                        txtBuscarCliente.Text.Trim());
                }

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar clientes: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            idClienteSeleccionado = 0;
            creandoCliente = false;

            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            dvgClientes.ClearSelection();
            dvgClientes.CurrentCell = null;

            ActualizarBotones();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (!PuedeEditarClientes())
            {
                MessageBox.Show(
                    "Tu rol solo permite consultar clientes.");
                return;
            }

            LimpiarCampos();

            creandoCliente = true;
            ActualizarBotones();
            txtNombreCompleto.Focus();
        }

        private void dvgClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dvgClientes.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                return;
            }

            idClienteSeleccionado =
                Convert.ToInt32(fila.Cells["ID"].Value);

            txtNombreCompleto.Text =
                Convert.ToString(fila.Cells["Nombre completo"].Value);

            txtTelefono.Text =
                Convert.ToString(fila.Cells["Teléfono"].Value);

            txtCorreo.Text =
                Convert.ToString(fila.Cells["Correo"].Value);

            creandoCliente = false;
            ActualizarBotones();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string texto = txtTelefono.Text;

            if (texto.Length == 4 &&
                txtTelefono.SelectionStart == 4 &&
                System.Text.RegularExpressions.Regex.IsMatch(texto, @"\A[0-9]{4}\z"))
            {
                txtTelefono.Text = texto + "-";
                txtTelefono.SelectionStart = txtTelefono.Text.Length;
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("El nombre completo es obligatorio.");
                txtNombreCompleto.Focus();
                return false;
            }

            if (txtNombreCompleto.Text.Trim().Length > 150 ||
                txtCorreo.Text.Trim().Length > 100)
            {
                MessageBox.Show(
                    "El nombre permite hasta 150 caracteres y el correo hasta 100.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtTelefono.Text.Trim(), @"\A[0-9]{4}-[0-9]{4}\z"))
            {
                MessageBox.Show(
                    "El teléfono debe tener este formato: 5545-8562.",
                    "Teléfono inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (!PuedeEditarClientes())
            {
                MessageBox.Show(
                    "Tu rol solo permite consultar clientes.");
                return;
            }

            if (!creandoCliente)
            {
                MessageBox.Show(
                    "Pulsa Agregar cliente para crear un registro.");
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                ClaseClientes clientes = new ClaseClientes();

                clientes.RegistrarCliente(
                    txtNombreCompleto.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim());

                LimpiarCampos();
                CargarClientes();

                MessageBox.Show(
                    "Cliente registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar cliente: " + ex.Message);
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (!PuedeEditarClientes())
            {
                MessageBox.Show(
                    "No tienes permisos para editar clientes.");
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show(
                    "Primero selecciona un cliente de la tabla.");
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                ClaseClientes clientes = new ClaseClientes();

                clientes.ActualizarCliente(
                    idClienteSeleccionado,
                    txtNombreCompleto.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtCorreo.Text.Trim());

                LimpiarCampos();
                CargarClientes();

                MessageBox.Show(
                    "Cliente actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar cliente: " + ex.Message);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador)
            {
                MessageBox.Show(
                    "Solo el administrador puede eliminar clientes.");
                return;
            }

            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show(
                    "Primero selecciona un cliente de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Deseas eliminar al cliente {txtNombreCompleto.Text}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                ClaseClientes clientes = new ClaseClientes();
                clientes.EliminarCliente(idClienteSeleccionado);

                LimpiarCampos();
                CargarClientes();

                MessageBox.Show(
                    "Cliente eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el cliente: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void txtBuscarCliente_TextChanged(
            object sender,
            EventArgs e)
        {
            BuscarClientes();
        }

        private void BuscarClientes()
        {
            CargarClientes();
        }

        private void btnMenuPrincpal_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            Hide();
        }
    }
}