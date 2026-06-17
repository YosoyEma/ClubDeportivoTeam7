using System;

namespace ClubDeportivo.Entidades
{
    public class Socio : Persona
    {
        public int NroSocio { get; set; }
        public bool CarnetEntregado { get; set; }
        public bool EstadoActivo { get; set; }
        public override string MostrarDetalle()
        {
            return $"Socio Nro: {NroSocio} - Activo: {EstadoActivo}";
        }
    }
}