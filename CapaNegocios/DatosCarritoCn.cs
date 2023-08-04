using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class DatosCarritoCn
    {
        ConexionBD conexion = new ConexionBD();
        public DataTable MostrandoPedidosCocina()
        {
            return conexion.ConsultandoPedidosCocina();
        }

        public DataTable MostrandoPedidosGarzon()
        {
            return conexion.ConsultandoPedidosGarzon();
        }

        public string ActualizandoPanelCocina(string numeroMesa, bool estadoCocina, string nombreProducto)
        {
            return conexion.ActualizarEstadoCocina(numeroMesa, estadoCocina, nombreProducto);
        }

        public string ActualizandoPanelGarzon(string numeroMesa, bool estadoCocina, string nombreProducto)
        {
            return conexion.ActualizarEstadoGarzon(numeroMesa, estadoCocina, nombreProducto);
        }
    }
}
