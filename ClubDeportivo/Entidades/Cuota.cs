using System;

namespace ClubDeportivo.Entidades
{
    public class Cuota : IComprobante
    {
        public int IdCuota { get; set; }
        public string Modalidad { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Pagada { get; set; }

        public string GenerarComprobante()
        {
            return $"Comprobante de Pago - Cuota Nro: {IdCuota} | Modalidad: {Modalidad} | Total: ${Monto}";
        }
    }
}