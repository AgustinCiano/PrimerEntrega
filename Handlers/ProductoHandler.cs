using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraEntrega.Models;

namespace PrimeraEntrega.Handlers
{
    internal static class ProductoHandler
    {
        public static string cadenaConexion = "Data Source=DESKTOP-LB8I6K6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public static List<Producto> ObtenerProductosIdUsuario()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Producto WHERE IdUsuario=@idUsuario", conn);
                comando2.Parameters.AddWithValue("@idUsuario", 2);

                conn.Open();

                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTemporal = new Producto();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Descripciones = reader.GetString(1);
                        productoTemporal.Costo = reader.GetDecimal(2);
                        productoTemporal.PrecioVenta = reader.GetDecimal(3);
                        productoTemporal.Stock = reader.GetInt32(4);
                        productoTemporal.IdUsuario = reader.GetInt64(5);

                        productos.Add(productoTemporal);
                    }
                }
                return productos;


            }

        }

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Producto", conn);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTemporal = new Producto();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Descripciones = reader.GetString(1);
                        productoTemporal.Costo = reader.GetDecimal(2);
                        productoTemporal.PrecioVenta = reader.GetDecimal(3);
                        productoTemporal.Stock = reader.GetInt32(4);
                        productoTemporal.IdUsuario = reader.GetInt64(5);

                        productos.Add(productoTemporal);
                    }
                }
                return productos;


            }

        }



        public static Producto ObtenerProducto(string descripciones)
        {
            Producto producto = new Producto();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {

                SqlCommand comando = new SqlCommand($"SELECT * FROM Producto WHERE Descripciones='{descripciones}' ", conn);
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Producto WHERE Descripciones=@descripciones", conn);

                comando2.Parameters.AddWithValue("@descripciones", descripciones);

                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    producto.Id = reader.GetInt64(0);
                    producto.Descripciones = reader.GetString(1);
                    producto.Costo = reader.GetDecimal(2);
                    producto.PrecioVenta = reader.GetDecimal(3);
                    producto.Stock = reader.GetInt32(4);
                    producto.IdUsuario = reader.GetInt64(5);

                }
                return producto;
            }
            
        }

        public static int InsertarProducto(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("INSERT INTO Producto(Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                    "VALUES(@descripciones, @costo, @precioVenta, @stock, @idUsuario)", conn);

                comando.Parameters.AddWithValue("@descripciones", producto.Descripciones);
                comando.Parameters.AddWithValue("@costo", producto.Costo);
                comando.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
                comando.Parameters.AddWithValue("@stock", producto.Stock);
                comando.Parameters.AddWithValue("@idUsuario", producto.IdUsuario);

                conn.Open();
                return comando.ExecuteNonQuery();
            }
        }


    }
}
