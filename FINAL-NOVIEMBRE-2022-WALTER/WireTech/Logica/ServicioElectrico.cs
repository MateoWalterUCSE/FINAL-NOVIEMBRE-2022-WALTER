using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioElectrico : Entidad
    {
        public int porcentajeImpuestos { get; set; }
        public ZonasPais Zona { get; set; }

        public ServicioElectrico(int CodigoEntidad, string Nombre, string Descripcion, DateTime Vencimiento, int CodigoProveedor, string Categoria, int PorcentajeImpuestos, string Zona)
            : base (CodigoEntidad, Nombre, Descripcion, Vencimiento, CodigoProveedor, Categoria)
        {
            codigoEntidad = CodigoEntidad;
            nombre = Nombre;
            descripcion = Descripcion;
            vencimiento = Vencimiento;
            codigoProveedor = CodigoProveedor;
            categoria = Categoria;
            porcentajeImpuestos = PorcentajeImpuestos;
            zona = Zona;
        }
    }
}
