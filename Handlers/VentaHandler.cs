using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraEntrega.Models;

namespace PrimeraEntrega.Handlers
{
    internal class VentaHandler
    {
        public static string cadenaConexion = "Data Source=DESKTOP-LB8I6K6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Venta> ObtenerVentaIdUsuario()
        {
            List<Venta> productos = new List<Venta>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Venta WHERE IdUsuario=@idUsuario", conn);
                comando2.Parameters.AddWithValue("@idUsuario", 1);

                conn.Open();

                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta productoTemporal = new Venta();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Comentarios = reader.GetString(1);
                        productoTemporal.IdUsuario = reader.GetInt64(2);

                        productos.Add(productoTemporal);
                    }
                }
                return productos;
            }
        }
    }
}