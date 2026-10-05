using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMockup.Clases
{
    internal class ClaseSesionUsuario
    {
        public static int idUsuario { get; set; }
        public static String NombreUsuario { get; set; } = string.Empty;
        public static string NombreCompleto { get; set; } = string.Empty;
        public static RolUsuario Rol { get; set; } = RolUsuario.Nadie;

        public static void Invitado()
        {
            idUsuario = 0;
            NombreUsuario = "Invitado";
            NombreCompleto = "Invitado";
            Rol = RolUsuario.Invitado;
        }

        public static void IniciarSesion(int id, string nombre, string nombreCompleto, string rolstring)
        {
            idUsuario = id;
            NombreUsuario = nombre;
            NombreCompleto = nombreCompleto;

            if (Enum.TryParse(rolstring, true, out RolUsuario rol))
                Rol = rol;
            else
                Rol = RolUsuario.Nadie;
        }

        public static void Cerrarsesion()
        {
            idUsuario = 0;
            NombreUsuario = string.Empty;
            NombreCompleto = string.Empty;
            Rol = RolUsuario.Nadie;
        }
    };

    
}
