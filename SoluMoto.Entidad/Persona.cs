namespace SoluMoto.Entidad
{
    public class Persona
    {
        public Persona()
        {
        }

        public Persona(int idPersona, string nombreCompleto, string correo)
        {
            IdPersona = idPersona;
            NombreCompleto = nombreCompleto;
            Correo = correo;
        }

        public int IdPersona { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }

        public override string ToString()
        {
            return $"ID: {IdPersona}" +
                $"\nNombre: {NombreCompleto}" +
                $"\nCorreo: {Correo}";
        }
    }
}
