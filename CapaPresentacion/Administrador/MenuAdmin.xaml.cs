using CapaPresentacion.Bodega;
using CapaPresentacion.Cocina;
using CapaPresentacion.Finanzas;
using CapaPresentacion.Principal;
using System.Windows;
using System.Windows.Input;

namespace CapaPresentacion.Administrador
{
    /// <summary>
    /// Lógica de interacción para MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Window
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        #region Metodos Adicionales
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
            if (MessageBox.Show("Estás a punto de cerrar sesión. ¿Estás Seguro?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                LoginUsuarios ventanaLogin = new LoginUsuarios();
                ventanaLogin.Show();
            }
            
        }
        #endregion

        #region Ventanas Categorias
        private void btnCategoriaFinanzas_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está acción lo va direccionar a una sesión de finanzas. ¿Desea continuar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                MenuFinanzas menuFinanzas = new MenuFinanzas();
                menuFinanzas.Owner = this;
                menuFinanzas.ShowDialog();
            }
            
        }

        private void btnCategoriaBodega_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está acción lo va direccionar a una sesión de bodega. ¿Desea continuar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                MenuBodega menuBodega = new MenuBodega();
                menuBodega.Owner = this;
                menuBodega.ShowDialog();
            }
        }

        private void btnCategoriaCocina_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está acción lo va direccionar a una sesión de cocina. ¿Desea continuar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                MenuCocina menuCocina = new MenuCocina();
                menuCocina.Owner = this;
                menuCocina.ShowDialog();
            }        }

        //Ventana Vacia (Falta Construir)
        private void btnCategoriaInformes_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vista en Construcción");
        }
        #endregion

        #region Ventanas Panel
        private void btnVentanaCrudUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudUsuarios ventanaCrud = new CrudUsuarios();
            ventanaCrud.Owner = this;
            ventanaCrud.ShowDialog();
        }

        private void btnVentanaProveedores_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudProveedores proveedores = new CrudProveedores();
            proveedores.Owner = this;
            proveedores.ShowDialog();
        }

        private void btnVentanaMesas_Click(object sender, RoutedEventArgs e)
        {
            CrudMesas crudMesas = new CrudMesas();
            crudMesas.Owner = this;
            crudMesas.ShowDialog();
        }

        #endregion

        private void btnVentanaClientes_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudClientes crudClientes = new CrudClientes();
            crudClientes.Owner = this;
            crudClientes.ShowDialog();
        }
    }
}
