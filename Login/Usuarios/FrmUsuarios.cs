using Ariza.Clientes;
using Ariza.MenuPrincipal;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases.Clases;
namespace Ariza.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;
        public FrmUsuarios()
        {
            InitializeComponent();

            DatosUsuarios.ReadOnly = true;
            DatosUsuarios.AllowUserToAddRows = false;
            DatosUsuarios.MultiSelect = false;
            DatosUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosUsuarios.CellClick += DatosUsuarios_CellClick;
            btnActualizarUsuario.Click += btnActualizarUsuario_Click;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;

            Color beigeAriza = Color.FromArgb(234, 220, 185);
            BackColor = Color.FromArgb(248, 246, 241);

            // Encabezado con el mismo logo y color del menú principal.
            Panel encabezado = new Panel
            {
                BackColor = beigeAriza,
                Dock = DockStyle.Top,
                Height = 108
            };

            PictureBox logoAriza = new PictureBox
            {
                Image = Properties.Resources.arizat,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(30, 8),
                Size = new Size(78, 92)
            };

            Label marcaAriza = new Label
            {
                Text = "ARIZA",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 34F, FontStyle.Bold),
                Bounds = new Rectangle(220, 0, 474, 108),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            encabezado.Controls.Add(logoAriza);
            encabezado.Controls.Add(marcaAriza);
            Controls.Add(encabezado);

            encabezado.Controls.Add(btnMenuPrincipal);
            btnMenuPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnMenuPrincipal.Size = new Size(160, 38);
            btnMenuPrincipal.Location = new Point(encabezado.ClientSize.Width - 180, 35);
            btnMenuPrincipal.BringToFront();
            marcaAriza.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            marcaAriza.Left = (encabezado.ClientSize.Width - marcaAriza.Width) / 2;

            encabezado.Resize += (sender, e) =>
            {
                btnMenuPrincipal.Left = encabezado.ClientSize.Width - 180;
                marcaAriza.Left = (encabezado.ClientSize.Width - marcaAriza.Width) / 2;
            };

            // Título y campos en dos columnas.
            label1.Location = new Point(30, 125);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);

            label2.Location = new Point(30, 176);
            txtNombreCompleto.SetBounds(30, 200, 410, 28);

            label3.Location = new Point(470, 176);
            txtNombreUsuario.SetBounds(470, 200, 414, 28);

            label4.Location = new Point(30, 238);
            txtContrasena.SetBounds(30, 262, 410, 28);

            Controls.Add(new Label
            {
                Text = "Rol",
                AutoSize = true,
                Location = new Point(470, 238)
            });
            cmbRoles.SetBounds(470, 262, 414, 28);

            // Acciones alineadas entre el formulario y la tabla.
            btnAgregarUsuario.SetBounds(30, 312, 206, 38);
            btnGuardarUsuario.SetBounds(246, 312, 206, 38);
            btnActualizarUsuario.SetBounds(462, 312, 206, 38);
            btnEliminarUsuario.SetBounds(678, 312, 206, 38);

            btnGuardarUsuario.UseVisualStyleBackColor = false;
            btnGuardarUsuario.BackColor = beigeAriza;

            DatosUsuarios.SetBounds(30, 370, 854, 200);
            DatosUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                   AnchorStyles.Left | AnchorStyles.Right;
            DatosUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //posibles cambios hechos por mí persona
            this.Load += FrmUsuarios_Load;
            btnGuardarUsuario.Click -= btnGuardarUsuario_Click;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // prueba 
            btnGuardarUsuario.Visible = false;
            btnActualizarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            idUsuarioSeleccionado = 0;

            txtNombreCompleto.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();

            if (cmbRoles.Items.Count > 0)
            {
                cmbRoles.SelectedIndex = 0;
            }

            DatosUsuarios.ClearSelection();
            DatosUsuarios.CurrentCell = null;

            btnGuardarUsuario.Visible = true;
            btnGuardarUsuario.Enabled = true;
            btnActualizarUsuario.Visible = false;
            btnEliminarUsuario.Visible = false;

            txtNombreCompleto.Focus();
        }

        private void DatosUsuarios_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = DatosUsuarios.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                return;
            }

            idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);

            txtNombreCompleto.Text =
                Convert.ToString(fila.Cells["Nombre completo"].Value);

            txtNombreUsuario.Text =
                Convert.ToString(fila.Cells["Usuario"].Value);

            string nombreRol =
                Convert.ToString(fila.Cells["Rol"].Value).Trim();

            cmbRoles.SelectedIndex = 0;

            for (int indice = 0; indice < cmbRoles.Items.Count; indice++)
            {
                Rol rol = (Rol)cmbRoles.Items[indice];

                if (string.Equals(
                    rol.Nombre.Trim(),
                    nombreRol,
                    StringComparison.OrdinalIgnoreCase))
                {
                    cmbRoles.SelectedIndex = indice;
                    break;
                }
            }

            txtContrasena.Clear();
            btnGuardarUsuario.Visible = false;

            btnActualizarUsuario.Visible = true;
            btnActualizarUsuario.Enabled = true;

            btnEliminarUsuario.Visible = true;
            btnEliminarUsuario.Enabled = true;
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show("Solo el administrador puede actualizar usuarios.");
                return;
            }

            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Primero selecciona un usuario de la tabla.");
                return;
            }

            string nombre = txtNombreCompleto.Text.Trim();
            string usuario = txtNombreUsuario.Text.Trim();
            string clave = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El nombre completo y el usuario son obligatorios.");
                return;
            }

            if (nombre.Length > 150 || usuario.Length > 50 || clave.Length > 256)
            {
                MessageBox.Show(
                    "Máximos permitidos: nombre de 150 caracteres, " +
                    "usuario de 50 y contraseña de 256.");
                return;
            }

            if (cmbRoles.SelectedValue == null ||
                !int.TryParse(cmbRoles.SelectedValue.ToString(), out int idRol) ||
                idRol <= 0)
            {
                MessageBox.Show("Selecciona un rol válido.");
                return;
            }

            if (clave.Length > 0 &&
                (clave.Length < 8 ||
                 !System.Text.RegularExpressions.Regex.IsMatch(clave, @"\p{Lu}") ||
                 !System.Text.RegularExpressions.Regex.IsMatch(clave, @"\p{Ll}") ||
                 !System.Text.RegularExpressions.Regex.IsMatch(clave, @"[0-9]") ||
                 !System.Text.RegularExpressions.Regex.IsMatch(clave, @"[\p{P}\p{S}]")))
            {
                MessageBox.Show(
                    "La contraseña nueva debe tener al menos 8 caracteres, " +
                    "una mayúscula, una minúscula, un número y un símbolo.");
                return;
            }

            Rol rolElegido = (Rol)cmbRoles.SelectedItem;

            if (idUsuarioSeleccionado == ClaseSesionUsuario.idUsuario &&
                !string.Equals(
                    rolElegido.Nombre.Trim(),
                    "Administrador",
                    StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Usa otra cuenta administradora para cambiar tu propio rol.");
                return;
            }

            try
            {
                ClaseUsuarios usuarios = new ClaseUsuarios();

                usuarios.ActualizarUsuario(
                    idUsuarioSeleccionado,
                    nombre,
                    usuario,
                    clave,
                    idRol);

                if (idUsuarioSeleccionado == ClaseSesionUsuario.idUsuario)
                {
                    ClaseSesionUsuario.NombreUsuario = usuario;
                    ClaseSesionUsuario.NombreCompleto = nombre;
                }

                CargarUsuarios();

                idUsuarioSeleccionado = 0;
                txtNombreCompleto.Clear();
                txtNombreUsuario.Clear();
                txtContrasena.Clear();
                cmbRoles.SelectedIndex = 0;
                DatosUsuarios.ClearSelection();

                idUsuarioSeleccionado = 0;
                DatosUsuarios.ClearSelection();
                DatosUsuarios.CurrentCell = null;

                btnGuardarUsuario.Visible = false;
                btnActualizarUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
                when (ex.Number == 2601 || ex.Number == 2627)
            {
                MessageBox.Show("Ese nombre de usuario ya está registrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show("Solo el administrador puede eliminar usuarios.");
                return;
            }

            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Primero selecciona un usuario de la tabla.");
                return;
            }

            if (idUsuarioSeleccionado == ClaseSesionUsuario.idUsuario)
            {
                MessageBox.Show(
                    "Usa otra cuenta administradora para eliminar tu propia cuenta.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                $"¿Deseas eliminar al usuario {txtNombreUsuario.Text}?",
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
                ClaseUsuarios usuarios = new ClaseUsuarios();
                usuarios.EliminarUsuario(idUsuarioSeleccionado);

                CargarUsuarios();

                idUsuarioSeleccionado = 0;
                txtNombreCompleto.Clear();
                txtNombreUsuario.Clear();
                txtContrasena.Clear();
                cmbRoles.SelectedIndex = 0;
                DatosUsuarios.ClearSelection();

                idUsuarioSeleccionado = 0;
                DatosUsuarios.ClearSelection();
                DatosUsuarios.CurrentCell = null;

                btnGuardarUsuario.Visible = false;
                btnActualizarUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
                when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Este usuario tiene registros relacionados y no se puede eliminar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {

            FrmMenuPrincipal frm = new FrmMenuPrincipal();
            frm.Show();
            this.Hide();
        }

        private void CargarUsuarios()
        {
            try
            {
                ClaseUsuarios usuarios = new ClaseUsuarios();
                DatosUsuarios.DataSource = usuarios.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }

        }

        private void CargarRoles()
        {
            try
            {
                ClaseUsuarios usuarios = new ClaseUsuarios();
                List<Rol> roles = usuarios.ObtenerRoles();
                roles.Insert(0, new Rol { IdRol = 0, Nombre = "Asignar Rol" });

                cmbRoles.DataSource = roles;          // ← la variable, no ObtenerRoles()
                cmbRoles.DisplayMember = "Nombre";
                cmbRoles.ValueMember = "IdRol";
                cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbRoles.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
            }

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            if (!EsAdministrador())
            {
                MessageBox.Show(
                    "No tienes permisos para administrar usuarios.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                this.Close();
                return;
            }

            CargarUsuarios();
            CargarRoles();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar que el usuario sea administrador
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador)
            {
                MessageBox.Show(
                    "Solo el administrador puede registrar usuarios.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Obtener los datos de los campos
            string nombreCompleto = txtNombreCompleto.Text.Trim();
            string nombreUsuario = txtNombreUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validar que los campos estén completos
            if (string.IsNullOrWhiteSpace(nombreCompleto) ||
                string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Todos los campos son obligatorios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            if (contrasena.Length < 8 ||
            !System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"\p{Lu}") ||
            !System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"\p{Ll}") ||
            !System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[0-9]") ||
            !System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[\p{P}\p{S}]"))
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 8 caracteres, una mayúscula, " +
                    "una minúscula, un número y un símbolo como !, @ o #.",
                    "Contraseña inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            // Validar que se haya seleccionado un rol
            if (cmbRoles.SelectedValue == null ||
                !int.TryParse(cmbRoles.SelectedValue.ToString(), out int idRol) ||
                idRol <= 0)
            {
                MessageBox.Show(
                    "Selecciona un rol válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                ClaseUsuarios usuarios = new ClaseUsuarios();

                // Comprobar si el nombre de usuario ya existe
                if (usuarios.ExisteUsuario(nombreUsuario))
                {
                    MessageBox.Show(
                        "Ese nombre de usuario ya existe.",
                        "Usuario duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Registrar el usuario con el rol seleccionado
                usuarios.RegistrarUsuario(
                    nombreCompleto,
                    nombreUsuario,
                    contrasena,
                    idRol
                );

                MessageBox.Show(
                    "Usuario registrado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpiar los campos
                txtNombreCompleto.Clear();
                txtNombreUsuario.Clear();
                txtContrasena.Clear();
                cmbRoles.SelectedIndex = 0;

                // Actualizar la tabla
                CargarUsuarios();
                idUsuarioSeleccionado = 0;
                DatosUsuarios.ClearSelection();
                DatosUsuarios.CurrentCell = null;

                btnGuardarUsuario.Visible = false;
                btnActualizarUsuario.Visible = false;
                btnEliminarUsuario.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al registrar el usuario: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Agrega este método privado a la clase FrmUsuarios para corregir el error CS0103
        private bool EsAdministrador()
        {
            return ClaseSesionUsuario.Rol == RolUsuario.Administrador;
        }
    }
}
