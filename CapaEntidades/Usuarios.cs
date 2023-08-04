namespace CapaEntidades
{
    public class Usuarios
    {
        #region Variables Publicas

        int idUsuario;
        string nombreUsuario;
        string contraseniaUsuario;
        string correoUsuario;
        string rolUsuario;
        bool estadoUsuario;

        #endregion

        #region Propiedades

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ContraseniaUsuario { get => contraseniaUsuario; set => contraseniaUsuario = value; }
        public string CorreoUsuario { get => correoUsuario; set => correoUsuario = value; }
        public string RolUsuario { get => rolUsuario; set => rolUsuario = value; }
        public bool EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        #endregion

    }
}
