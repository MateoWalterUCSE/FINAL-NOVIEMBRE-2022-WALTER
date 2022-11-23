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

        public Evento(string Tipo, double Dinero, DateTime Fecha)
        {
            tipo = Tipo;
            dinero = Dinero;
            fecha = Fecha;
        }
    }
}
