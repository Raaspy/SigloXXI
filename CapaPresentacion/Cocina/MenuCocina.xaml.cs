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

namespace CapaPresentacion.Cocina
{
    /// <summary>
    /// Lógica de interacción para MenuCocina.xaml
    /// </summary>
    public partial class MenuCocina : Window
    {
        public MenuCocina()
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

        private void btnCategoriaPanelCocina_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PanelCocina panelCocina = new PanelCocina();
            panelCocina.Owner = this;
            panelCocina.Show();
        }

        private void btnCategoriaPanelGarzon_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            PanelGarzon panelGarzon = new PanelGarzon();
            panelGarzon.Owner = this;
            panelGarzon.Show();
        }
    }
}
