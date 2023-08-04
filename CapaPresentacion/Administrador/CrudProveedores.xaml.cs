using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.Bodega;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CapaPresentacion.Administrador
{
    /// <summary>
    /// Lógica de interacción para CrudProveedores.xaml
    /// </summary>
    public partial class CrudProveedores : Window
    {
        bool estado;
        public CrudProveedores()
        {
            InitializeComponent();
        }

        #region Botones Panel
        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MenuAdmin ventanaMenuAdmin = new MenuAdmin();
            ventanaMenuAdmin.ShowDialog();
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

        private void btnVentanaUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudUsuarios crudUsuarios = new CrudUsuarios();
            crudUsuarios.Owner = this;
            crudUsuarios.ShowDialog();
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

        private void btnVentanaClientes_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudClientes crudClientes = new CrudClientes();
            crudClientes.Owner = this;
            crudClientes.ShowDialog();
        }
        #endregion

        #region Metodos Adicionales
        //Metodo para Minimizar la Ventana
        private void btnMinimizarWin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProveedoresCn proveedoresCn = new ProveedoresCn();
            DataGridProveedores.DataContext = proveedoresCn.MostrandoProveedores();
        }

        public bool ComprobarEstado()
        {
            if (rbProveedorActivo.IsChecked == true)
            {
                estado = true;
            }
            else if (rbProveedorInactivo.IsChecked == true)
            {
                estado = false;
            }

            return estado;
        }

        private void LimpiarDatos()
        {
            lbIdProveedor.Content = "0";
            tbRutProveedor.Text = string.Empty;
            tbRutProveedor.IsEnabled = true;
            tbNombreProveedor.Text = string.Empty;
            tbDescripcionProveedor.Text = string.Empty;
            tbContactoProveedor.Text = string.Empty;
            rbProveedorActivo.IsChecked = false;
            rbProveedorInactivo.IsChecked = false;
        }

        private void DataGridProveedores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbIdProveedor.Content = filaSeleccionada["id_proveedor"].ToString();
                tbRutProveedor.Text = filaSeleccionada["rut_proveedor"].ToString();
                tbRutProveedor.IsEnabled = false;
                tbNombreProveedor.Text = filaSeleccionada["nombre_proveedor"].ToString();
                tbDescripcionProveedor.Text = filaSeleccionada["tipo_proveedor"].ToString();
                tbContactoProveedor.Text = filaSeleccionada["contacto_proveedor"].ToString();
                if (filaSeleccionada["estado_proveedor"].ToString() == "Activo")
                {
                    rbProveedorActivo.IsChecked = true;
                }
                else
                {
                    rbProveedorInactivo.IsChecked = true;
                }
            }
        }
        #endregion

        #region CRUD Proveedores
        private void btnAgregarProveedor_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Proveedores entidadProveedores = new Proveedores()
            {
                RutProveedor = tbRutProveedor.Text,
                NombreProveedor = tbNombreProveedor.Text,
                TipoProveedor = tbDescripcionProveedor.Text,
                ContactoProveedor = tbContactoProveedor.Text,
                EstadoProveedores = ComprobarEstado()
            };

            ProveedoresCn proveedoresCn = new ProveedoresCn();

            if (entidadProveedores.RutProveedor != "" && entidadProveedores.NombreProveedor != "" && entidadProveedores.TipoProveedor != "" && entidadProveedores.ContactoProveedor != "" && entidadProveedores.EstadoProveedores == true | entidadProveedores.EstadoProveedores == false)
            {
                valorRetorno = proveedoresCn.AgregandoProveedores(entidadProveedores.RutProveedor, entidadProveedores.NombreProveedor, entidadProveedores.TipoProveedor, entidadProveedores.ContactoProveedor, entidadProveedores.EstadoProveedores);

                if (valorRetorno != null)
                {
                    MessageBox.Show("El Proveedor registrado con el RUT: " + valorRetorno + " ya existe en el sistema. Verifique que los datos ingresados sean correctos.", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El Proveedor: " + entidadProveedores.NombreProveedor + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarProveedor_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Proveedores entidadProveedores = new Proveedores()
            {
                IdProveedor = int.Parse(lbIdProveedor.Content.ToString()),
                RutProveedor = tbRutProveedor.Text,
                NombreProveedor = tbNombreProveedor.Text,
                TipoProveedor = tbDescripcionProveedor.Text,
                ContactoProveedor = tbContactoProveedor.Text,
                EstadoProveedores = ComprobarEstado()
            };

            ProveedoresCn proveedoresCn = new ProveedoresCn();

            if (entidadProveedores.RutProveedor != "" && entidadProveedores.NombreProveedor != "" && entidadProveedores.TipoProveedor != "" && entidadProveedores.ContactoProveedor != "")
            {
                valorRetorno = proveedoresCn.ActualizandoProveedores(entidadProveedores.IdProveedor, entidadProveedores.RutProveedor, entidadProveedores.NombreProveedor, entidadProveedores.TipoProveedor, entidadProveedores.ContactoProveedor, entidadProveedores.EstadoProveedores);

                if (valorRetorno == null)
                {
                    MessageBox.Show("El proveedor: " + lbIdProveedor.Content + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    tbRutProveedor.IsEnabled= true;
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El proveedor: " + lbIdProveedor.Content + " no se pudo ser actualizado con éxito!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("No se puede actualizar un proveedor vacio!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion

    }
}
