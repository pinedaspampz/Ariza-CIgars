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
        public void ActualizarUsuario(
    int idUsuario,
    string nombreCompleto,
    string nombreUsuario,
    string contrasena,
    int idRol)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
            UPDATE Usuarios
            SET nombreCompleto = @nombreCompleto,
                nombreUsuario = @nombreUsuario,
                idRol = @idRol,
                contrasena = CASE
                    WHEN @contrasena = '' THEN contrasena
                    ELSE @contrasena
                END
            WHERE idUsuario = @idUsuario;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@idRol", idRol);

                    con.Open();

                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        throw new InvalidOperationException(
                            "El usuario ya no existe. Actualiza la lista.");
                    }
                }
            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Usuarios WHERE idUsuario = @idUsuario;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    con.Open();

                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        throw new InvalidOperationException(
                            "El usuario ya no existe. Actualiza la lista.");
                    }
                }
            }
        }
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
        public bool ExisteUsuario(string nombreUsuario)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"SELECT COUNT(*)
                       FROM Usuarios
                       WHERE nombreUsuario = @usuario";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    con.Open();

                    int cantidad = (int)cmd.ExecuteScalar();
                    return cantidad > 0;
                }
            }
        }

        public void RegistrarUsuario(
            string nombreCompleto,
            string nombreUsuario,
            string contrasena,
            int idRol)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"INSERT INTO Usuarios
                       (nombreCompleto, nombreUsuario, contrasena, idRol, estado)
                       VALUES
                       (@nombreCompleto, @nombreUsuario, @contrasena, @idRol, 1)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@idRol", idRol);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
