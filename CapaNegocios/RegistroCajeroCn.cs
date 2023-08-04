using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class RegistroCajeroCn
    {
        ConexionBD conexion = new ConexionBD();

        public string AgregandoInformacionDeCajero(string nombreCajero, int montoInicial,int montoFinal, DateTime fechaApertura)
        {
            return conexion.AgregarInformacionDeCajero(nombreCajero, montoInicial, montoFinal, fechaApertura);
        }

        public string FinalizandoInformacionDeCajero(string nombreCajero, int montoFinal, DateTime fechaCierre)
        {
            return conexion.FinalizarInformacionDeCajero(nombreCajero, montoFinal, fechaCierre);
        }

        public string CargandoMontoPago(int montoActualizar)
        {
            return conexion.CargarMontoPago(montoActualizar);
        }

        public List<string> ConsultandoMesas()
        {
            return conexion.ConsultarMesas();
        }

        public DataTable MostrandoProdutosComprandos(string numeroMesa)
        {
            return conexion.ConsultandoProdutosComprados(numeroMesa);
        }
    }
}
