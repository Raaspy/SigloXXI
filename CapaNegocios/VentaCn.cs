using CapaDatos;
using System;

namespace CapaNegocios
{
    public class VentaCn
    {
        ConexionBD conexion = new ConexionBD();
        public string AgregandoVenta(string claveTransaccion, DateTime fechaVenta, int totalVenta, string estadoVenta, string tipoPago)
        {
            return conexion.AgregarVenta(claveTransaccion, fechaVenta, totalVenta, estadoVenta, tipoPago);
        }

        public string EliminandoVentaPanel()
        {
            return conexion.EliminarVentaPanel();
        }

        public string ConsultandoTotalVenta()
        {
            return conexion.ConsultarTotalVenta();
        }
    }
}
