
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Clases.Clases
{
    public class ClaseRecetas
    {
        private readonly ClaseConexion conexion = new ClaseConexion();

       
        public DataTable ObtenerRecetas()
        {
            string sql = @"
                SELECT
                    r.idReceta AS [ID],
                    p.nombreProducto AS [Producto],
                    m.nombreMaterial AS [Material],
                    r.cantidadRequerida AS [Cantidad requerida],
                    r.costoUnidad AS [Costo unidad]
                FROM Receta r
                INNER JOIN Productos p ON r.idProducto = p.idProducto
                INNER JOIN Inventario_Materiales m ON r.idMaterial = m.idMaterial
                ORDER BY r.idReceta DESC";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

       
        public DataTable BuscarRecetas(string texto)
        {
            string sql = @"
                SELECT
                    r.idReceta AS [ID],
                    p.nombreProducto AS [Producto],
                    m.nombreMaterial AS [Material],
                    r.cantidadRequerida AS [Cantidad requerida],
                    r.costoUnidad AS [Costo unidad]
                FROM Receta r
                INNER JOIN Productos p ON r.idProducto = p.idProducto
                INNER JOIN Inventario_Materiales m ON r.idMaterial = m.idMaterial
                WHERE p.nombreProducto LIKE @Texto
                   OR m.nombreMaterial LIKE @Texto
                ORDER BY r.idReceta DESC";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Texto", "%" + texto.Trim() + "%");

                using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                {
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
            }
        }

        
        public int RegistrarReceta(
            int idProducto,
            int idMaterial,
            decimal cantidadRequerida,
            decimal? costoUnidad)
        {
            string sql = @"
                INSERT INTO Receta
                (idProducto, idMaterial, cantidadRequerida, costoUnidad)
                VALUES
                (@Producto, @Material, @Cantidad, @Costo);

                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Producto", idProducto);
                cmd.Parameters.AddWithValue("@Material", idMaterial);

                SqlParameter cantidad = cmd.Parameters.Add(
                    "@Cantidad", SqlDbType.Decimal);
                cantidad.Precision = 18;
                cantidad.Scale = 4;
                cantidad.Value = cantidadRequerida;

                SqlParameter costo = cmd.Parameters.Add(
                    "@Costo", SqlDbType.Decimal);
                costo.Precision = 18;
                costo.Scale = 2;
                costo.Value = costoUnidad.HasValue
                    ? (object)costoUnidad.Value
                    : DBNull.Value;

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

       
        public bool ActualizarReceta(
            int idReceta,
            int idProducto,
            int idMaterial,
            decimal cantidadRequerida,
            decimal? costoUnidad)
        {
            string sql = @"
                UPDATE Receta
                SET idProducto = @Producto,
                    idMaterial = @Material,
                    cantidadRequerida = @Cantidad,
                    costoUnidad = @Costo
                WHERE idReceta = @Id";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", idReceta);
                cmd.Parameters.AddWithValue("@Producto", idProducto);
                cmd.Parameters.AddWithValue("@Material", idMaterial);

                SqlParameter cantidad = cmd.Parameters.Add(
                    "@Cantidad", SqlDbType.Decimal);
                cantidad.Precision = 18;
                cantidad.Scale = 4;
                cantidad.Value = cantidadRequerida;

                SqlParameter costo = cmd.Parameters.Add(
                    "@Costo", SqlDbType.Decimal);
                costo.Precision = 18;
                costo.Scale = 2;
                costo.Value = costoUnidad.HasValue
                    ? (object)costoUnidad.Value
                    : DBNull.Value;

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public bool EliminarReceta(int idReceta)
        {
            string sql = "DELETE FROM Receta WHERE idReceta = @Id";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@Id", idReceta);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

       
        public DataTable ObtenerProductos()
        {
            string sql = @"
                SELECT idProducto, nombreProducto
                FROM Productos
                WHERE estado = 1
                ORDER BY nombreProducto";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlDataAdapter adaptador =
                   new SqlDataAdapter(sql, con))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public DataTable ObtenerMateriales()
        {
            string sql = @"
                SELECT idMaterial, nombreMaterial, unidadMedida, costoUnidad
                FROM Inventario_Materiales
                WHERE estado = 1
                ORDER BY nombreMaterial";

            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlDataAdapter adaptador =
                   new SqlDataAdapter(sql, con))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }
    }
}

