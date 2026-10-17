using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Clases.Clases
{
    public class ClaseClientes
    {
        public DataTable ObtenerClientes()
        {
            DataTable tabla = new DataTable();
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    SELECT
                        idCliente AS [ID],
                        nombreCompleto AS [Nombre completo],
                        telefono AS [Teléfono],
                        correo AS [Correo],
                        CASE
                            WHEN estado = 1 THEN 'Activo'
                            ELSE 'Inactivo'
                        END AS [Estado]
                    FROM Clientes
                    ORDER BY idCliente";

                using (SqlDataAdapter adaptador =
                    new SqlDataAdapter(sql, con))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public void RegistrarCliente(
            string nombreCompleto,
            string telefono,
            string correo)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    INSERT INTO Clientes
                        (nombreCompleto, telefono, correo)
                    VALUES
                        (@nombre, @telefono, @correo)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(
                        "@nombre", SqlDbType.VarChar, 150
                    ).Value = nombreCompleto;

                    cmd.Parameters.Add(
                        "@telefono", SqlDbType.VarChar, 20
                    ).Value = string.IsNullOrWhiteSpace(telefono)
                        ? (object)DBNull.Value : telefono;

                    cmd.Parameters.Add(
                        "@correo", SqlDbType.VarChar, 100
                    ).Value = string.IsNullOrWhiteSpace(correo)
                        ? (object)DBNull.Value : correo;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
        }
        public void ActualizarCliente(
    int idCliente,
    string nombreCompleto,
    string telefono,
    string correo)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
            UPDATE Clientes
            SET nombreCompleto = @nombre,
                telefono = @telefono,
                correo = @correo
            WHERE idCliente = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 150)
                        .Value = nombreCompleto;

                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 20)
                        .Value = string.IsNullOrWhiteSpace(telefono)
                            ? (object)DBNull.Value : telefono;

                    cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100)
                        .Value = string.IsNullOrWhiteSpace(correo)
                            ? (object)DBNull.Value : correo;

                    cmd.Parameters.Add("@id", SqlDbType.Int)
                        .Value = idCliente;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarClientes(string buscar)
        {
            DataTable tabla = new DataTable();
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
            SELECT
                idCliente AS [ID],
                nombreCompleto AS [Nombre completo],
                telefono AS [Teléfono],
                correo AS [Correo],
                CASE
                    WHEN estado = 1 THEN 'Activo'
                    ELSE 'Inactivo'
                END AS [Estado]
            FROM Clientes
            WHERE nombreCompleto LIKE @buscar
               OR telefono LIKE @buscar
               OR correo LIKE @buscar
            ORDER BY idCliente";

                using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, con))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@buscar", "%" + buscar + "%");

                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public void EliminarCliente(int idCliente)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = "DELETE FROM Clientes WHERE idCliente = @idCliente";

                using (SqlCommand comando = new SqlCommand(sql, con))
                {
                    comando.Parameters.AddWithValue("@idCliente", idCliente);

                    con.Open();

                    int filas = comando.ExecuteNonQuery();

                    if (filas == 0)
                    {
                        throw new Exception("No se encontró el cliente seleccionado.");
                    }
                }
            }
        }
    }

}



