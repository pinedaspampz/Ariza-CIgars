using Ariza.CalculoInsumos;
using Ariza.Clientes;
using Ariza.Login;
using Ariza.Usuarios;
using Ariza.Inventario;
using Clases.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;
using Ariza._8.Pedidos;

namespace Ariza.MenuPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            AplicarPermisos();
            btnInventario.Visible = true;
            btnInventario.Enabled = true;
            btnInventario.BringToFront();
            btnInventario.Click += btnInventario_Click;

            toolTip1.SetToolTip(
                btnUsuarios,
                "Abre la lista de usuarios"
            );
        }

        private void AplicarPermisos()
        {
            // Administrador: acceso a Usuarios.
            btnUsuarios.Visible =
                ClaseSesionUsuario.Rol == RolUsuario.Administrador;

            // Administrador, Gestor y Consultor: acceso a Clientes.
            btnClientes.Visible =
                ClaseSesionUsuario.Rol == RolUsuario.Administrador ||
                ClaseSesionUsuario.Rol == RolUsuario.Gestor ||
                ClaseSesionUsuario.Rol == RolUsuario.Consultor;
            btnInventario.Visible = true;
        }

        private void btnCalculoInsumos_Click(object sender, EventArgs e)
        {
            using (var formulario = new FrmCalculoInsumos())
            {
                formulario.StartPosition =
                    FormStartPosition.CenterParent;

                formulario.ShowDialog(this);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
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


        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            frm.Show();
            this.Hide();


        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {


            btnInventario.Visible = true;
            btnInventario.Enabled = true;
            btnInventario.Location = new Point(600, 350);
            btnInventario.Size = new Size(128, 67);
            btnInventario.BringToFront();
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();
            frm.Show();
            this.Hide();
        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCalculoInsumos frm = new FrmCalculoInsumos();
            frm.Show();
            this.Hide();
        }
    }
}