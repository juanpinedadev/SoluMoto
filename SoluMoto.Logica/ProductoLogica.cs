using SoluMoto.Datos;
using SoluMoto.Entidad;
using System.Collections.Generic;

namespace SoluMoto.Logica
{
    /// <summary>
    /// Clase que representa la lógica de negocio para la gestión de productos.
    /// </summary>
    public class ProductoLogica
    {
        private ProductoDatos productoDatos = new ProductoDatos();

        /// <summary>
        /// Actualiza un producto existente en la base de datos.
        /// </summary>
        /// <param name="producto">Producto a actualizar.</param>
        /// <returns>Verdadero si la actualización se realizó con éxito, falso en caso contrario.</returns>
        public bool Actualizar(Producto producto)
        {
            return productoDatos.Actualizar(producto);
        }

        /// <summary>
        /// Crea un nuevo producto en la base de datos.
        /// </summary>
        /// <param name="producto">Producto a crear.</param>
        /// <returns>Verdadero si la creación se realizó con éxito, falso en caso contrario.</returns>
        public bool Crear(Producto producto)
        {
            return productoDatos.Crear(producto);
        }

        /// <summary>
        /// Elimina un producto existente de la base de datos.
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        /// <returns>Verdadero si la eliminación se realizó con éxito, falso en caso contrario.</returns>
        public bool Eliminar(Producto producto)
        {
            return productoDatos.Eliminar(producto);
        }

        /// <summary>
        /// Obtiene una lista de todos los productos almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        public List<Producto> Listar()
        {
            return productoDatos.Listar();
        }
    }

}
