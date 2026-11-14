
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Clases.Clases
{
    public class ClaseInventario
    {
        // Mostrar materias primas
        public DataTable ObtenerMateriales()
        {
            DataTable tabla = new DataTable();
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    SELECT idMaterial AS [ID],
                           tipoCategoria AS [Categoría],
                           nombreMaterial AS [Material],
                           unidadMedida AS [Unidad],
                           costoUnidad AS [Costo],
                           CASE WHEN estado = 1
                                THEN 'Activo'
                                ELSE 'Inactivo'
                           END AS [Estado]
                    FROM Inventario_Materiales
                    ORDER BY idMaterial";

                using (SqlDataAdapter adaptador =
                    new SqlDataAdapter(sql, con))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        // Registrar materia prima
        public void RegistrarMaterial(
            string categoria,
            string nombre,
            string unidad,
            decimal costo)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    INSERT INTO Inventario_Materiales
                    (tipoCategoria, nombreMaterial,
                     unidadMedida, costoUnidad, estado)
                    VALUES
                    (@categoria, @nombre, @unidad, @costo, 1)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@categoria",
                        SqlDbType.VarChar, 50).Value = categoria;

                    cmd.Parameters.Add("@nombre",
                        SqlDbType.VarChar, 100).Value = nombre;

                    cmd.Parameters.Add("@unidad",
                        SqlDbType.VarChar, 20).Value = unidad;

                    cmd.Parameters.Add("@costo",
                        SqlDbType.Decimal).Value = costo;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar materia prima
        public void ActualizarMaterial(
            int id,
            string categoria,
            string nombre,
            string unidad,
            decimal costo)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    UPDATE Inventario_Materiales
                    SET tipoCategoria = @categoria,
                        nombreMaterial = @nombre,
                        unidadMedida = @unidad,
                        costoUnidad = @costo
                    WHERE idMaterial = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@unidad", unidad);
                    cmd.Parameters.AddWithValue("@costo", costo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Buscar materias primas
        public DataTable BuscarMateriales(string buscar)
        {
            DataTable tabla = new DataTable();
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    SELECT idMaterial AS [ID],
                           tipoCategoria AS [Categoría],
                           nombreMaterial AS [Material],
                           unidadMedida AS [Unidad],
                           costoUnidad AS [Costo],
                           CASE WHEN estado = 1
                                THEN 'Activo'
                                ELSE 'Inactivo'
                           END AS [Estado]
                    FROM Inventario_Materiales
                    WHERE nombreMaterial LIKE @buscar
                       OR tipoCategoria LIKE @buscar
                    ORDER BY idMaterial";

                using (SqlDataAdapter adaptador =
                    new SqlDataAdapter(sql, con))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue(
                        "@buscar", "%" + buscar + "%");

                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        // Activar o desactivar materia prima
        public void CambiarEstado(int id, bool activo)
        {
            ClaseConexion conexion = new ClaseConexion();

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                string sql = @"
                    UPDATE Inventario_Materiales
                    SET estado = @estado
                    WHERE idMaterial = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@estado", activo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
