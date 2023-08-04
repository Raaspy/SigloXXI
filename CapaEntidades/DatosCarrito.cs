using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DatosCarrito
    {
        int idPanelCocina;
        int cantidad;
        string nombreProducto;
        bool estadoCocina;
        bool estadoGarzon;
        string numeroMesa;
        string nombreCliente;
        string correoCliente;

        public int IdPanelCocina { get => idPanelCocina; set => idPanelCocina = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public bool EstadoCocina { get => estadoCocina; set => estadoCocina = value; }
        public bool EstadoGarzon { get => estadoGarzon; set => estadoGarzon = value; }
        public string NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }
    }
}
