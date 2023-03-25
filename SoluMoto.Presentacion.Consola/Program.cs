using SoluMoto.Entidad;
using System;

namespace SoluMoto.Presentacion.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Creación de categoria
            //Categoria
            CategoriaProducto CategoriaNeumatico = new CategoriaProducto();
            CategoriaNeumatico.IdCategoriaProducto = 0001;
            CategoriaNeumatico.Nombre = "Yamaha x3435 tc";
            CategoriaNeumatico.Estado = true;
            CategoriaNeumatico.FechaRegistro = DateTime.Now;
            #endregion

            #region Creación de producto
            //Prodcto
            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Estado = true;
            producto.PrecioCompra = 50000;
            producto.PrecioVenta = 55000;
            producto.FechaRegistro = DateTime.Now;

            //Directa
            producto.IdCategoriaProducto = 0001;

            //Referencia
            producto.CategoriaProducto = CategoriaNeumatico; //Se le asigna un objeto
            #endregion

            #region Test
            
            Console.WriteLine(producto.CategoriaProducto.Nombre.ToString());
            Console.ReadKey();
            #endregion
        }
    }
}
