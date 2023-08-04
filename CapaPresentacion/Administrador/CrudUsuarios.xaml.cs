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
    /// Lógica de interacción para CrudUsuarios.xaml
    /// </summary>
    public partial class CrudUsuarios : Window
    {
        bool estado;
        public CrudUsuarios()
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

        private void btnVentanaClientes_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CrudClientes crudClientes = new CrudClientes();
            crudClientes.Owner = this;
            crudClientes.ShowDialog();
        }
        #endregion

        #region Opciones Ventana

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

        #endregion

        #region CRUD Usuarios
        //Carga la lista al entrar
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UsuariosCn usuarios = new UsuariosCn();
            DataGridUsuarios.DataContext = usuarios.MostrandoUsuarios();
        }

        private void LimpiarDatos()
        {
            lbIdUsuario.Content = "0";
            tbNombreUsuario.Text = string.Empty;
            tbContraseniaUsuario.Text = string.Empty;
            tbCorreoUsuario.Text = string.Empty;
            cbRolesDeUsuarios.Text = string.Empty;
            rbUsuarioActivo.IsChecked = false;
            rbUsuarioInactivo.IsChecked = false;
        }

        public bool ComprobarEstado()
        {

            if (rbUsuarioActivo.IsChecked == true)
            {
                estado = true;
            }
            else if (rbUsuarioInactivo.IsChecked == true)
            {
                estado = false;
            }

            return estado;
        }

        private void btnAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {
            string valorRetorno;
            Usuarios entidadUsuario = new Usuarios
            {
                NombreUsuario = tbNombreUsuario.Text,
                ContraseniaUsuario = tbContraseniaUsuario.Text,
                CorreoUsuario = tbCorreoUsuario.Text,
                RolUsuario = cbRolesDeUsuarios.Text,
                EstadoUsuario = ComprobarEstado(),
            };

            UsuariosCn usuariosLn = new UsuariosCn();

            if (entidadUsuario.NombreUsuario != "" && entidadUsuario.ContraseniaUsuario != "" && entidadUsuario.CorreoUsuario != "" && entidadUsuario.RolUsuario != "" && entidadUsuario.EstadoUsuario == true | entidadUsuario.EstadoUsuario == false)
            {
                valorRetorno = usuariosLn.AgregandoUsuarios(entidadUsuario.NombreUsuario, entidadUsuario.ContraseniaUsuario, entidadUsuario.CorreoUsuario, entidadUsuario.RolUsuario, entidadUsuario.EstadoUsuario);

                if (valorRetorno != null)
                {
                    MessageBox.Show("El Usuario: " + valorRetorno + " ya existe en el sistema. ¡Por favor intente con un nombre distinto!", "Registro Duplicado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El Usuario: " + entidadUsuario.NombreUsuario + " fue ingresado con éxito!", "Registro Completo", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Registro Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        private void DataGridUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid datos = (DataGrid)sender;
            DataRowView filaSeleccionada = datos.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                lbIdUsuario.Content = filaSeleccionada["id_usuario"].ToString();
                tbNombreUsuario.Text = filaSeleccionada["nombre_usuario"].ToString();
                tbContraseniaUsuario.Text = filaSeleccionada["contrasenia_usuario"].ToString();
                tbCorreoUsuario.Text = filaSeleccionada["correo_usuario"].ToString();
                cbRolesDeUsuarios.Text = filaSeleccionada["rol_usuario"].ToString();
                if (filaSeleccionada["estado_tipousuario"].ToString() == "Activo")
                {
                    rbUsuarioActivo.IsChecked = true;
                }
                else
                {
                    rbUsuarioInactivo.IsChecked = true;
                }
            }
        }

        private void btnActualizarUsuario_Click(object sender, RoutedEventArgs e)
        {
            string usuarioConfirmado;
            Usuarios entidadUsuario = new Usuarios
            {
                IdUsuario = int.Parse(lbIdUsuario.Content.ToString()),
                NombreUsuario = tbNombreUsuario.Text,
                ContraseniaUsuario = tbContraseniaUsuario.Text,
                CorreoUsuario = tbCorreoUsuario.Text,
                RolUsuario = cbRolesDeUsuarios.Text,
                EstadoUsuario = ComprobarEstado(),
            };
            UsuariosCn usuariosLn = new UsuariosCn();

            if (entidadUsuario.NombreUsuario != "" && entidadUsuario.ContraseniaUsuario != "" && entidadUsuario.CorreoUsuario != "" && entidadUsuario.RolUsuario != "" && entidadUsuario.EstadoUsuario == true | entidadUsuario.EstadoUsuario == false)
            {
                usuarioConfirmado = usuariosLn.ActualizandoUsuarios(entidadUsuario.IdUsuario, entidadUsuario.NombreUsuario, entidadUsuario.ContraseniaUsuario, entidadUsuario.CorreoUsuario, entidadUsuario.RolUsuario, entidadUsuario.EstadoUsuario);

                if (usuarioConfirmado == null)
                {
                    MessageBox.Show("El usuario: " + lbIdUsuario.Content + " fue actualizado con éxito!", "Registro Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                    Window_Loaded(sender, e);
                    LimpiarDatos();
                }
                else
                {
                    MessageBox.Show("El usuario: " + lbIdUsuario.Content + " no se pudo ser actualizado con éxito!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("No se puede actualizar un usuario vacio!", "Registro No Actualizado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        #endregion
    }
}

