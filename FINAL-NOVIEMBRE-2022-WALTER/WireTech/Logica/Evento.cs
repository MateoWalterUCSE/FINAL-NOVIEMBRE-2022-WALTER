using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Evento
    {
        public string tipo { get; set; }
        public double dinero { get; set; }
        public DateTime fecha { get; set; }
//CORRECCIONES: No es correcto abusar de constructores, si creamos constructores custom tenemos que crear un constructor base
        public Evento(string Tipo, double Dinero, DateTime Fecha)
        {
            tipo = Tipo;
            dinero = Dinero;
            fecha = Fecha;
        }
    }
}
