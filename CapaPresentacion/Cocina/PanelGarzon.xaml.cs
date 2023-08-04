using CapaNegocios;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Data;
using CapaEntidades;

namespace CapaPresentacion.Cocina
{
    /// <summary>
    /// Lógica de interacción para PanelGarzon.xaml
    /// </summary>
    public partial class PanelGarzon : Window
    {
        bool estado;
        string numeroMesa;
        int contador = 6;
        public PanelGarzon()
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

        public bool ComprobarEstado()
        {

            if (lbEstadoGarzon.Content.Equals("Confirmado"))
            {
                estado = false;
            }
            else if (lbEstadoGarzon.Content.Equals("Pendiente"))
            {
                estado = true;
            }

            return estado;
        }

        private void LimpiarDatos()
        {
            lbCantidad.Content = string.Empty;
            lbNombrePlatillo.Content = string.Empty;
            lbEstadoGarzon.Content = string.Empty;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DatosCarritoCn datosCarritoCn = new DatosCarritoCn();
            DataGridPanelGarzon.DataContext = datosCarritoCn.MostrandoPedidosGarzon();

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            contador--;
            lbContadorActualizacion.Content = contador.ToString();

            if (contador == 0)
            {
                DatosCarritoCn datosCarritoCn = new DatosCarritoCn();
                DataGridPanelGarzon.DataContext = datosCarritoCn.MostrandoPedidosGarzon();
                contador = 6;
            }

        }

        private void DataGridPanelGarzon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbCantidad.Content = filaSeleccionada["cantidad_carrito"].ToString();
                lbNombrePlatillo.Content = filaSeleccionada["nombre_producto"].ToString();
                numeroMesa = filaSeleccionada["numero_mesa"].ToString();
                if (filaSeleccionada["estado_garzon"].ToString() == "Confirmado")
                {
                    lbEstadoGarzon.Content = "Confirmado";
                }
                else
                {
                    lbEstadoGarzon.Content = "Pendiente";
                }
            }
        }

        private void btnConfirmarEstadoGarzon_Click(object sender, RoutedEventArgs e)
        {
            DatosCarrito entidadCarrito = new DatosCarrito
            {
                NombreProducto = lbNombrePlatillo.Content.ToString(),
                EstadoGarzon = ComprobarEstado(),
                NumeroMesa = numeroMesa
            };

            DatosCarritoCn datosCarritoCn = new DatosCarritoCn();

            if (entidadCarrito.EstadoGarzon == true | entidadCarrito.EstadoGarzon == false)
            {
                if (entidadCarrito.EstadoGarzon == true)
                {
                    datosCarritoCn.ActualizandoPanelGarzon(numeroMesa, entidadCarrito.EstadoGarzon, entidadCarrito.NombreProducto);

                    MessageBox.Show("El estado del producto(s) fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El estado del producto ya esta confirmado!", "Estado Confirmado", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido para cambiar su estado.", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MenuCocina menuCocina = new MenuCocina();
            menuCocina.ShowDialog();
        }
    }
}
