using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Clases.Clases
{
    public class ClaseClientes
    {
        
        private SqlConnection CrearConexion()
        {
            return new SqlConnection(
                "Server=localhost;Database=MiBaseDeDatos;Integrated Security=True;TrustServerCertificate=True;");
        }
       
        public int RegistrarCliente(string nombre, string telefono, string correo)
        {
            ValidarDuplicado(0, telefono, correo);

            const string sql =
                @"INSERT INTO Clientes (nombreCompleto, telefono, correo, estado)
                  VALUES (@Nombre, @Telefono, @Correo, 1);
                  SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre.Trim());
                    comando.Parameters.AddWithValue("@Telefono", ValorONulo(telefono));
                    comando.Parameters.AddWithValue("@Correo", ValorONulo(correo));

                    conexion.Open();
                    object? resultado = comando.ExecuteScalar();

                    return (resultado == null || resultado == DBNull.Value)
                        ? 0
                        : Convert.ToInt32(resultado);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos al registrar el cliente: " + ex.Message, ex);
            }
        }

        public DataTable ObtenerClientes()
        {
            const string sql =
                @"SELECT idCliente      AS [ID],
                         nombreCompleto AS [Nombre completo],
                         telefono       AS [Teléfono],
                         correo         AS [Correo]
                  FROM Clientes
                  WHERE estado = 1
                  ORDER BY nombreCompleto";

            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos al obtener los clientes: " + ex.Message, ex);
            }
        }

        public DataTable BuscarClientes(string texto)
        {
            const string sql =
                @"SELECT idCliente      AS [ID],
                         nombreCompleto AS [Nombre completo],
                         telefono       AS [Teléfono],
                         correo         AS [Correo]
                  FROM Clientes
                  WHERE estado = 1
                    AND (nombreCompleto LIKE @Texto
                         OR telefono LIKE @Texto
                         OR correo LIKE @Texto)
                  ORDER BY nombreCompleto";

            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Texto", "%" + texto + "%");

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos al buscar clientes: " + ex.Message, ex);
            }
        }

        public bool ActualizarCliente(int id, string nombre, string telefono, string correo)
        {
            ValidarDuplicado(id, telefono, correo);

            const string sql =
                @"UPDATE Clientes
                  SET nombreCompleto = @Nombre,
                      telefono       = @Telefono,
                      correo         = @Correo
                  WHERE idCliente = @Id AND estado = 1";

            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Nombre", nombre.Trim());
                    comando.Parameters.AddWithValue("@Telefono", ValorONulo(telefono));
                    comando.Parameters.AddWithValue("@Correo", ValorONulo(correo));

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos al actualizar el cliente: " + ex.Message, ex);
            }
        }

        
        public bool EliminarCliente(int id)
        {
            const string sql = "UPDATE Clientes SET estado = 0 WHERE idCliente = @Id AND estado = 1";

            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos al eliminar el cliente: " + ex.Message, ex);
            }
        }

       
        private void ValidarDuplicado(int id, string telefono, string correo)
        {
            const string sql =
                @"SELECT COUNT(*) FROM Clientes
                  WHERE estado = 1 AND idCliente <> @Id
                    AND ((@Telefono IS NOT NULL AND telefono = @Telefono)
                      OR (@Correo IS NOT NULL AND correo = @Correo))";

            try
            {
                using (SqlConnection conexion = CrearConexion())
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.Parameters.AddWithValue("@Telefono", ValorONulo(telefono));
                    comando.Parameters.AddWithValue("@Correo", ValorONulo(correo));

                    conexion.Open();
                    if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                        throw new InvalidOperationException(
                            "Ya existe un cliente con ese teléfono o correo.");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos al validar duplicados: " + ex.Message, ex);
            }
        }

        private static object ValorONulo(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? (object)DBNull.Value : valor.Trim();
        }
    }
}