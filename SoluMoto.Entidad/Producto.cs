using System;

namespace SoluMoto.Entidad
{
    public class Producto
    {
        public int IdProducto { get; set; } 
        public int IdCategoriaProducto { get; set; } //Atributo local
        public CategoriaProducto CategoriaProducto { get; set; } //Atributo por referencia
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public bool Estado { get; set; } = true;
        public DateTime FechaRegistro { get; set; }
    }
}
