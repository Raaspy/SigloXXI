using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class ClientesCn
    {
        ConexionBD conexion = new ConexionBD();

        public string AgregandoCliente(string nombreCliente, string apellidoCliente, string rut, string telefono, string correo)
        {
            return conexion.AgregarCliente(nombreCliente, apellidoCliente, rut, telefono, correo);
        }

        public string ActualizandoCliente(int idCliente, string nombreCliente, string apellidoCliente, string rut, string telefono, string correo)
        {
            return conexion.ActualizarCliente(idCliente, nombreCliente, apellidoCliente, rut, telefono, correo);
        }

        public DataTable MostrandoClientes()
        {
            return conexion.ConsultandoClientes();
        }
    }
}
