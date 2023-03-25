using SoluMoto.Entidad;
using System;
using System.Collections.Generic;

namespace SoluMoto.Datos
{
    public class ProductoDatos : ProductoInterface
    {
        private List<Producto> productos = new List<Producto>();

        public bool Actualizar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Producto producto)
        {
            //Si el usuario pasado por parametro es nulo o vacío, retorna falso
            if(producto == null) { return false; }
            
            //Si todo está bien, entonces agrega el producto a la lista de productos
            productos.Add(producto);

            //Y retorna un true
            return true;
        }

        public bool Eliminar(Producto producto)
        {
            //Si el usuario pasado por parametro es nulo o vacío, retorna falso
            if (producto == null) { return false; }

            //Recorremos la lista de usuarios
            foreach (var item in productos)
            {
                //Si el id del producto que queremos eliminar, es igual a uno de los productos dentro de la lista, entonces lo elimina.
                if(item.IdProducto == producto.IdProducto)
                {
                    //Elimina el producto
                    productos.Remove(producto);
                }
            }

            //Y retorna un true, SI TODO SALE BIEN
            return true;
        }

        public List<Producto> Listar()
        {
            //Retorna la lista de productos
            return productos;
        }
    }
}
