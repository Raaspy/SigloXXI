using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class ProveedoresCn
    {
        ConexionBD conexion = new ConexionBD();

        #region Proveedores
        public DataTable MostrandoProveedores()
        {
            return conexion.ConsultandoProveedores();
        }

        public string AgregandoProveedores(string rutProveedor, string nombreProveedor, string tipoProveedor, string contactoProveedor, bool estado)
        {
            return conexion.AgregarProveedores(rutProveedor, nombreProveedor, tipoProveedor, contactoProveedor, estado);
        }

        public string ActualizandoProveedores(int id, string rutProveedor, string nombreProveedor, string tipoProveedor, string contactoProveedor, bool estado)
        {
            return conexion.ActualizarProveedores(id, rutProveedor, nombreProveedor, tipoProveedor, contactoProveedor, estado);
        }
        #endregion

    }
}
