using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CapaPresentacion.Finanzas
{
    /// <summary>
    /// Lógica de interacción para MenuCaja.xaml
    /// </summary>
    public partial class MenuCaja : Window
    {
        public MenuCaja()
        {
            InitializeComponent();
        }

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

        //Metodo para maximizar la ventana
        private void btnMaximizarWin_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }


        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MenuFinanzas menuFinanzas = new MenuFinanzas();
            menuFinanzas.Owner= this;
            menuFinanzas.ShowDialog();
        }

        private void btnRealizarApertura_Click(object sender, RoutedEventArgs e)
        {
            string devolucion;
            Usuarios entidadUsuario = new Usuarios()
            {
                NombreUsuario = lbNombreCajero.Content.ToString(),
                ContraseniaUsuario = tbContraseniaUsuario.Password.Trim(),
            };

            UsuariosCn usuariosLn = new UsuariosCn();

            if (entidadUsuario.NombreUsuario != "" && entidadUsuario.ContraseniaUsuario != "")
            {
                devolucion = usuariosLn.ConsultandoLogin(entidadUsuario.NombreUsuario, entidadUsuario.ContraseniaUsuario);

                switch (devolucion)
                {
                    case "Finanzas":
                        Hide();
                        VentanaConfirmarApertura ventanaConfirmarApertura = new VentanaConfirmarApertura();
                        ventanaConfirmarApertura.lbNombreCajero.Content = lbNombreCajero.Content;
                        ventanaConfirmarApertura.lbMontoInicial.Content = tbMontoInicial.Text;
                        ventanaConfirmarApertura.lbFechaApertura.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        tbContraseniaUsuario.Password = string.Empty;
                        ventanaConfirmarApertura.Owner = this;
                        ventanaConfirmarApertura.ShowDialog();
                        break;

                    case null:
                        MessageBox.Show("Contraseña Incorrecta o Rol Inactivo. Si el error persiste, contacte con el Administrador", "Ups...", MessageBoxButton.OK, MessageBoxImage.Information);
                        tbContraseniaUsuario.Password = string.Empty;
                        break;
                }
            }
            else
            {
                MessageBox.Show("No aceptamos datos vacios!", "Ups...", MessageBoxButton.OK, MessageBoxImage.Information);
            } 
        }
    }
}
