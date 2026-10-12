using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Clases.Clases
{
    public class ClaseConexion
    {
        private readonly string cadenaConexion =
        "Server=localhost;Database=ArizaCigars;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public bool ValidarLogin(string usuario, string clave,
                                 out int id, out string nombreCompleto, out string rol)
        {
            id = 0;
            nombreCompleto = string.Empty;
            rol = string.Empty;

            using (SqlConnection con = ObtenerConexion())
            {
                string consulta = @"select u.idUsuario, u.nombreCompleto, r.rol
                               from Usuarios u
                               inner join  Roles r ON u.idRol = r.idRol
                               where u.nombreUsuario = @usuario
                                 and u.contrasena = @clave
                                 and u.estado = 1";

                using (SqlCommand command = new SqlCommand(consulta, con))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@clave", clave);
                    con.Open();

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            id = dr.GetInt32(0);
                            nombreCompleto = dr.GetString(1);
                            rol = dr.GetString(2).Trim(); 
                            return true;
                        }
                    }
                }
            }

            return false; 
        }
    }
}
