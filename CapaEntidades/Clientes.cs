using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Clientes
    {
        int idCliente;
        string nombreCliente;
        string apellidoCliente;
        string rutCliente;
        string telefonoCliente;
        string correoCiente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string RutCliente { get => rutCliente; set => rutCliente = value; }
        public string TelefonoCliente { get => telefonoCliente; set => telefonoCliente = value; }
        public string CorreoCiente { get => correoCiente; set => correoCiente = value; }
    }
}
