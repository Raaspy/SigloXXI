using CapaDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class ProductosCn
    {
        ConexionBD conexion = new ConexionBD();

        #region Productos
        public DataTable MostrandoProductos()
        {
            return conexion.ConsultandoProductos();
        }

        public List<string> ConsultandoCategoriasProductos()
        {
            return conexion.ConsultarCategoriasProductos();
        }

        public string AgregandoProductos(string nombreProducto, int precio, string urlImagen, bool estado, string tipoProducto)
        {
            return conexion.AgregarProductos(nombreProducto, precio, urlImagen, estado, tipoProducto);
        }

        public string ActualizandoProductos(int id, string nombreProducto, int precio, string urlImagen, bool estado, string tipoProducto)
        {
            return conexion.ActualizarProductos(id, nombreProducto, precio, urlImagen, estado, tipoProducto);
        }
        #endregion

        #region Categoria Productos
        public DataTable MostrandoCategoriaProductos()
        {
            return conexion.ConsultandoCategoriaProductos();
        }

        public string AgregandoCategoriaProducto(string nombreCategoria, bool estado)
        {
            return conexion.AgregarCategoriaProducto(nombreCategoria, estado);
        }

        public string ActualizandoCategoriaProducto(string nombreCategoria, string categoriaAnterior, bool estado)
        {
            return conexion.ActualizarCategoriaProducto(nombreCategoria, categoriaAnterior, estado);
        }
        #endregion

    }
}
