using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos
{
    public class ConexionBD
    {
        #region Conexiones BD
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost"; 
        static string bd = "restaurantxxi";
        static string usuario = "root";
        static string password = "root";

        string cadenaConexion = "Database=" + bd +
            "; Data Source=" + servidor +
            "; User Id=" + usuario +
            "; Password=" + password + "";

        public MySqlConnection EstableciendoConexionBD()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                Console.WriteLine("Conexion Correcta");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            return conexion;
        }

        public void CerrarConexionBD()
        {
            conexion.Close();
            Console.WriteLine("Conexion Cerrada");
        }
        #endregion

        #region Login y CRUD Usuarios
        public string ConsultaLogin(string usuario, string contrasenia)
        {
            string rol;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_LoginUsuarios", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_usuario", usuario);
                cmd.Parameters.AddWithValue("_contrasenia", contrasenia);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    rol = dr.GetString(0);
                    return rol;
                }
                CerrarConexionBD();

            }
            catch (MySqlException ex)
            {
                System.Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public DataTable ConsultandoUsuarios()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarUsuarios", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarUsuario(string usuario, string contrasenia, string correo, string rol, bool estado)
        {
            string nombre;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarUsuario", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_usuario", usuario);
                cmd.Parameters.AddWithValue("_contrasenia", contrasenia);
                cmd.Parameters.AddWithValue("_correo", correo);
                cmd.Parameters.AddWithValue("_rol", rol);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    nombre = dr.GetString(0);
                    return nombre;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                System.Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarUsuario(int id, string usuario, string contrasenia, string correo, string rol, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarUsuario", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_id", id);
                cmd.Parameters.AddWithValue("_usuario", usuario);
                cmd.Parameters.AddWithValue("_contrasenia", contrasenia);
                cmd.Parameters.AddWithValue("_correo", correo);
                cmd.Parameters.AddWithValue("_rol", rol);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Insumos

        public DataTable ConsultandoInsumos()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarInsumos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public List<string> ConsultarCategorias()
        {
            try
            {
                List<string> lista = new List<string>();
                string dato;
                MySqlCommand cmd = new MySqlCommand("SELECT categoria FROM categoriainsumos", EstableciendoConexionBD());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dato = reader.GetString("categoria");
                    lista.Add(dato);
                }
                CerrarConexionBD();
                return lista;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        } //este esta obsoleto!

        public string AgregarInsumos(string nombreInsumo, string cantidadDisponible, string cantidadIdeal, string categoria, bool estado)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarInsumos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombre", nombreInsumo);
                cmd.Parameters.AddWithValue("_categoria", categoria);
                cmd.Parameters.AddWithValue("_cantidadDisponible", cantidadDisponible);
                cmd.Parameters.AddWithValue("_cantidadIdeal", cantidadIdeal);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarInsumos(int id, string nombreInsumo, string cantidadDisponible, string cantidadIdeal, string categoria, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarInsumos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_id", id);
                cmd.Parameters.AddWithValue("_nombreInsumo", nombreInsumo);
                cmd.Parameters.AddWithValue("_cantidadDisponible", cantidadDisponible);
                cmd.Parameters.AddWithValue("_cantidadIdeal", cantidadIdeal);
                cmd.Parameters.AddWithValue("_categoria", categoria);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region Historial Insumos
        public DataTable ConsultandoHistorialInsumos()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarHistorialCambios", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarHistorial(int id, string nombreInsumo, string cantidadDisponible, DateTime fechaCambio, string cantidadInicialCambio, string responsableCambio)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarHistorial", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_id", id);
                cmd.Parameters.AddWithValue("_nombreInsumo", nombreInsumo);
                cmd.Parameters.AddWithValue("_cantidadDisponible", cantidadDisponible);
                cmd.Parameters.AddWithValue("_fechaCambio", fechaCambio);
                cmd.Parameters.AddWithValue("_cantidadInicial", cantidadInicialCambio);
                cmd.Parameters.AddWithValue("_responsable", responsableCambio);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        #endregion

        #region CRUD Categorias de Insumos

        public DataTable ConsultandoCategoriaInsumos()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarCategoriaInsumos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarCategoria(string nombreCategoria, bool estado)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarCategoria", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombre", nombreCategoria);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarCategoria(string nombreCategoria, string categoriaAnterior, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarCategoria", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombreCategoria", nombreCategoria);
                cmd.Parameters.AddWithValue("_categoriaAnterior", categoriaAnterior);
                cmd.Parameters.AddWithValue("_estado", estado);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Productos
        public DataTable ConsultandoProductos()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarProductos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public List<string> ConsultarCategoriasProductos()
        {
            try
            {
                List<string> lista = new List<string>();
                string dato;
                MySqlCommand cmd = new MySqlCommand("SELECT nombre_tipoproducto FROM tipoproducto", EstableciendoConexionBD());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dato = reader.GetString("nombre_tipoproducto");
                    lista.Add(dato);
                }
                CerrarConexionBD();
                return lista;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarProductos(string nombreProducto, int precio, string urlImagen, bool estado, string tipoProducto)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarProductos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombre", nombreProducto);
                cmd.Parameters.AddWithValue("_precio", precio);
                cmd.Parameters.AddWithValue("_urlImagen", urlImagen);
                cmd.Parameters.AddWithValue("_estado", estado);
                cmd.Parameters.AddWithValue("_tipoProducto", tipoProducto);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarProductos(int id, string nombreProducto, int precio, string urlImagen, bool estado, string tipoProducto)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarProductos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_id", id);
                cmd.Parameters.AddWithValue("_nombre", nombreProducto);
                cmd.Parameters.AddWithValue("_precio", precio);
                cmd.Parameters.AddWithValue("_urlImagen", urlImagen);
                cmd.Parameters.AddWithValue("_estado", estado);
                cmd.Parameters.AddWithValue("_tipoProducto", tipoProducto);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Categorias de Productos
        public DataTable ConsultandoCategoriaProductos()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarCategoriaProductos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarCategoriaProducto(string nombreCategoria, bool estado)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarCategoriaProducto", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombre", nombreCategoria);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarCategoriaProducto(string nombreCategoria, string categoriaAnterior, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarCategoriaProducto", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombreCategoria", nombreCategoria);
                cmd.Parameters.AddWithValue("_categoriaAnterior", categoriaAnterior);
                cmd.Parameters.AddWithValue("_estado", estado);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Proveedores
        public DataTable ConsultandoProveedores()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarProveedores", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarProveedores(string rutProveedor, string nombreProveedor, string tipoProveedor, string contactoProveedor, bool estado)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarProveedor", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_rut", rutProveedor);
                cmd.Parameters.AddWithValue("_nombre", nombreProveedor);
                cmd.Parameters.AddWithValue("_tipoProveedor", tipoProveedor);
                cmd.Parameters.AddWithValue("_contacto", contactoProveedor);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarProveedores(int id, string rutProveedor, string nombreProveedor, string tipoProveedor, string contactoProveedor, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarProveedores", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_id", id);
                cmd.Parameters.AddWithValue("_rut", rutProveedor);
                cmd.Parameters.AddWithValue("_nombre", nombreProveedor);
                cmd.Parameters.AddWithValue("_tipoProveedor", tipoProveedor);
                cmd.Parameters.AddWithValue("_contacto", contactoProveedor);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Mesas
        public DataTable ConsultandoMesas()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarMesas", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarMesas(int numeroMesa, bool estado)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarMesas", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_numeroMesa", numeroMesa);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarMesas(int id, int numeroMesa, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarMesas", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_id", id);
                cmd.Parameters.AddWithValue("_numeroMesa", numeroMesa);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region Paneles Cocina/Garzón
        public DataTable ConsultandoPedidosCocina()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarPedidosCocina", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public DataTable ConsultandoPedidosGarzon()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarPedidosGarzon", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarEstadoCocina(string numeroMesa, bool estado, string nombreProducto)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarEstadoCocina", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_producto", nombreProducto);
                cmd.Parameters.AddWithValue("_numeroMesa", numeroMesa);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarEstadoGarzon(string numeroMesa, bool estado, string nombreProducto)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarEstadoGarzon", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_producto", nombreProducto);
                cmd.Parameters.AddWithValue("_numeroMesa", numeroMesa);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region Registro Cajero/Ventas
        public string AgregarInformacionDeCajero(string nombreCajero, int montoInicial, int montoFinal, DateTime fechaApertura)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_RegistrarApertura", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_usuario", nombreCajero);
                cmd.Parameters.AddWithValue("_montoInicial", montoInicial);
                cmd.Parameters.AddWithValue("_montoFinal", montoFinal);
                cmd.Parameters.AddWithValue("_fechaApertura", fechaApertura);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }

                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string FinalizarInformacionDeCajero(string nombreCajero, int montoFinal, DateTime fechaCierre)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_TerminarApertura", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_usuario", nombreCajero);
                cmd.Parameters.AddWithValue("_montoFinal", montoFinal);
                cmd.Parameters.AddWithValue("_fechaCierre", fechaCierre);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string CargarMontoPago(int montoActualizar)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_RealizarPagoCajero", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_montoActualizar", montoActualizar);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public List<string> ConsultarMesas()
        {
            try
            {
                List<string> lista = new List<string>();
                string dato;
                MySqlCommand cmd = new MySqlCommand("SELECT numero_mesa FROM mesa;", EstableciendoConexionBD());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dato = reader.GetString("numero_mesa");
                    lista.Add(dato);
                }
                CerrarConexionBD();
                return lista;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public DataTable ConsultandoProdutosComprados(string numeroMesa)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarListaPedidos", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_numeroMesa", numeroMesa);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                CerrarConexionBD();

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region Registro Ventas
        public string AgregarVenta(string claveTransaccion, DateTime fechaVenta, int totalVenta, string estadoVenta, string tipoPago)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarVenta", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_claveTransaccion", claveTransaccion);
                cmd.Parameters.AddWithValue("_fechaVenta", fechaVenta);
                cmd.Parameters.AddWithValue("_totalVenta", totalVenta);
                cmd.Parameters.AddWithValue("_estadoVenta", estadoVenta);
                cmd.Parameters.AddWithValue("_tipoPago", tipoPago);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string EliminarVentaPanel()
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_EliminarVentaUsuario", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ConsultarTotalVenta()
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_TraerMontoTotalCaja", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Clientes
        public DataTable ConsultandoClientes()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarClientes", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string AgregarCliente(string nombreCliente, string apellidoCliente, string rut, string telefono, string correo)
        {
            string nombre;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarCliente", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombre", nombreCliente);
                cmd.Parameters.AddWithValue("_apellido", apellidoCliente);
                cmd.Parameters.AddWithValue("_rut", rut);
                cmd.Parameters.AddWithValue("_telefono", telefono);
                cmd.Parameters.AddWithValue("_correo", correo);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    nombre = dr.GetString(0);
                    return nombre;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                System.Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarCliente(int idCliente, string nombreCliente, string apellidoCliente, string rut, string telefono, string correo)
        {
            string nombre;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarCliente", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_idCliente", idCliente);
                cmd.Parameters.AddWithValue("_nombre", nombreCliente);
                cmd.Parameters.AddWithValue("_apellido", apellidoCliente);
                cmd.Parameters.AddWithValue("_rut", rut);
                cmd.Parameters.AddWithValue("_telefono", telefono);
                cmd.Parameters.AddWithValue("_correo", correo);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    nombre = dr.GetString(0);
                    return nombre;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                System.Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion

        #region CRUD Recetas
        public string AgregarRecetas(string nombreReceta, string descripcion, bool estado)
        {
            string valorRetorno;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_AgregarReceta", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_nombreReceta", nombreReceta);
                cmd.Parameters.AddWithValue("_descripcion", descripcion);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    valorRetorno = dr.GetString(0);
                    return valorRetorno;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }

        public string ActualizarRecetas(int id, string nombreReceta, string descripcionReceta, bool estado)
        {
            string dato;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ActualizarReceta", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_idReceta", id);
                cmd.Parameters.AddWithValue("_nombreReceta", nombreReceta);
                cmd.Parameters.AddWithValue("_descripcion", descripcionReceta);
                cmd.Parameters.AddWithValue("_estado", estado);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dato = dr.GetString(0);
                    return dato;
                }
                CerrarConexionBD();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
            
        }

        public DataTable ConsultandoRecetas()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_MostrarRecetas", EstableciendoConexionBD());
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error BD: {0}", ex.Message);
                CerrarConexionBD();
            }
            return null;
        }
        #endregion
    }
}