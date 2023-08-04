using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Mesas
    {
        int idMesa;
        int numeroMesa;
        bool estadoMesa;

        public int IdMesa { get => idMesa; set => idMesa = value; }
        public int NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
        public bool EstadoMesa { get => estadoMesa; set => estadoMesa = value; }
    }
}
