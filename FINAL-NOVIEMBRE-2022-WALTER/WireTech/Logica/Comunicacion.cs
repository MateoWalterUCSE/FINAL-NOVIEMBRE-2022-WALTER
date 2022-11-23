using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comunicacion : Entidad
    {
        public ZonasPais zona { get; set; }

        public Comunicacion(int CodigoEntidad, string Nombre, string Descripcion, DateTime Vencimiento, int CodigoProveedor, string Categoria, string Zona)
            : base(CodigoEntidad, Nombre, Descripcion, Vencimiento, CodigoProveedor, Categoria)
        {
            codigoEntidad = CodigoEntidad;
            nombre = Nombre;
            descripcion = Descripcion;
            vencimiento = Vencimiento;
            codigoProveedor = CodigoProveedor;
            categoria = Categoria;
            zona = Zona;
        }
    }
}
