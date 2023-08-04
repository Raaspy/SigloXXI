using CapaEntidades;
using CapaNegocios;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace CapaPresentacion.Bodega
{
    /// <summary>
    /// Lógica de interacción para CrudCategorias.xaml
    /// </summary>
    public partial class CrudCategorias : Window
    {
        bool estado;
        public CrudCategorias()
        {
            InitializeComponent();
        }

        #region CRUD Categorias
        private void DataGridCatInsumos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbnombreAnterior.Content = filaSeleccionada["categoria"].ToString(); //Actua como Nombre Anterior
                tbNuevaCategoria.Text = filaSeleccionada["categoria"].ToString();
                if (filaSeleccionada["estado_categoriainsumo"].ToString() == "Activo")
                {
                    rbCatInsumoActivo.IsChecked = true;
                }
                else
                {
                    rbCatInsumoInactivo.IsChecked = true;
                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Insumos entidadInsumos = new Insumos
            {
                CategoriaInsumo = tbNuevaCategoria.Text,
                EstadoInsumos = ComprobarEstado()
            };

            InsumosCn insumosCn = new InsumosCn();

            if (entidadInsumos.CategoriaInsumo != "" && entidadInsumos.EstadoInsumos == true | entidadInsumos.EstadoInsumos == false)
            {
                valorRetorno = insumosCn.AgregandoCategoria(entidadInsumos.CategoriaInsumo, entidadInsumos.EstadoInsumos);

                if (valorRetorno != null)
                {
                    MessageBox.Show("El Categoría: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("La Categoría: " + entidadInsumos.CategoriaInsumo + " fue ingresada con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarCategoria_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Insumos entidadInsumos = new Insumos
            {
                CategoriaInsumo = lbnombreAnterior.Content.ToString(), //Nombre Aterior.
                NombreInsumo = tbNuevaCategoria.Text,
                EstadoInsumos = ComprobarEstado()
            };

            InsumosCn insumosCn = new InsumosCn();

            if (entidadInsumos.NombreInsumo != "" && entidadInsumos.CategoriaInsumo != "")
            {
                valorRetorno = insumosCn.ActualizandoCategoria(entidadInsumos.NombreInsumo, entidadInsumos.CategoriaInsumo, entidadInsumos.EstadoInsumos);

                MessageBox.Show("La categoría: " + valorRetorno + " fue actualizada con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                Window_Loaded(sender, e);
                LimpiarDatos();
            }
            else if (entidadInsumos.NombreInsumo != "")
            {
                MessageBox.Show("Debe seleccionar la categoria que desea actualizar", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (entidadInsumos.CategoriaInsumo != "")
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

        //carga las categorias al entrar
        private void Window_Loaded(object sender, RoutedEventArgs e) //creo que esta obsoleto
        {
            //CargarCategorias();
        }

        public bool ComprobarEstado()
        {
            if (rbCatInsumoActivo.IsChecked == true)
            {
                estado = true;
            }
            else if (rbCatInsumoInactivo.IsChecked == true)
            {
                estado = false;
            }

            return estado;
        }

        private void LimpiarDatos()
        {
            lbnombreAnterior.Content = string.Empty;
            tbNuevaCategoria.Text = string.Empty;
            rbCatInsumoActivo.IsChecked = false;
            rbCatInsumoInactivo.IsChecked = false;
        }

        private void Window_Activated(object sender, System.EventArgs e)
        {
            InsumosCn insumos = new InsumosCn();
            DataGridCatInsumos.DataContext = insumos.MostrandoCategoriaInsumos();
        }
        #endregion
    }
}
