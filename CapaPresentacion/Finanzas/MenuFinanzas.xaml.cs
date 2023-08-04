using CapaPresentacion.Principal;
using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace CapaPresentacion.Finanzas
{
    /// <summary>
    /// Lógica de interacción para MenuFinanzas.xaml
    /// </summary>
    public partial class MenuFinanzas : Window
    {
        public MenuFinanzas()
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
        //Metodo para Minimizar la Ventana
        private void btnMinimizarWin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            LoginUsuarios ventanaLogin = new LoginUsuarios();
            ventanaLogin.Show();
        }

        private void btnVentanaControlCaja_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MenuCaja menuCaja = new MenuCaja();
            menuCaja.lbNombreCajero.Content = lbNombreUsuarioMenu.Content;
            menuCaja.Owner = this;
            menuCaja.ShowDialog();
        }

        private void btnVentanaInformes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vista en Construcción");
        }

        private void btnVentanaUtilidadM_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vista en Construcción");
        }

        private void btnCategoriaCaja_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MenuCaja menuCaja = new MenuCaja();
            menuCaja.lbNombreCajero.Content = lbNombreUsuarioMenu.Content;
            menuCaja.Owner = this;
            menuCaja.ShowDialog();
        }

        private void btnCategoriaInformes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vista en Construcción");
        }
    }
}
