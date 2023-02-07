using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraEntrega.Models;

namespace PrimeraEntrega.Handlers
{
    internal static class UsuarioHandler
    {
        public static string cadenaConexion = "Data Source=DESKTOP-LB8I6K6;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Usuario> ObtenerUsuario()
        {
            List<Usuario> usuario = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            { 
                SqlCommand comando = new SqlCommand($"SELECT * FROM Usuario WHERE Id='{2}' ", conn);
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Usuario WHERE Id=@id", conn);

                comando2.Parameters.AddWithValue("@id", 2);
                conn.Open();

                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario usuarioTemporal = new Usuario();
                        usuarioTemporal.Id = reader.GetInt64(0);
                        usuarioTemporal.Nombre = reader.GetString(1);
                        usuarioTemporal.Apellido = reader.GetString(2);
                        usuarioTemporal.NombreUsuario = reader.GetString(3);
                        usuarioTemporal.Contraseña = reader.GetString(4);
                        usuarioTemporal.Mail = reader.GetString(5);

                        usuario.Add(usuarioTemporal);
                    }
                }
                return usuario;
            }
        }

        public static List<Usuario> InicioDeSesion()
        {
            List<Usuario> usuario = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Usuario WHERE NombreUsuario=@nombreUsuario AND Contraseña=@contraseña", conn);

                comando2.Parameters.AddWithValue("@nombreUsuario", $"Aciano");
                comando2.Parameters.AddWithValue("@contraseña", $"SoyAciano");
                conn.Open();

                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario usuarioTemporal = new Usuario();
                        usuarioTemporal.Id = reader.GetInt64(0);
                        usuarioTemporal.Nombre = reader.GetString(1);
                        usuarioTemporal.Apellido = reader.GetString(2);
                        usuarioTemporal.NombreUsuario = reader.GetString(3);
                        usuarioTemporal.Contraseña = reader.GetString(4);
                        usuarioTemporal.Mail = reader.GetString(5);

                        usuario.Add(usuarioTemporal);
                    }
                }
                return usuario;
            }
        }
    }
}


