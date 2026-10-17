
using System;
using System.Windows.Forms;
using Ariza.Clientes;
using Ariza.Login;
using Ariza.Usuarios;
using Clases.Clases;

namespace Ariza.MenuPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            // Administrador: acceso completo a estas opciones.
            btnUsuarios.Visible =
                ClaseSesionUsuario.Rol == RolUsuario.Administrador;

            // Administrador, Gestor y Consultor pueden acceder a Clientes.
            btnClientes.Visible =
                ClaseSesionUsuario.Rol == RolUsuario.Administrador ||
                ClaseSesionUsuario.Rol == RolUsuario.Gestor ||
                ClaseSesionUsuario.Rol == RolUsuario.Consultor;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Comprobar permisos antes de abrir el formulario.
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador)
            {
                MessageBox.Show(
                    "No tienes permisos para administrar usuarios.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            FrmUsuarios frm = new FrmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ClaseSesionUsuario.Cerrarsesion();

            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Comprobar permisos antes de abrir el formulario.
            if (ClaseSesionUsuario.Rol != RolUsuario.Administrador &&
                ClaseSesionUsuario.Rol != RolUsuario.Gestor &&
                ClaseSesionUsuario.Rol != RolUsuario.Consultor)
            {
                MessageBox.Show(
                    "No tienes permisos para acceder a Clientes.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            FrmClientes frm = new FrmClientes();
            frm.Show();
            this.Hide();
        }
    }
}
