using System;

namespace ClubDeportivo.Entidades
{
    public interface IComprobante
    {
        // Se declara el método sin llaves y sin la palabra public
        string GenerarComprobante();
    }
}