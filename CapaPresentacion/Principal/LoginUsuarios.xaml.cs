using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Administrador;
using CapaPresentacion.Bodega;
using CapaPresentacion.Cocina;
using CapaPresentacion.Finanzas;
using System;
using System.Windows;
using System.Windows.Input;

namespace CapaPresentacion.Principal
{
    /// <summary>
    /// Lógica de interacción para LoginUsuarios.xaml
    /// </summary>
    public partial class LoginUsuarios : Window
    {
        //Ventanas de los Menú
        MenuAdmin ventanaAdmin = new MenuAdmin();
        MenuBodega ventanaBodega = new MenuBodega();
        MenuCocina ventanaCocina = new MenuCocina();
        MenuFinanzas ventanaFinanzas = new MenuFinanzas();

        public LoginUsuarios()
        {
            InitializeComponent();
        }

        #region Login
        //Metodo para Mover la Ventana
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //Metodo para minimizar la ventana
        private void btnMinimizarWin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //Metodo para cerrar la ventana
        private void btnCerrarWin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnEnviarDatosLogin_Click(object sender, RoutedEventArgs e)
        {
            string devolucion;
            Usuarios entidadUsuario = new Usuarios()
            {
                NombreUsuario = tbNombreUsuario.Text.Trim().ToLower(),
                ContraseniaUsuario = tbContraseniaUsuario.Password.Trim().ToLower(),
            };

            UsuariosCn usuariosLn = new UsuariosCn();

            if (entidadUsuario.NombreUsuario != "" && entidadUsuario.ContraseniaUsuario != "")
            {
                devolucion = usuariosLn.ConsultandoLogin(entidadUsuario.NombreUsuario, entidadUsuario.ContraseniaUsuario);

                switch (devolucion)
                {
                    case "Administrador":
                        Hide();
                        ventanaAdmin.lbNombreUsuarioMenu.Content = tbNombreUsuario.Text;
                        ventanaAdmin.lbRolUsuarioMenu.Content = devolucion.ToString();
                        ventanaAdmin.Owner = this;
                        ventanaAdmin.ShowDialog();
                        break;

                    case "Bodega":
                        Hide();
                        ventanaBodega.lbBienvenidaUsuario.Content = tbNombreUsuario.Text;
                        ventanaBodega.lbNombreUsuarioMenu.Content = tbNombreUsuario.Text;
                        ventanaBodega.lbRolUsuarioMenu.Content = devolucion.ToString();
                        ventanaBodega.Owner = this;
                        ventanaBodega.ShowDialog();
                        break;

                    case "Cocina":
                        Hide();
                        ventanaCocina.lbBienvenidaUsuario.Content = tbNombreUsuario.Text;
                        ventanaCocina.lbNombreUsuarioMenu.Content = tbNombreUsuario.Text;
                        ventanaCocina.lbRolUsuarioMenu.Content= devolucion.ToString();
                        ventanaCocina.Owner = this;
                        ventanaCocina.ShowDialog();
                        break;

                    case "Finanzas":
                        Hide();
                        ventanaFinanzas.lbBienvenidaUsuario.Content = tbNombreUsuario.Text;
                        ventanaFinanzas.lbNombreUsuarioMenu.Content = tbNombreUsuario.Text;
                        ventanaFinanzas.lbRolUsuarioMenu.Content = devolucion.ToString();
                        ventanaFinanzas.Owner = this;
                        ventanaFinanzas.ShowDialog();
                        break;

                    case null:
                        MessageBox.Show("Usuario o Contraseña Incorrectos. Compruebe que los datos ingresados sean correctos ó contacte con el Administrador para verificar su Estado de Usuario", "Ups...", MessageBoxButton.OK, MessageBoxImage.Information);
                        tbNombreUsuario.Text = string.Empty;
                        tbContraseniaUsuario.Password = string.Empty;
                        break;
                }
            }
            else
            {
                MessageBox.Show("No aceptamos datos vacios!", "Ups...", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion
    }
}