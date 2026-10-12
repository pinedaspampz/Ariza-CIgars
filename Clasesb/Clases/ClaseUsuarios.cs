using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Clases

{
    public class ClaseUsuarios
    {
        public DataTable ObtenerUsuarios()
        {
            DataTable tabla = new DataTable();
            ClaseConexion conexion = new ClaseConexion();   


            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"select u.idUsuario as [ID],
                            u.nombreCompleto as [Nombre completo],
                            u.nombreUsuario  as [Usuario],
                            r.rol  AS [Rol],
                            case when u.estado = 1 then 'Activo'
                            else 'Inactivo'
                            end as [Estado]
                            from Usuarios u
                            inner join Roles r ON u.idRol = r.idRol
                            order by u.idUsuario";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, con))
                {
                    adaptador.Fill(tabla);   
                }
            }

            return tabla;
        }
    public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = "SELECT idRol, rol FROM Roles ORDER BY rol";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    con.Open();

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            roles.Add(new Rol
                            {
                                IdRol = dr.GetInt32(0),
                                Nombre = dr.GetString(1).Trim()
                            });
                        }
                    }
                }
            }

            return roles;
        }
    }
}
