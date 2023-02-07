using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraEntrega.Models;

namespace PrimeraEntrega.Handlers
{
    internal class ProductoVendidoHandler
    {
        public static string cadenaConexion = "Data Source=DESKTOP-LB8I6K6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<ProductoVendido> ObtenerProductosVendidosIdVenta()
        {
            List<ProductoVendido> productos = new List<ProductoVendido>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando2 = new SqlCommand("SELECT * FROM ProductoVendido WHERE IdVenta=@idVenta", conn);
                comando2.Parameters.AddWithValue("@idVenta", 1);

                conn.Open();

                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductoVendido productoTemporal = new ProductoVendido();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Stock = reader.GetInt32(1);
                        productoTemporal.IdProducto = reader.GetInt64(2);
                        productoTemporal.IdVenta = reader.GetInt64(3);
                        

                        productos.Add(productoTemporal);
                    }
                }
                return productos;


            }

        }
    }
}
