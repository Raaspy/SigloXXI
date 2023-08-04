using CapaEntidades;
using CapaNegocios;
using System;
using System.Windows;
using System.Windows.Input;

namespace CapaPresentacion.Finanzas
{
    /// <summary>
    /// Lógica de interacción para VentanaConfirmarCierre.xaml
    /// </summary>
    public partial class VentanaConfirmarCierre : Window
    {
        public VentanaConfirmarCierre()
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

        private void btnRealizarCierre_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            RegistroCajero entidadRegistro = new RegistroCajero
            {
                NombreCajero = "Finanzas",
                MontoFinal = int.Parse(lbMontoFinal.Content.ToString()), //aqui tiene que ir el monto final de la bd
                FechaCierre = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
            };

            RegistroCajeroCn registroCajeroCn = new RegistroCajeroCn();


            valorRetorno = registroCajeroCn.FinalizandoInformacionDeCajero(entidadRegistro.NombreCajero, entidadRegistro.MontoFinal, entidadRegistro.FechaCierre);

            if (valorRetorno != null)
            {
                Close();
                MessageBox.Show("Se ha realizado el Cierre de Caja.", "Cierre Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
                
                MenuCaja menuCaja = new MenuCaja();
                menuCaja.ShowDialog();
            }
            else
            {
                MessageBox.Show("Si este mensaje aparece en pantalla, por favor comunique con el Administrador y entregue el siguiente código: ERRCA-001", "Error en Cierre de Caja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnCancelarCierre_Click(object sender, RoutedEventArgs e)
        {
            Close();
            PantallaCaja pantallaCaja = new PantallaCaja();
            pantallaCaja.ShowDialog();
        }
    }
}
