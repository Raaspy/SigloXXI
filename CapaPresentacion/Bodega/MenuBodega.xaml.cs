using CapaPresentacion.Administrador;
using CapaPresentacion.Principal;
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

namespace CapaPresentacion.Bodega
{
    /// <summary>
    /// Lógica de interacción para MenuBodega.xaml
    /// </summary>
    public partial class MenuBodega : Window
    {
        public MenuBodega()
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

        private void btnVentanaInsumos_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudBodega crudBodega = new CrudBodega();
            crudBodega.lbNombreBodega.Content = lbNombreUsuarioMenu.Content;
            crudBodega.Owner = this;
            crudBodega.ShowDialog();
        }

        private void btnVentanaCrudProductod_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.Owner = this;
            gestionProductos.ShowDialog();
        }

        private void btnVentanaSolicitar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vista en Construcción");
        }

        private void btnCategoriaInsumos_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudBodega crudBodega = new CrudBodega();
            crudBodega.lbNombreBodega.Content = lbNombreUsuarioMenu.Content;
            crudBodega.Owner = this;
            crudBodega.ShowDialog();
        }

        private void btnCategoriaSolicitar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.Owner = this;
            gestionProductos.ShowDialog();
        }

        private void btnCategoriaAlmanaque_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudLibroRecetas crudLibroRecetas = new CrudLibroRecetas();
            crudLibroRecetas.Owner = this;
            crudLibroRecetas.ShowDialog();
        }
    }
}
