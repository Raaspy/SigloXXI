using System;

namespace CapaEntidades
{
    public class Insumos
    {
        #region Variables Publicas

        int idInsumo;
        string nombreInsumo;
        string categoriaInsumo;
        string cantidadDisponible;
        string cantidadIdeal;
        bool estadoInsumos;
        DateTime fechaInsumoCambio;
        string cantidadInicialCambio;
        string resposableCambio;
        #endregion

        #region Propiedades

        public int IdInsumo { get => idInsumo; set => idInsumo = value; }
        public string NombreInsumo { get => nombreInsumo; set => nombreInsumo = value; }
        public string CategoriaInsumo { get => categoriaInsumo; set => categoriaInsumo = value; }
        public string CantidadDisponible { get => cantidadDisponible; set => cantidadDisponible = value; }
        public string CantidadIdeal { get => cantidadIdeal; set => cantidadIdeal = value; }
        public bool EstadoInsumos { get => estadoInsumos; set => estadoInsumos = value; }
        public DateTime FechaInsumoCambio { get => fechaInsumoCambio; set => fechaInsumoCambio = value; }
        public string CantidadInicialCambio { get => cantidadInicialCambio; set => cantidadInicialCambio = value; }
        public string ResposableCambio { get => resposableCambio; set => resposableCambio = value; }

        #endregion
    }
}
