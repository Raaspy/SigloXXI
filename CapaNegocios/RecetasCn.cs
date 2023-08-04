using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class RecetasCn
    {
        ConexionBD conexion = new ConexionBD();
        //public DataTable MostrandoInsumos()
        //{
        //    return conexion.ConsultandoInsumos();
        //}

        public string AgregandoRecetas(string nombreReceta, string descripcion, bool estado)
        {
            return conexion.AgregarRecetas(nombreReceta, descripcion, estado);
        }

        public string ActualizandoRecetas(int id, string nombreReceta, string descripcionReceta, bool estado)
        {
            return conexion.ActualizarRecetas(id, nombreReceta, descripcionReceta, estado);
        }

        public DataTable MostrandoRecetas()
        {
            return conexion.ConsultandoRecetas();
        }
    }
}
