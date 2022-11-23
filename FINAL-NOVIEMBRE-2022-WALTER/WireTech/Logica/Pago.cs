using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pago
    {
        public int dni { get; set; }
        public int codigoEntidad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaPago { get; set; }
        public int monto { get; set; }
        public Pago(int Dni, int CodigoEntidad, DateTime FechaCreacion, DateTime FechaPago, int Monto)
        {
            dni = Dni;
            codigoEntidad = CodigoEntidad;
            fechaCreacion = FechaCreacion;
            fechaPago = FechaPago;
            monto = Monto;
        }
    }
}
