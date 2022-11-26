using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Entidad
    {
        //CORRECCIONES: Esto va en un archivo aparte
        public enum ZonasPais
        {
            Cuyo,
            Norte,
            Centro,
            Patagonia,
        }
        public int codigoEntidad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        //CORRECCIONES: Hay que guardar el dia de vencimiento, no la fecha
        public DateTime vencimiento { get; set; }
        public int codigoProveedor { get; set; }
        ////CORRECCIONES: Esto se resuelve por herencia, no lo necesitas como propiedad
        public string categoria { get; set; }

        //CORRECCIONES: No es correcto abusar de constructores, si creamos constructores custom tenemos que crear un constructor base
        public Entidad(int CodigoEntidad, string Nombre, string Descripcion, DateTime Vencimiento, int CodigoProveedor, string Categoria)
        {
            codigoEntidad = CodigoEntidad;
            nombre = Nombre;
            descripcion = Descripcion;
            vencimiento = Vencimiento;
            codigoProveedor = CodigoProveedor;
            categoria = Categoria;
        }
    }
}
