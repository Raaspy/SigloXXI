using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Productos
    {
        int idProducto;
        string nombreProducto;
        int precioProducto;
        string urlImagen;
        bool estadoProducto;
        string categoriaProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public string UrlImagen { get => urlImagen; set => urlImagen = value; }
        public bool EstadoProducto { get => estadoProducto; set => estadoProducto = value; }
        public string CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
    }
}
