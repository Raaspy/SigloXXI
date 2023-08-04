using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Bodega;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CapaPresentacion.Administrador
{
    /// <summary>
    /// Lógica de interacción para CrudClientes.xaml
    /// </summary>
    public partial class CrudClientes : Window
    {
        public CrudClientes()
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

        private void LimpiarDatos()
        {
            lbIdCliente.Content = "0";
            tbNombreCliente.Text = string.Empty;
            tbApellidoCliente.Text = string.Empty;
            tbRutCliente.Text = string.Empty;
            tbTelefonoCliente.Text = string.Empty;
            tbCorreoCliente.Text = string.Empty;
        }

        private void btnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Clientes entidadCliente = new Clientes
            {
                NombreCliente = tbNombreCliente.Text,
                ApellidoCliente = tbApellidoCliente.Text,
                RutCliente = tbRutCliente.Text,
                TelefonoCliente = tbTelefonoCliente.Text,
                CorreoCiente = tbCorreoCliente.Text,
            };

            ClientesCn clientesCn = new ClientesCn();

            if (entidadCliente.NombreCliente != "" && entidadCliente.ApellidoCliente != "" && entidadCliente.RutCliente != "" && entidadCliente.TelefonoCliente != "" && entidadCliente.CorreoCiente != "")
            {
                valorRetorno = clientesCn.AgregandoCliente(entidadCliente.NombreCliente, entidadCliente.ApellidoCliente, entidadCliente.RutCliente, entidadCliente.TelefonoCliente, entidadCliente.CorreoCiente);

                if (valorRetorno != null)
                {
                    MessageBox.Show("El Cliente: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El Cliente: " + entidadCliente.NombreCliente + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarCliente_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Clientes entidadCliente = new Clientes
            {
                IdCliente = int.Parse(lbIdCliente.Content.ToString()),
                NombreCliente = tbNombreCliente.Text,
                ApellidoCliente = tbApellidoCliente.Text,
                RutCliente = tbRutCliente.Text,
                TelefonoCliente = tbTelefonoCliente.Text,
                CorreoCiente = tbCorreoCliente.Text,
            };

            ClientesCn clientesCn = new ClientesCn();

            if (entidadCliente.NombreCliente != "" && entidadCliente.ApellidoCliente != "" && entidadCliente.RutCliente != "" && entidadCliente.TelefonoCliente != "" && entidadCliente.CorreoCiente != "")
            {
                valorRetorno = clientesCn.ActualizandoCliente(entidadCliente.IdCliente, entidadCliente.NombreCliente, entidadCliente.ApellidoCliente, entidadCliente.RutCliente, entidadCliente.TelefonoCliente, entidadCliente.CorreoCiente);

                if (valorRetorno == null)
                {
                    MessageBox.Show("El Cliente: " + tbNombreCliente.Text + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    tbRutCliente.IsEnabled = true;
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El Cliente: " + tbNombreCliente.Text + " no se pudo ser actualizado con éxito!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    tbRutCliente.IsEnabled = true;
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnVentanaUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudUsuarios crudUsuarios = new CrudUsuarios();
            crudUsuarios.Owner = this;
            crudUsuarios.ShowDialog();
        }

        private void btnVentanaSuministros_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está acción lo va direccionar a una sesión de bodega. ¿Desea continuar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                CrudBodega suministros = new CrudBodega();
                suministros.Owner = this;
                suministros.ShowDialog();
            }
        }

        private void btnVentanaProveedores_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudProveedores proveedores = new CrudProveedores();
            proveedores.Owner = this;
            proveedores.ShowDialog();
        }

        private void btnVentanaProductos_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Está acción lo va direccionar a una sesión de bodega. ¿Desea continuar?", "Advertencia", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                //No pasa nada
            }
            else
            {
                Hide();
                GestionProductos gestionProductos = new GestionProductos();
                gestionProductos.Owner = this;
                gestionProductos.ShowDialog();
            }
        }

        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MenuAdmin ventanaMenuAdmin = new MenuAdmin();
            ventanaMenuAdmin.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClientesCn clientesCn = new ClientesCn();
            DataGridClientes.DataContext = clientesCn.MostrandoClientes();
        }

        private void DataGridClientes_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbIdCliente.Content = filaSeleccionada["id_clientes"].ToString();
                tbNombreCliente.Text = filaSeleccionada["nombre_cliente"].ToString();
                tbApellidoCliente.Text = filaSeleccionada["apellido_cliente"].ToString();
                tbRutCliente.Text = filaSeleccionada["rut_cliente"].ToString();
                tbRutCliente.IsEnabled = false;
                tbTelefonoCliente.Text = filaSeleccionada["telefono_cliente"].ToString();
                tbCorreoCliente.Text = filaSeleccionada["correo_cliente"].ToString();
            }
        }
    }
}
