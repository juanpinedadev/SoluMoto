using System;

namespace SoluMoto.Entidad
{
    public class Usuario : Persona
    {
        public Usuario()
        {
        }

        public Usuario(int idUsuario, Rol rol, string nombreUsuario, string contraseña, bool estado)
        {
            IdUsuario = idUsuario;
            this.rol = rol;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            Estado = estado;
        }

        public int IdUsuario { get; set; }
        public Rol rol { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            //Aquí retornas el ToString() de Persona + los atributos de esta clase.
            return base.ToString() +
                $"{IdUsuario}\n{rol.Nombre}";
        }
    }
}
