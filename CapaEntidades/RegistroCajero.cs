using System;

namespace CapaEntidades
{
    public class RegistroCajero
    {
        string nombreCajero; //Hace referencia al id que se almacena en la bd, pero se convierte dentro del SP de la base de datos.
        int montoInicial;
        int montoFinal;
        string numeroMesa;
        DateTime fechaApertura;
        DateTime fechaCierre;

        public string NombreCajero { get => nombreCajero; set => nombreCajero = value; }
        public int MontoInicial { get => montoInicial; set => montoInicial = value; }
        public int MontoFinal { get => montoFinal; set => montoFinal = value; }
        public string NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
        public DateTime FechaApertura { get => fechaApertura; set => fechaApertura = value; }
        public DateTime FechaCierre { get => fechaCierre; set => fechaCierre = value; }
        
    }
}
