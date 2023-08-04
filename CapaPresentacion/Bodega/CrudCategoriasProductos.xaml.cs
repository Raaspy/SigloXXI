using CapaEntidades;
using CapaNegocios;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CapaPresentacion.Bodega
{
    /// <summary>
    /// Lógica de interacción para CrudCategoriasProductos.xaml
    /// </summary>
    public partial class CrudCategoriasProductos : Window
    {
        bool estado;
        public CrudCategoriasProductos()
        {
            InitializeComponent();
        }

        #region CRUD Categoria Productos
        private void btnAgregarCategoriaProducto_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Productos entidadProducto = new Productos
            {
                CategoriaProducto = tbNuevaCategoria.Text,
                EstadoProducto = ComprobarEstado()
            };

            ProductosCn productosCn = new ProductosCn();


            if (entidadProducto.CategoriaProducto != "" && entidadProducto.EstadoProducto == true | entidadProducto.EstadoProducto == false)
            {
                valorRetorno = productosCn.AgregandoCategoriaProducto(entidadProducto.CategoriaProducto, entidadProducto.EstadoProducto);

                if (valorRetorno != null)
                {
                    MessageBox.Show("El Categoría: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("La Categoría: " + entidadProducto.CategoriaProducto + " fue ingresada con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarCategoriaProducto_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Productos entidadProductos = new Productos
            {
                CategoriaProducto = lbNombreAnterior.Content.ToString(), //Actua como nombre de variable anterior
                NombreProducto = tbNuevaCategoria.Text,
                EstadoProducto = ComprobarEstado()
            };

            ProductosCn productosCn = new ProductosCn();

            if (entidadProductos.NombreProducto != "" && entidadProductos.CategoriaProducto != "")
            {
                valorRetorno = productosCn.ActualizandoCategoriaProducto(entidadProductos.NombreProducto, entidadProductos.CategoriaProducto, entidadProductos.EstadoProducto);

                MessageBox.Show("La categoría: " + valorRetorno + " fue actualizada con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarDatos();
            }
            else if (entidadProductos.NombreProducto != "")
            {
                MessageBox.Show("Debe seleccionar la categoria que desea actualizar", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (entidadProductos.CategoriaProducto != "")
            {
                MessageBox.Show("Debe ingresar un nuevo nombre para actualizar", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion

        #region Metodos Adicionales
        private void btnCerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public bool ComprobarEstado()
        {
            if (rbCatProductoActivo.IsChecked == true)
            {
                estado = true;
            }
            else if (rbCatProductoInactivo.IsChecked == true)
            {
                estado = false;
            }

            return estado;
        }

        private void LimpiarDatos()
        {
            lbNombreAnterior.Content = string.Empty;
            tbNuevaCategoria.Text = string.Empty;
            rbCatProductoActivo.IsChecked = false;
            rbCatProductoInactivo.IsChecked = false;
        }

        private void DataGridCatProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbNombreAnterior.Content = filaSeleccionada["nombre_tipoproducto"].ToString(); //Actua como Nombre Anterior
                tbNuevaCategoria.Text = filaSeleccionada["nombre_tipoproducto"].ToString();
                if (filaSeleccionada["estado_tipoproducto"].ToString() == "Activo")
                {
                    rbCatProductoActivo.IsChecked = true;
                }
                else
                {
                    rbCatProductoInactivo.IsChecked = true;
                }
            }
        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            ProductosCn productos = new ProductosCn();
            DataGridCatProductos.DataContext = productos.MostrandoCategoriaProductos();
        }
        #endregion
    }
}
