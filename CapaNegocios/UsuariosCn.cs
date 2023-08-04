using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class UsuariosCn
    {
        ConexionBD conexion = new ConexionBD();

        #region Usuarios
        public string ConsultandoLogin(string usuario, string contrasenia)
        {
            return conexion.ConsultaLogin(usuario, contrasenia);
        }

        public DataTable MostrandoUsuarios()
        {
            return conexion.ConsultandoUsuarios();
        }

        public string AgregandoUsuarios(string usuario, string contrasenia, string correo, string rol, bool estado)
        {
            return conexion.AgregarUsuario(usuario, contrasenia, correo, rol, estado);
        }

        public string ActualizandoUsuarios(int id, string usuario, string contrasenia, string correo, string rol, bool estado)
        {
            return conexion.ActualizarUsuario(id, usuario, contrasenia, correo, rol, estado);
        }
        #endregion

    }
}
