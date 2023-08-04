using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Bodega;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CapaPresentacion.Finanzas
{
    /// <summary>
    /// Lógica de interacción para PantallaCaja.xaml
    /// </summary>
    public partial class PantallaCaja : Window
    {
        public PantallaCaja()
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

        private void CargarCategorias()
        {
            RegistroCajeroCn registroCajeroCn = new RegistroCajeroCn();
            cbMesas.Items.Clear();
            foreach (var i in registroCajeroCn.ConsultandoMesas())
            {
                cbMesas.Items.Add(i);
            }
        }

        private void LimpiarCampos()
        {
            lbPrecioNeto.Content = "0";
            lbTotalConIva.Content= "0";
            lbVuelto.Content= "0";
            tbDescuento.Text = "0";
            tbEfectivo.Text = "0";
            cbMesas.Items.Clear();
        }

        private void btnPagar_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            RegistroCajero entidadRegistro = new RegistroCajero
            {
                MontoFinal = int.Parse(lbTotalConIva.Content.ToString()),
            };

            RegistroCajeroCn registroCajeroCn = new RegistroCajeroCn();


            valorRetorno = registroCajeroCn.CargandoMontoPago(entidadRegistro.MontoFinal);

            if (valorRetorno != null)
            {
                AvisoPagoCompletado avisoPagoCompletado = new AvisoPagoCompletado();
                avisoPagoCompletado.lbVueltoParaEntregar.Content = lbVuelto.Content;
                avisoPagoCompletado.Owner = this;
                avisoPagoCompletado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Si este mensaje aparece en pantalla, por favor comunique con el Administrador y entregue el siguiente código: ERRCA-002", "Error en Cierre de Caja", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            //Aquí envia la boleta al cliente
            if (int.Parse(lbTotalConIva.Content.ToString()) >= 1)
            {
                ServicioCorreo servicioCorreo = new ServicioCorreo();

                string NombreCliente = lbNombreCliente.Content.ToString();
                string MontoCliente = lbTotalConIva.Content.ToString();
                string CorreoCliente = lbCorreoCliente.Content.ToString();
                servicioCorreo.EnviarCorreo(NombreCliente, MontoCliente, CorreoCliente);

            }
            else
            {
                MessageBox.Show("Si este mensaje aparece en pantalla, por favor comunique con el Administrador y entregue el siguiente código: ERRCA-003", "Error en Cierre de Caja", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            
            //Aquí manda ingresa la venta a la tabla ventas
            if (int.Parse(lbTotalConIva.Content.ToString()) >= 1)
            {
                Ventas entidadVentas = new Ventas
                {
                    ClaveTransaccion = "31286414156",
                    FechaVenta = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    TotalVenta = int.Parse(lbTotalConIva.Content.ToString()),
                    EstadoVenta = "Pagado",
                    TipoPago = "Efectivo"
                };

                VentaCn ventaCn = new VentaCn();

                ventaCn.AgregandoVenta(entidadVentas.ClaveTransaccion, entidadVentas.FechaVenta, entidadVentas.TotalVenta, entidadVentas.EstadoVenta, entidadVentas.TipoPago);
  
            }
            else
            {
                MessageBox.Show("Si este mensaje aparece en pantalla, por favor comunique con el Administrador y entregue el siguiente código: ERRCA-003", "Error en Cierre de Caja", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (int.Parse(lbTotalConIva.Content.ToString()) >= 1)
            {
                VentaCn ventaCn = new VentaCn();
                ventaCn.EliminandoVentaPanel();
            }
            else
            {
                MessageBox.Show("Si este mensaje aparece en pantalla, por favor comunique con el Administrador y entregue el siguiente código: ERRCA-004", "Error en Cierre de Caja", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            LimpiarCampos();

            VentaCn ventaaParaMandar = new VentaCn();
            lbMontoTotalCajaParaCerrar.Content = ventaaParaMandar.ConsultandoTotalVenta();
        }

        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("Está a punto de abandonar la pantalla de caja, ¿Está seguro?", "Cerrar Pantalla de Caja", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (resultado)
            {
                case MessageBoxResult.Yes:
                    MenuCaja menuCaja = new MenuCaja();
                    menuCaja.lbNombreCajero.Content = lbNombreCajero.Content;
                    Hide();
                    menuCaja.Owner = this;
                    menuCaja.ShowDialog();
                    
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("No se ha realizado ninguna acción", "Cancelando Acción", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
            
        }

        private void btnCerrarCaja_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está a punto de cerrar caja. ¿Desea continuar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                VentanaConfirmarCierre ventanaConfirmarCierre = new VentanaConfirmarCierre();
                ventanaConfirmarCierre.lbFechaCierre.Content = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                ventanaConfirmarCierre.lbMontoFinal.Content = lbMontoTotalCajaParaCerrar.Content;
                ventanaConfirmarCierre.Owner = this;
                ventanaConfirmarCierre.ShowDialog();
            }
            
        }

        private void cbMesas_DropDownOpened(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnBuscarMesa_Click(object sender, RoutedEventArgs e)
        {
            RegistroCajero entidadRegistro = new RegistroCajero
            {
                NumeroMesa = cbMesas.Text
            };

            RegistroCajeroCn registroCajeroCn = new RegistroCajeroCn();
            DataGridProductosComprados.DataContext = registroCajeroCn.MostrandoProdutosComprandos(entidadRegistro.NumeroMesa);

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < DataGridProductosComprados.Items.Count; ++i)
            {
                //(decimal.Parse((tblData.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text))
                sum += (decimal.Parse((DataGridProductosComprados.Columns[3].GetCellContent(DataGridProductosComprados.Items[i]) as TextBlock).Text));
            }
            
            lbPrecioNeto.Content = sum;

        }

        private void btnActualizarTotal_Click(object sender, RoutedEventArgs e)
        {
            lbVuelto.Content = "0";
            float iva = 1.19f;
            int totalNeto = int.Parse(lbPrecioNeto.Content.ToString());
            int descuento = int.Parse(tbDescuento.Text);
            int efectivo = int.Parse(tbEfectivo.Text);
            double vuelto;
            double totalConIva;
            double totalConDescuento;


            if (tbDescuento.Text == "0")
            {
                totalConIva = Math.Truncate(totalNeto * iva);

                if (efectivo >= totalConIva)
                {
                    vuelto = efectivo - totalConIva;
                    lbTotalConIva.Content = totalConIva;
                    lbVuelto.Content = vuelto.ToString();
                }
                else
                {
                    MessageBox.Show("El efectivo debe ser mayor a Total + IVA para realizar el calculo.", "Información Faltante", MessageBoxButton.OK, MessageBoxImage.Information);
                    lbTotalConIva.Content = totalConIva;
                }
                
            }
            else
            {
                totalConDescuento = totalNeto - descuento;
                totalConIva = Math.Truncate(totalConDescuento * iva);

                if (efectivo >= totalConIva)
                {
                    vuelto = efectivo - totalConIva;
                    lbTotalConIva.Content = totalConIva;
                    lbVuelto.Content = vuelto.ToString();
                }
                else
                {
                    MessageBox.Show("El efectivo debe ser mayor a Total + IVA para realizar el calculo.", "Información Faltante", MessageBoxButton.OK, MessageBoxImage.Information);
                    lbTotalConIva.Content = totalConIva;
                }
            }
        }

        private void btnConsultarTotalEnCaja_Click(object sender, RoutedEventArgs e)
        {
            VentanaMontoTotal ventanaMontoTotal = new VentanaMontoTotal();
            ventanaMontoTotal.ShowDialog();
        }

        private void DataGridProductosComprados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbNombreCliente.Content = filaSeleccionada["cliente"].ToString();
                lbCorreoCliente.Content = filaSeleccionada["correo_cliente"].ToString();
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            VentaCn ventaaParaMandar = new VentaCn();
            lbMontoTotalCajaParaCerrar.Content = ventaaParaMandar.ConsultandoTotalVenta();
        }
    }
}
