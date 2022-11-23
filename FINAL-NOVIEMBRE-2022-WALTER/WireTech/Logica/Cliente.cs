using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int nivel { get; set; }

        public Cliente(int Dni, string Nombre, string Apellido, DateTime FechaNacimiento, int Nivel)
        {
            dni = Dni;
            nombre = Nombre;
            apellido = Apellido;
            fechaNacimiento = FechaNacimiento;
            nivel = Nivel;
        }
    }
}
