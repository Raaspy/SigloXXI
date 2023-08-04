using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Recetas
    {
        int idRecetas;
        string nombreReceta;
        string descripcionReceta;
        bool estado;

        public int IdRecetas { get => idRecetas; set => idRecetas = value; }
        public string NombreReceta { get => nombreReceta; set => nombreReceta = value; }
        public string DescripcionReceta { get => descripcionReceta; set => descripcionReceta = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
