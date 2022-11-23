using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Entidad
    {
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
        public DateTime vencimiento { get; set; }
        public int codigoProveedor { get; set; }
        public string categoria { get; set; }
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
