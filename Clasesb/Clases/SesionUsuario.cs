using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clases
{
    public static class SesionUsuario
    {
        public static int IdUsuario { get; set; }
        public static string NombreCompleto { get; set; } = "";
        public static string NombreUsuario { get; set; } = "";
        public static string Rol { get; set; } = "";

        public static bool EsAdministrador
        {
            get
            {
                return Rol.Equals(
                    "Administrador",
                    System.StringComparison.OrdinalIgnoreCase);
            }
        }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            NombreCompleto = "";
            NombreUsuario = "";
            Rol = "";
        }
    }
}
