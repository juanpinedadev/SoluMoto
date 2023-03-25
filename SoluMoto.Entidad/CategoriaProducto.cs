using System;

namespace SoluMoto.Entidad
{
    public class CategoriaProducto
    {
        public int IdCategoriaProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        public DateTime FechaRegistro { get; set; } 
    }
}
