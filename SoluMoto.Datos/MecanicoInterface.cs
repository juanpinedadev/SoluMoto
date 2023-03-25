using System.Collections.Generic;

namespace SoluMoto.Datos
{
    public interface MecanicoInterface
    {
        bool Crear(MecanicoInterface mecanico);
        bool Actualizar(MecanicoInterface mecanico);
        bool Eliminar(MecanicoInterface mecanico);
        List<MecanicoInterface> Listar();
    }
}
