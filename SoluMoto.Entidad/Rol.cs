namespace SoluMoto.Entidad
{
    public class Rol
    {
        public Rol()
        {
        }

        public Rol(int idRol, string nombre, bool estado)
        {
            IdRol = idRol;
            Nombre = nombre;
            Estado = estado;
        }

        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return $"Id: {IdRol}" +
                $"\nNombre: {Nombre}" +
                $"\nEstado: {Estado}";
        }
    }
}
