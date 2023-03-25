using SoluMoto.Entidad;
using System;
using System.Collections.Generic;

namespace SoluMoto.Datos
{
    /// <summary>
    /// Clase que implementa la interfaz ProductoInterface y gestiona la persistencia de los productos.
    /// </summary>
    public class ProductoDatos : ProductoInterface
    {
        private List<Producto> productos = new List<Producto>();

        /// <summary>
        /// Actualiza un producto existente.
        /// </summary>
        /// <param name="producto">Producto a actualizar.</param>
        /// <returns>Verdadero si la actualización se realizó con éxito, falso en caso contrario.</returns>
        public bool Actualizar(Producto producto)
        {
            //Si el producto pasado por parámetro es nulo, retorna falso
            if (producto == null) { return false; }

            //Recorre la lista de productos
            foreach (var item in productos)
            {
                //Si el id del producto coincide con uno de los productos en la lista, actualiza su información
                if (item.IdProducto == producto.IdProducto)
                {
                    item.Nombre = producto.Nombre;
                    // Aquí podrías actualizar más atributos si fuese necesario
                }
            }

            //Retorna verdadero si la actualización se realizó con éxito
            return true;
        }

        /// <summary>
        /// Crea un nuevo producto.
        /// </summary>
        /// <param name="producto">Producto a crear.</param>
        /// <returns>Verdadero si la creación se realizó con éxito, falso en caso contrario.</returns>
        public bool Crear(Producto producto)
        {
            //Si el producto pasado por parámetro es nulo, retorna falso
            if (producto == null) { return false; }

            //Agrega el nuevo producto a la lista de productos
            productos.Add(producto);

            //Retorna verdadero si la creación se realizó con éxito
            return true;
        }

        /// <summary>
        /// Elimina un producto existente.
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        /// <returns>Verdadero si la eliminación se realizó con éxito, falso en caso contrario.</returns>
        public bool Eliminar(Producto producto)
        {
            //Si el producto pasado por parámetro es nulo, retorna falso
            if (producto == null) { return false; }

            //Recorre la lista de productos
            foreach (var item in productos)
            {
                //Si el id del producto coincide con uno de los productos en la lista, lo elimina
                if (item.IdProducto == producto.IdProducto)
                {
                    productos.Remove(producto);
                    // Si no haces break, podrías eliminar más productos con el mismo Id
                    break;
                }
            }

            //Retorna verdadero si la eliminación se realizó con éxito
            return true;
        }

        /// <summary>
        /// Obtiene una lista de todos los productos.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        public List<Producto> Listar()
        {
            //Retorna la lista de productos
            return productos;
        }
    }

}
