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
    /// Lógica de interacción para VentanaMontoTotal.xaml
    /// </summary>
    public partial class VentanaMontoTotal : Window
    {
        public VentanaMontoTotal()
        {
            InitializeComponent();
        }

        private void btnCerrarVen_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            VentaCn ventaCn = new VentaCn();
            lbMontoTotalCaja.Content = ventaCn.ConsultandoTotalVenta();
        }
    }
}
