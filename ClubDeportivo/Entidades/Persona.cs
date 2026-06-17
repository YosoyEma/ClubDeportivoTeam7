using System;

namespace ClubDeportivo.Entidades
{
    public abstract class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public abstract string MostrarDetalle();
    }
}