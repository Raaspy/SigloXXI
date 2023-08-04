using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows;
using System.Windows.Input;

namespace CapaPresentacion.Finanzas
{
    /// <summary>
    /// Lógica de interacción para VentanaConfirmarApertura.xaml
    /// </summary>
    public partial class VentanaConfirmarApertura : Window
    {
        public VentanaConfirmarApertura()
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

        private void btnRealizarApertura_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            int number3 = 0;
            bool canConvert = int.TryParse(lbMontoInicial.Content.ToString(), out number3);

            if (canConvert == true)
            {
                string tempo;
                tempo = number3.ToString();
                tempo = lbMontoInicial.Content.ToString();
            }
            else
            {
                //Funciona pero lanza muchos avisos y es molestoso
                //MessageBox.Show("El valor de precio no corresponde con lo solicitado.", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                lbMontoInicial.Content = "0";
            }

            RegistroCajero entidadRegistro = new RegistroCajero
            {
                NombreCajero = lbNombreCajero.Content.ToString(),
                MontoInicial = int.Parse(lbMontoInicial.Content.ToString()),
                MontoFinal = 0,
                FechaApertura = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
            };

            RegistroCajeroCn registroCajeroCn = new RegistroCajeroCn();

            
            valorRetorno = registroCajeroCn.AgregandoInformacionDeCajero(entidadRegistro.NombreCajero, entidadRegistro.MontoInicial, entidadRegistro.MontoFinal, entidadRegistro.FechaApertura);

            if (valorRetorno != null)
            {
                MessageBox.Show("Ingresando a la pantalla de caja. Recuerde verificar el estado de caja antes de realizar el cierre de caja.", "Sistema de Caja", MessageBoxButton.OK, MessageBoxImage.Information);
                Hide();
                PantallaCaja pantallaCaja = new PantallaCaja();
                pantallaCaja.lbNombreCajero.Content = lbNombreCajero.Content;
                pantallaCaja.Owner = this;
                pantallaCaja.ShowDialog();
            }
        }
        private void btnCancelarApertura_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MenuCaja menuCaja = new MenuCaja();
            menuCaja.lbNombreCajero.Content = lbNombreCajero.Content;
            menuCaja.ShowDialog();
        }
    }
}