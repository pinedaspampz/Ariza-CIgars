using Ariza.MenuPrincipal;
using Clases.Clases;

namespace Ariza.Login;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();

    }

    private void btningresar_Click(object sender, EventArgs e)
    {
        string usuario = txtusuario.Text.Trim();
        string clave = txtclave.Text;

        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
        {
            MessageBox.Show("Ambos campos son obligatorios");
            return;
        }

        try
        {
            ClaseConexion conexion = new ClaseConexion();

            if (conexion.ValidarLogin(usuario, clave,
                                      out int id, out string nombreCompleto, out string rol))
            {
                ClaseSesionUsuario.IniciarSesion(id, usuario, nombreCompleto, rol);

                FrmMenuPrincipal frm = new FrmMenuPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
