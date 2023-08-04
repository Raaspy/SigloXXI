using CapaEntidades;
using CapaNegocios;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CapaPresentacion.Bodega
{
    /// <summary>
    /// Lógica de interacción para GestionProductos.xaml
    /// </summary>
    public partial class GestionProductos : Window
    {
        bool estado;
        public GestionProductos()
        {
            InitializeComponent();
        }

        #region CRUD Productos
        private void btnGuardarProducto_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            int number3 = 0;
            bool canConvert = int.TryParse(tbPrecioProducto.Text, out number3);

            if (canConvert == true)
            {
                string tempo;
                tempo = number3.ToString();
                tempo = tbPrecioProducto.Text;
            }
            else
            {
                //Funciona pero lanza muchos avisos y es molestoso
                //MessageBox.Show("El valor de precio no corresponde con lo solicitado.", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                tbPrecioProducto.Text = "0";
            }

            Productos entidadProducto = new Productos
            {
                NombreProducto = tbNombreProducto.Text,
                PrecioProducto = int.Parse(tbPrecioProducto.Text),
                UrlImagen = tbUrlImagen.Text,
                CategoriaProducto = cbCategoriaProducto.Text,
                EstadoProducto = ComprobarEstado(),
            };

            ProductosCn productosCn = new ProductosCn();

            if (entidadProducto.NombreProducto != "" && entidadProducto.UrlImagen != "" && entidadProducto.CategoriaProducto != "" && entidadProducto.EstadoProducto == true | entidadProducto.EstadoProducto == false)
            {
                if (entidadProducto.PrecioProducto > 0)
                {
                    valorRetorno = productosCn.AgregandoProductos(entidadProducto.NombreProducto, entidadProducto.PrecioProducto, entidadProducto.UrlImagen, entidadProducto.EstadoProducto, entidadProducto.CategoriaProducto);

                    if (valorRetorno != null)
                    {
                        MessageBox.Show("El Producto: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window_Loaded(sender, e);
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El Producto: " + entidadProducto.NombreProducto + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                        Window_Loaded(sender, e);
                        LimpiarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("El precio debe ser mayor que 0!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbPrecioProducto.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar o los datos no corresponden con lo solicitado.", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarProducto_Click(object sender, RoutedEventArgs e)
        {
            int number3 = 0;
            bool canConvert = int.TryParse(tbPrecioProducto.Text, out number3);

            if (canConvert == true)
            {
                string tempo;
                tempo = number3.ToString();
                tempo = tbPrecioProducto.Text;
            }
            else
            {
                //Funciona pero lanza muchos avisos y es molestoso
                //MessageBox.Show("El valor de precio no corresponde con lo solicitado.", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                tbPrecioProducto.Text = "0";
            }

            Productos entidadProducto = new Productos
            {
                IdProducto = int.Parse(lbIdProducto.Content.ToString()),
                NombreProducto = tbNombreProducto.Text,
                PrecioProducto = int.Parse(tbPrecioProducto.Text),
                UrlImagen = tbUrlImagen.Text,
                CategoriaProducto = cbCategoriaProducto.Text,
                EstadoProducto = ComprobarEstado(),
            };

            ProductosCn productosCn = new ProductosCn();

            if (entidadProducto.NombreProducto != "" && entidadProducto.UrlImagen != "" && entidadProducto.CategoriaProducto != "" && entidadProducto.EstadoProducto == true | entidadProducto.EstadoProducto == false)
            {
                if (entidadProducto.PrecioProducto > 0)
                {
                    productosCn.ActualizandoProductos(entidadProducto.IdProducto, entidadProducto.NombreProducto, entidadProducto.PrecioProducto, entidadProducto.UrlImagen, entidadProducto.EstadoProducto, entidadProducto.CategoriaProducto);

                    MessageBox.Show("El Producto: " + entidadProducto.NombreProducto + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El precio debe ser mayor que 0!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
                    tbPrecioProducto.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar o los datos no corresponden con lo solicitado.", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        //Seleccion de datos
        private void DataGridProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbIdProducto.Content = filaSeleccionada["id_producto"].ToString();
                tbNombreProducto.Text = filaSeleccionada["nombre_producto"].ToString();
                tbPrecioProducto.Text = filaSeleccionada["precio_producto"].ToString();
                tbUrlImagen.Text = filaSeleccionada["imagen_producto"].ToString();
                cbCategoriaProducto.Text = filaSeleccionada["nombre_tipoproducto"].ToString();

                if (filaSeleccionada["estado_producto"].ToString() == "Disponible")
                {
                    rbProductoDisponible.IsChecked = true;
                }
                else
                {
                    rbProductoNoDisponible.IsChecked = true;
                }

            }
        }
        #endregion

        #region Metodos Adicionales
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
            lbIdProducto.Content = "0";
            tbNombreProducto.Text = string.Empty;
            tbPrecioProducto.Text = string.Empty;
            tbUrlImagen.Text = string.Empty;
            cbCategoriaProducto.Text = string.Empty;
            rbProductoDisponible.IsChecked = false;
            rbProductoNoDisponible.IsChecked = false;
        }

        public bool ComprobarEstado()
        {

            if (rbProductoDisponible.IsChecked == true)
            {
                estado = true;
            }
            else if (rbProductoNoDisponible.IsChecked == true)
            {
                estado = false;
            }

            return estado;
        }
        #endregion

        #region Cargar Datos
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductosCn productos = new ProductosCn();
            DataGridProductos.DataContext = productos.MostrandoProductos();

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            ProductosCn productos = new ProductosCn();
            cbCategoriaProducto.Items.Clear();
            foreach (var i in productos.ConsultandoCategoriasProductos())
            {
                cbCategoriaProducto.Items.Add(i);
            }
        }

        private void cbCategoriaProducto_DropDownOpened(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        //esto genera que la categoria se reinicie cada vez que la ventana entra en modo main!
        private void Window_Activated(object sender, EventArgs e)
        {
            CargarCategorias();
        }
        #endregion

        #region Ventanas
        private void btnModificarCategorias_Click(object sender, RoutedEventArgs e)
        {
            CrudCategoriasProductos ventanaCategoriasProductos = new CrudCategoriasProductos();
            ventanaCategoriasProductos.Owner = this;
            ventanaCategoriasProductos.ShowDialog();
        }

        //Ventana Vacia (Falta Construir)
        private void btnVentanaSolicitud_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudLibroRecetas crudLibroRecetas = new CrudLibroRecetas();
            crudLibroRecetas.Owner = this;
            crudLibroRecetas.ShowDialog();
        }

        private void btnVentanaSuministros_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudBodega suministros = new CrudBodega();
            suministros.Owner = this;
            suministros.ShowDialog();
        }

        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MenuBodega menuBodega = new MenuBodega();
            menuBodega.ShowDialog();
        }
        #endregion

    }
}
