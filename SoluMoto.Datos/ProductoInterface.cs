using SoluMoto.Entidad;
using System.Collections.Generic;

namespace SoluMoto.Datos
{
    public interface ProductoInterface
    {
        bool Crear(Producto producto);
        bool Actualizar(Producto producto);
        bool Eliminar(Producto producto);
        List<Producto> Listar();
    }
}
