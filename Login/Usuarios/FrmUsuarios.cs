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
            CargarUsuarios();
            CargarRoles();
        }
    }
}
