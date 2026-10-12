using Ariza.MenuPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ariza.Login;
namespace Ariza.Principal
{
    public partial class FrmPrincipal : Form
    {
        public static FrmPrincipal Contenedor { get; private set; }
        private Form _PantallaActual;
        public FrmPrincipal()
        {
            InitializeComponent();
            Contenedor = this;

        }
        public void Cargar(Form nuevaPantalla)
        {
            Form anterior = _PantallaActual;   
            _PantallaActual = nuevaPantalla;   

            nuevaPantalla.TopLevel = false;                        
            nuevaPantalla.FormBorderStyle = FormBorderStyle.None;  
            nuevaPantalla.Dock = DockStyle.Fill;                   

            PanelContenido.Controls.Clear();            
            PanelContenido.Controls.Add(nuevaPantalla); 
            nuevaPantalla.Show();                    

            anterior?.Dispose();   
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Cargar(new FrmLogin());
        }
    }
}
