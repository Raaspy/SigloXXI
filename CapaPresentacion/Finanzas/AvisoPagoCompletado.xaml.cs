using System.Windows;
using System.Windows.Input;

namespace CapaPresentacion.Finanzas
{
    /// <summary>
    /// Lógica de interacción para AvisoPagoCompletado.xaml
    /// </summary>
    public partial class AvisoPagoCompletado : Window
    {
        public AvisoPagoCompletado()
        {
            InitializeComponent();
        }

        private void btnConfirmacionFinal_Click(object sender, RoutedEventArgs e)
        {
            Close();
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
    }
}
