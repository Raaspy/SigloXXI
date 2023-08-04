using System;

namespace CapaEntidades
{
    public class HistorialCambios
    {
        int idHistorial;
        string nombreInsumoHistorial;
        DateTime fechaHistorial;
        int cantidadInicialHistorial;
        int cantidadFinalHistorial;
        string responsable;

        public int IdHistorial { get => idHistorial; set => idHistorial = value; }
        public string NombreInsumoHistorial { get => nombreInsumoHistorial; set => nombreInsumoHistorial = value; }
        public DateTime FechaHistorial { get => fechaHistorial; set => fechaHistorial = value; }
        public int CantidadInicialHistorial { get => cantidadInicialHistorial; set => cantidadInicialHistorial = value; }
        public int CantidadFinalHistorial { get => cantidadFinalHistorial; set => cantidadFinalHistorial = value; }
        public string Responsable { get => responsable; set => responsable = value; }
    }
}
