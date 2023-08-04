using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CapaPresentacion.Bodega
{
    /// <summary>
    /// Lógica de interacción para CrudLibroRecetas.xaml
    /// </summary>
    public partial class CrudLibroRecetas : Window
    {
        bool estado;
        public CrudLibroRecetas()
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

        //Metodo para Minimizar la Ventana
        private void btnMinimizarWin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public bool ComprobarEstado()
        {
            if (rbRecetaActivo.IsChecked == true)
            {
                estado = true;
            }
            else if (rbRecetaInactivo.IsChecked == true)
            {
                estado = false;
            }
            return estado;
        }

        public void LimpiarDatos()
        {
            lbReceta.Content = "0";
            tbNombreReceta.Text = string.Empty;
            rbRecetaActivo.IsChecked = false;
            rbRecetaInactivo.IsChecked = false;
        }

        private void btnAgregarReceta_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Recetas entidadRecetas = new Recetas
            {
                NombreReceta = tbNombreReceta.Text,
                DescripcionReceta = tbDescripcionReceta.Text,
                Estado = ComprobarEstado()
            };

            RecetasCn recetasCn = new RecetasCn();

            if (entidadRecetas.NombreReceta != "" && entidadRecetas.DescripcionReceta != "" && entidadRecetas.Estado == true | entidadRecetas.Estado == false)
            {
                valorRetorno = recetasCn.AgregandoRecetas(entidadRecetas.NombreReceta, entidadRecetas.DescripcionReceta, entidadRecetas.Estado);

                if (valorRetorno != null)
                {
                    MessageBox.Show("La Receta: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("La Receta: " + entidadRecetas.NombreReceta + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                    tbDescripcionReceta.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarReceta_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Recetas entidadRecetas = new Recetas
            {
                IdRecetas = int.Parse(lbReceta.Content.ToString()),
                NombreReceta = tbNombreReceta.Text,
                DescripcionReceta = tbDescripcionReceta.Text,
                Estado = ComprobarEstado()
            };

            RecetasCn recetasCn = new RecetasCn();

            if (entidadRecetas.NombreReceta != "" && entidadRecetas.DescripcionReceta != "" && entidadRecetas.Estado == true | entidadRecetas.Estado == false)
            {
                valorRetorno = recetasCn.ActualizandoRecetas(entidadRecetas.IdRecetas, entidadRecetas.NombreReceta, entidadRecetas.DescripcionReceta, entidadRecetas.Estado);

                if (valorRetorno == null)
                {
                    MessageBox.Show("La Receta: " + tbNombreReceta.Text + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                    tbDescripcionReceta.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("La Receta: " + tbNombreReceta.Text + " no se pudo ser actualizado con éxito!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                    tbDescripcionReceta.Text = string.Empty;

                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnVentanaInsumos_Click(object sender, RoutedEventArgs e)
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

        private void btnVentanaProductos_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.Owner = this;
            gestionProductos.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RecetasCn recetasCn = new RecetasCn();
            DataGridRecetas.DataContext = recetasCn.MostrandoRecetas();
        }

        private void DataGridRecetas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbReceta.Content = filaSeleccionada["id_recetas"].ToString();
                tbNombreReceta.Text = filaSeleccionada["nombre_receta"].ToString();
                tbDescripcionReceta.Text = filaSeleccionada["descripcion_receta"].ToString();
                if (filaSeleccionada["estado_receta"].ToString() == "Activo")
                {
                    rbRecetaActivo.IsChecked = true;
                }
                else
                {
                    rbRecetaInactivo.IsChecked = true;
                }
            }
        }
    }
}
