using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class InsumosCn
    {
        ConexionBD conexion = new ConexionBD();

        #region Insumos
        public DataTable MostrandoInsumos()
        {
            return conexion.ConsultandoInsumos();
        }

        public string AgregandoInsumos(string nombreInsumo, string cantidadDisponible, string cantidadIdeal, string categoria, bool estado)
        {
            return conexion.AgregarInsumos(nombreInsumo, cantidadDisponible, cantidadIdeal, categoria, estado);
        }

        public string ActualizandoInsumos(int id, string nombreInsumo, string cantidadDisponible, string cantidadIdeal, string categoria, bool estado)
        {
            return conexion.ActualizarInsumos(id, nombreInsumo, cantidadDisponible, cantidadIdeal, categoria, estado);
        }

        #endregion

        #region Categoria Insumos
        public List<string> ConsultandoCategorias()
        {
            return conexion.ConsultarCategorias();
        }

        public DataTable MostrandoCategoriaInsumos()
        {
            return conexion.ConsultandoCategoriaInsumos();
        }

        public string AgregandoCategoria(string nombreCategoria, bool estado)
        {
            return conexion.AgregarCategoria(nombreCategoria, estado);
        }

        public string ActualizandoCategoria(string nombreCategoria, string categoriaAnterior, bool estado)
        {
            return conexion.ActualizarCategoria(nombreCategoria, categoriaAnterior, estado);
        }
        #endregion

    }
}
