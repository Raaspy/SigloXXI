using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class HistorialCambiosCn
    {
        ConexionBD conexion = new ConexionBD();

        public string AgregandoHistorial(int id, string nombreInsumo, string cantidadDisponible, DateTime fechaCambio, string cantidadInicialCambio, string responsableCambio)
        {
            return conexion.AgregarHistorial(id, nombreInsumo, cantidadDisponible, fechaCambio, cantidadInicialCambio, responsableCambio);
        }

        public DataTable MostrandoHistorialInsumos()
        {
            return conexion.ConsultandoHistorialInsumos();
        }
    }
}
