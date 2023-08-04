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

namespace CapaPresentacion.Bodega
{
    /// <summary>
    /// Lógica de interacción para HistorialInsumos.xaml
    /// </summary>
    public partial class HistorialInsumos : Window
    {
        public HistorialInsumos()
        {

            InitializeComponent();
        }

        private void btnCerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            HistorialCambiosCn historialCambiosCn = new HistorialCambiosCn();
            DataGridHistInsumos.DataContext = historialCambiosCn.MostrandoHistorialInsumos();
        }
    }
}
