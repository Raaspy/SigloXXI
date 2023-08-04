using CapaEntidades;
using CapaNegocios;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace CapaPresentacion.Cocina
{
    /// <summary>
    /// Lógica de interacción para PanelCocina.xaml
    /// </summary>
    public partial class PanelCocina : Window
    {
        bool estado;
        string numeroMesa;
        int contador = 6;
        public PanelCocina()
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

        //Metodo para Minimizar la ventana
        private void btnMinimizarWin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //Metodo para Maximizar la ventana
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

        public bool ComprobarEstado()
        {

            if (lbEstadoCocina.Content.Equals("Confirmado"))
            {
                estado = false;
            }
            else if (lbEstadoCocina.Content.Equals("Pendiente"))
            {
                estado = true;
            }

            return estado;
        }

        private void LimpiarDatos()
        {
            lbCantidad.Content = string.Empty;
            lbNombrePlatillo.Content = string.Empty;
            lbEstadoCocina.Content = string.Empty;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DatosCarritoCn datosCarritoCn = new DatosCarritoCn();
            DataGridPanelCocina.DataContext = datosCarritoCn.MostrandoPedidosCocina();

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
                DataGridPanelCocina.DataContext = datosCarritoCn.MostrandoPedidosCocina();
                contador = 6;
            }
           
        }

        private void DataGridPanelCocina_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbCantidad.Content = filaSeleccionada["cantidad_carrito"].ToString();
                lbNombrePlatillo.Content = filaSeleccionada["nombre_producto"].ToString();
                numeroMesa = filaSeleccionada["numero_mesa"].ToString();
                if (filaSeleccionada["estado_cocina"].ToString() == "Confirmado")
                {
                    lbEstadoCocina.Content = "Confirmado";
                }
                else
                {
                    lbEstadoCocina.Content = "Pendiente";
                }
            }
        }

        private void btnConfirmarPedidoCocina_Click(object sender, RoutedEventArgs e)
        {
            DatosCarrito entidadCarrito = new DatosCarrito
            {
                NombreProducto = lbNombrePlatillo.Content.ToString(),
                EstadoCocina = ComprobarEstado(),
                NumeroMesa = numeroMesa
            };

            DatosCarritoCn datosCarritoCn = new DatosCarritoCn();

            if (entidadCarrito.EstadoCocina == true | entidadCarrito.EstadoCocina == false)
            {
                if (entidadCarrito.EstadoCocina == true)
                {
                    datosCarritoCn.ActualizandoPanelCocina(numeroMesa, entidadCarrito.EstadoCocina, entidadCarrito.NombreProducto);

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
