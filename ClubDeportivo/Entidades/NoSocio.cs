using System;

namespace ClubDeportivo.Entidades
{
    public class NoSocio : Persona
    {
        public int NroVisita { get; set; }
        public string ActividadAsignada { get; set; }
        public override string MostrarDetalle()
        {
            return $"Visitante - Actividad: {ActividadAsignada}";
        }
    }
}