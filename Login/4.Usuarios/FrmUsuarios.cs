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
        public FrmUsuarios()
        {
            InitializeComponent();
            this.Load += FrmUsuarios_Load;
            this.btnGuardarUsuario.Click += btnGuardarUsuario_Click;
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
