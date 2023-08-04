using CapaEntidades;
using CapaNegocios;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CapaPresentacion.Administrador
{
    /// <summary>
    /// Lógica de interacción para CrudMesas.xaml
    /// </summary>
    public partial class CrudMesas : Window
    {
        bool estado;
        public CrudMesas()
        {
            InitializeComponent();
        }

        #region Metodos Adicionales
        private void btnCerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MesasCn mesasCn = new MesasCn();
            DataGridMesas.DataContext = mesasCn.MostrandoMesas();
        }

        public bool ComprobarEstado()
        {
            if (rbMesaDisponible.IsChecked == true)
            {
                estado = true;
            }
            else if (rbMesaNoDisponible.IsChecked == true)
            {
                estado = false;
            }
            return estado;
        }

        public void LimpiarDatos()
        {
            lbIdMesa.Content = "0";
            tbnumeroMesa.Text = string.Empty;
            rbMesaDisponible.IsChecked = false;
            rbMesaNoDisponible.IsChecked = false;
        }
        #endregion

        #region CRUD Mesas
        private void btnAgregarMesa_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            int number3 = 0;
            bool canConvert = int.TryParse(tbnumeroMesa.Text, out number3);

            if (canConvert == true)
            {
                string tempo;
                tempo = number3.ToString();
                tempo = tbnumeroMesa.Text;
            }
            else
            {
                //Funciona pero lanza muchos avisos y es molestoso
                //MessageBox.Show("El valor de precio no corresponde con lo solicitado.", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                tbnumeroMesa.Text = "0";
            }

            Mesas entidadMesas = new Mesas
            {
                NumeroMesa = int.Parse(tbnumeroMesa.Text),
                EstadoMesa = ComprobarEstado(),
            };

            MesasCn mesasCn = new MesasCn();

            if (entidadMesas.EstadoMesa == true | entidadMesas.EstadoMesa == false)
            {
                if (entidadMesas.NumeroMesa > 0)
                {
                    valorRetorno = mesasCn.AgregandoMesas(entidadMesas.NumeroMesa, entidadMesas.EstadoMesa);

                    if (valorRetorno != null)
                    {
                        MessageBox.Show("El Número de Mesa: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un número distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window_Loaded(sender, e);
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El Número de Mesa: " + entidadMesas.NumeroMesa + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window_Loaded(sender, e);
                        LimpiarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("El número de mesa debe ser mayor que 0!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbnumeroMesa.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar o los datos no corresponden con lo solicitado.", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarMesa_Click(object sender, RoutedEventArgs e)
        {
            int number3 = 0;
            bool canConvert = int.TryParse(tbnumeroMesa.Text, out number3);

            if (canConvert == true)
            {
                string tempo;
                tempo = number3.ToString();
                tempo = tbnumeroMesa.Text;
            }
            else
            {
                //Funciona pero lanza muchos avisos y es molestoso
                //MessageBox.Show("El valor de precio no corresponde con lo solicitado.", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                tbnumeroMesa.Text = "0";
            }

            Mesas entidadMesas = new Mesas
            {
                IdMesa = int.Parse(lbIdMesa.Content.ToString()),
                NumeroMesa = int.Parse(tbnumeroMesa.Text),
                EstadoMesa = ComprobarEstado()
            };

            MesasCn mesasCn = new MesasCn();

            if (entidadMesas.EstadoMesa == true | entidadMesas.EstadoMesa == false)
            {
                if (entidadMesas.NumeroMesa > 0)
                {
                    mesasCn.ActualizandoMesas(entidadMesas.IdMesa, entidadMesas.NumeroMesa, entidadMesas.EstadoMesa);

                    MessageBox.Show("El número de mesa: " + entidadMesas.NumeroMesa + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El número de mesa debe ser mayor que 0!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbnumeroMesa.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar o los datos no corresponden con lo solicitado.", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DataGridMesas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbIdMesa.Content = filaSeleccionada["id_mesa"].ToString();
                tbnumeroMesa.Text = filaSeleccionada["numero_mesa"].ToString();
                if (filaSeleccionada["mesa_disponible"].ToString() == "Disponible")
                {
                    rbMesaDisponible.IsChecked = true;
                }
                else
                {
                    rbMesaNoDisponible.IsChecked = true;
                }
            }
        }

        #endregion

    }
}
