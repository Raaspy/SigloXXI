using System;

namespace CapaEntidades
{
    public class Ventas
    {
        int idVenta;
        string claveTransaccion;
        DateTime fechaVenta;
        int totalVenta;
        string estadoVenta;
        string tipoPago;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string ClaveTransaccion { get => claveTransaccion; set => claveTransaccion = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public int TotalVenta { get => totalVenta; set => totalVenta = value; }
        public string EstadoVenta { get => estadoVenta; set => estadoVenta = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
    }
}
