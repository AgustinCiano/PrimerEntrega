using System.Reflection.PortableExecutable;
using PrimeraEntrega.Handlers;
using PrimeraEntrega.Models;

namespace PrimeraEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OBTENER USUARIO


            //List<Usuario> usuario = UsuarioHandler.ObtenerUsuario();

            //foreach (Usuario item in usuario)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Nombre);
            //    Console.WriteLine(item.Apellido);
            //    Console.WriteLine(item.NombreUsuario);
            //    Console.WriteLine(item.Contraseña);
            //    Console.WriteLine(item.Mail);
            //}





            //TRAER PRODUCTOS SEGUN ID DE USUARIO


            //List<Producto> productos = ProductoHandler.ObtenerProductosIdUsuario();

            //foreach (Producto item in productos)
            //{
            //    Console.WriteLine("Id: " + item.Id);
            //    Console.WriteLine("Descripciones: " + item.Descripciones);
            //    Console.WriteLine("Costo: " + item.Costo);
            //    Console.WriteLine("Precio Venta: " + item.PrecioVenta);
            //    Console.WriteLine("Stock: " + item.Stock);
            //    Console.WriteLine("Id Usuario: " + item.IdUsuario);
            //}





            //TRAER PRODUCTOS VENDIDOS SEGUN ID DE USUARIO


            //List<ProductoVendido> productos = ProductoVendidoHandler.ObtenerProductosVendidosIdVenta();

            //foreach (ProductoVendido item in productos)
            //{
            //    Console.WriteLine("Id: " + item.Id);
            //    Console.WriteLine("Stock: " + item.Stock);
            //    Console.WriteLine("IdProducto: " + item.IdProducto);
            //    Console.WriteLine("IdVenta: " + item.IdVenta);
            //}





            // TRAER VENTAS POR ID DE USUARIO


            //List<Venta> productos = VentaHandler.ObtenerVentaIdUsuario();

            //foreach (Venta item in productos)
            //{
            //    Console.WriteLine("Id: " + item.Id);
            //    Console.WriteLine("Comentarios: " + item.Comentarios);
            //    Console.WriteLine("IdUsuario: " + item.IdUsuario);
            //}






            // INICIO DE SESION


            //List<Usuario> usuario = UsuarioHandler.InicioDeSesion();

            //foreach (Usuario item in usuario)
            //{
            //    Console.WriteLine("Id: " + item.Id);
            //    Console.WriteLine("Nombre: " + item.Nombre);
            //    Console.WriteLine("Apellido: " + item.Apellido);
            //    Console.WriteLine("Nombre de Usuario: " + item.NombreUsuario);
            //    Console.WriteLine("Mail: " + item.Mail);
            //}

        }

    }
}