using System.Collections.Generic;

namespace SoluMoto.Datos
{
    public interface ClienteInterface
    {
        bool Crear(ClienteInterface cliente);
        bool Actualizar(ClienteInterface cliente);
        bool Eliminar(ClienteInterface cliente);
        List<ClienteInterface> Listar();
    }
}
