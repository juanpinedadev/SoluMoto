using System;

namespace SoluMoto.Entidad
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public Mecanico Mecanico { get; set; }
        public Cliente Cliente { get; set; } 
        public string Descripcion { get; set; }
        public decimal PrecioServicio { get; set; }
        public int HoraEstipulada { get; set; }

    }
}
