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
    /// Lógica de interacción para CrudBodega.xaml
    /// </summary>
    public partial class CrudBodega : Window
    {
        bool estado;
        public CrudBodega()
        {
            InitializeComponent();
        }

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

        private void DataGridInsumos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbIdInsumo.Content = filaSeleccionada["id_insumos"].ToString();
                tbNombreInsumo.Text = filaSeleccionada["nombre_insumo"].ToString();
                cbCategoriaInsumo.Text = filaSeleccionada["categoria"].ToString();
                tbCantidadDisponible.Text = filaSeleccionada["cantidad_disponible"].ToString();
                lbCantidadInsumoCambio.Content = filaSeleccionada["cantidad_disponible"].ToString();  //esta obtiene la cantidad inicial registrada en el datagrid
                tbCantidadIdeal.Text = filaSeleccionada["cantidad_ideal"].ToString();
                if (filaSeleccionada["estado_insumos"].ToString() == "Activo")
                {
                    rbInsumoActivo.IsChecked = true;
                }
                else
                {
                    rbInsumoInactivo.IsChecked = true;
                }
            }
        }

        public bool ComprobarEstado()
        {
            if (rbInsumoActivo.IsChecked == true)
            {
                estado = true;
            }
            else if (rbInsumoInactivo.IsChecked == true)
            {
                estado = false;
            }

            return estado;
        }

        private void LimpiarDatos()
        {
            lbIdInsumo.Content = "0";
            tbNombreInsumo.Text = string.Empty;
            cbCategoriaInsumo.Text = string.Empty;
            tbCantidadDisponible.Text = string.Empty;
            tbCantidadIdeal.Text = string.Empty;
            rbInsumoActivo.IsChecked = false;
            rbInsumoInactivo.IsChecked = false;
        }
        #endregion

        #region Cargar Datos
        private void cbCategoriaInsumo_DropDownOpened(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            InsumosCn insumos = new InsumosCn();
            cbCategoriaInsumo.Items.Clear();
            foreach (var i in insumos.ConsultandoCategorias())
            {
                cbCategoriaInsumo.Items.Add(i);
            }
        }

        //Carga el datagrid y categorias cuando carga la ventana, (revisar categorias porque se repide muchas veces en diferentes metodos)
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InsumosCn insumos = new InsumosCn();
            DataGridInsumos.DataContext = insumos.MostrandoInsumos();

            CargarCategorias();
        }

        //Carga el datagrid y categorias cuando se cierra la ventana secundaria
        private void Window_Activated(object sender, EventArgs e)
        {
            InsumosCn insumos = new InsumosCn();
            DataGridInsumos.DataContext = insumos.MostrandoInsumos();
        }
        #endregion

        #region CRUD Insumos
        private void btnAgregarInsumo_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Insumos entidadInsumo = new Insumos
            {
                NombreInsumo = tbNombreInsumo.Text,
                CategoriaInsumo = cbCategoriaInsumo.Text,
                CantidadDisponible = tbCantidadDisponible.Text,
                CantidadIdeal = tbCantidadIdeal.Text,
                EstadoInsumos = ComprobarEstado(),
            };

            InsumosCn insumosCn = new InsumosCn();

            if (entidadInsumo.NombreInsumo != "" && entidadInsumo.CategoriaInsumo != "" && entidadInsumo.CantidadDisponible != "" && entidadInsumo.CantidadIdeal != "" && entidadInsumo.EstadoInsumos == true | entidadInsumo.EstadoInsumos == false)
            {
                valorRetorno = insumosCn.AgregandoInsumos(entidadInsumo.NombreInsumo, entidadInsumo.CantidadDisponible, entidadInsumo.CantidadIdeal, entidadInsumo.CategoriaInsumo, entidadInsumo.EstadoInsumos);

                if (valorRetorno != null)
                {
                    MessageBox.Show("El Insumo: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El Insumo: " + entidadInsumo.NombreInsumo + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnActualizarInsumo_Click(object sender, RoutedEventArgs e)
        {
            string categoriaConfirmada;
            Insumos entidadInsumos = new Insumos
            {
                IdInsumo = int.Parse(lbIdInsumo.Content.ToString()),
                NombreInsumo = tbNombreInsumo.Text,
                CantidadDisponible = tbCantidadDisponible.Text,
                CantidadIdeal = tbCantidadIdeal.Text,
                CategoriaInsumo = cbCategoriaInsumo.Text,
                EstadoInsumos = ComprobarEstado(),
                FechaInsumoCambio = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                CantidadInicialCambio = lbCantidadInsumoCambio.Content.ToString(),
                ResposableCambio = lbNombreBodega.Content.ToString()
            };

            InsumosCn insumosCn = new InsumosCn();

            if (entidadInsumos.NombreInsumo != "" && entidadInsumos.CantidadDisponible != "" && entidadInsumos.CantidadIdeal != "" && entidadInsumos.CategoriaInsumo != "")
            {
                categoriaConfirmada = insumosCn.ActualizandoInsumos(entidadInsumos.IdInsumo, entidadInsumos.NombreInsumo, entidadInsumos.CantidadDisponible, entidadInsumos.CantidadIdeal, entidadInsumos.CategoriaInsumo, entidadInsumos.EstadoInsumos);


                if (categoriaConfirmada != null)
                {
                    MessageBox.Show("El insumo: " + lbIdInsumo.Content + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("El insumo: " + lbIdInsumo.Content + " no se pudo ser actualizado con éxito!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("No se puede actualizar un insumo vacio!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
            //Aquí empieza el ingreso del historial luego de actualizarlo
            if (lbCantidadInsumoCambio.Content.ToString() != tbCantidadDisponible.Text)
            {
                HistorialCambios entidadHistorial = new HistorialCambios
                {
                    IdHistorial = int.Parse(lbIdInsumo.Content.ToString()),
                    NombreInsumoHistorial = tbNombreInsumo.Text,
                    CantidadFinalHistorial = int.Parse(tbCantidadDisponible.Text),
                    FechaHistorial = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                    CantidadInicialHistorial = int.Parse(lbCantidadInsumoCambio.Content.ToString()),
                    Responsable = lbNombreBodega.Content.ToString()
                };

                HistorialCambiosCn historialCambiosCn = new HistorialCambiosCn();

                if (entidadInsumos.NombreInsumo != "" && entidadInsumos.CantidadDisponible != "" && entidadInsumos.CantidadIdeal != "" && entidadInsumos.CategoriaInsumo != "")
                {
                    //aquí hay una referencia a insumos en vez de historial (entidades)
                    historialCambiosCn.AgregandoHistorial(entidadInsumos.IdInsumo, entidadInsumos.NombreInsumo, entidadInsumos.CantidadDisponible, entidadInsumos.FechaInsumoCambio, entidadInsumos.CantidadInicialCambio, entidadInsumos.ResposableCambio);
                    Window_Loaded(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("Error: ERR-UPHI-001, Por favor contacte con el Administrador si este error aparece en pantalla.", "Error de Sistema", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            LimpiarDatos();

        }
        #endregion

        #region Ventanas
        private void btnModificarCategorias_Click(object sender, RoutedEventArgs e)
        {
            CrudCategorias ventanaCategorias = new CrudCategorias();
            ventanaCategorias.Owner = this;
            ventanaCategorias.ShowDialog();
        }

        private void btnVentanaProductos_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            GestionProductos gestionProductos = new GestionProductos();
            gestionProductos.Owner = this;
            gestionProductos.ShowDialog();
        }

        private void btnVolverAtras_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MenuBodega menuBodega = new MenuBodega();
            menuBodega.ShowDialog();
        }

        //Ventana Vacia (Falta Construir)
        private void btnVentanaSolicitud_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudLibroRecetas crudLibroRecetas = new CrudLibroRecetas();
            crudLibroRecetas.Owner = this;
            crudLibroRecetas.ShowDialog();
        }
        #endregion

        private void btnHistorialInsumos_Click(object sender, RoutedEventArgs e)
        {
            HistorialInsumos historialInsumos = new HistorialInsumos();
            historialInsumos.Owner= this;
            historialInsumos.ShowDialog();
        }
    }
}
