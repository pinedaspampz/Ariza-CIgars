using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases.Clases;

namespace Clases.Clases

{
  
    public enum RolUsuario
    {
        Nadie, 
        Invitado,
        Consultor,
        Gestor,
        Administrador
    }

    public static class RolUsuarioHelper
    {
        public static bool EsAdministrador()
        {
            return ClaseSesionUsuario.Rol == RolUsuario.Administrador;
        }
    }
}
