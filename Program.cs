using PrimeraEntrega.Handlers;
using PrimeraEntrega.Models;

namespace PrimeraEntrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*********** Escribir una funcion que me permita obtener todos los productos de la base
            List<Producto> productos = ProductoHandler.ObtenerProductos();


            //********* Escribir una funcion que me permita obtener un producto dado las descripciones
            //Producto producto = ProductoHandler.ObtenerProducto("Medias");



            //******* Escribir una funcion que me permita crear un producto
            //Producto productoAInsertar = new Producto();
            //productoAInsertar.Descripciones = "Pantalon Jean Negro";
            //productoAInsertar.Costo = 9000;
            //productoAInsertar.PrecioVenta = 12000;
            //productoAInsertar.Stock = 99;
            //productoAInsertar.IdUsuario = 2;

            //if (ProductoHandler.InsertarProducto(productoAInsertar) >= 1)
            //{
            //    Console.WriteLine("Producto Insertado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo insertar el producto");
            //}



        }
    }
}