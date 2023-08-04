using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class MesasCn
    {
        ConexionBD conexion = new ConexionBD();

        #region Mesas
        public DataTable MostrandoMesas()
        {
            return conexion.ConsultandoMesas();
        }

        public string AgregandoMesas(int numeroMesa, bool estado)
        {
            return conexion.AgregarMesas(numeroMesa, estado);
        }

        public string ActualizandoMesas(int id, int numeroMesa, bool estado)
        {
            return conexion.ActualizarMesas(id, numeroMesa, estado);
        }
        #endregion

    }
}
