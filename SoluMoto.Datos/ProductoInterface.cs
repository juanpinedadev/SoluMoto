using SoluMoto.Entidad;
using System.Collections.Generic;

namespace SoluMoto.Datos
{
    /// <summary>
    /// Interfaz que define los métodos para la gestión de productos.
    /// </summary>
    public interface ProductoInterface
    {
        /// <summary>
        /// Crea un nuevo producto.
        /// </summary>
        /// <param name="producto">Producto a crear.</param>
        /// <returns>Verdadero si la creación se realizó con éxito, falso en caso contrario.</returns>
        bool Crear(Producto producto);

        /// <summary>
        /// Actualiza un producto existente.
        /// </summary>
        /// <param name="producto">Producto a actualizar.</param>
        /// <returns>Verdadero si la actualización se realizó con éxito, falso en caso contrario.</returns>
        bool Actualizar(Producto producto);

        /// <summary>
        /// Elimina un producto existente.
        /// </summary>
        /// <param name="producto">Producto a eliminar.</param>
        /// <returns>Verdadero si la eliminación se realizó con éxito, falso en caso contrario.</returns>
        bool Eliminar(Producto producto);

        /// <summary>
        /// Obtiene una lista de todos los productos.
        /// </summary>
        /// <returns>Lista de productos.</returns>
        List<Producto> Listar();
    }

}
