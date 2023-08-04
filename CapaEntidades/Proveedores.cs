using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedores
    {
        int idProveedor;
        string rutProveedor;
        string nombreProveedor;
        string tipoProveedor; //Descripcion
        string contactoProveedor;
        bool estadoProveedores;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string RutProveedor { get => rutProveedor; set => rutProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string TipoProveedor { get => tipoProveedor; set => tipoProveedor = value; }
        public string ContactoProveedor { get => contactoProveedor; set => contactoProveedor = value; }
        public bool EstadoProveedores { get => estadoProveedores; set => estadoProveedores = value; }
    }
}
