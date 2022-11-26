using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Proveedor
    {
        public enum Paises
        {
            Argentina,
            Brasil,
            Mexico,
        }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public double saldo { get; set; }
        public List<Evento> eventos { get; set; }
        public Proveedor(int Codigo, string Nombre, double Saldo, List<Evento> Evento)
        {
            codigo = Codigo;
            nombre = Nombre;
            saldo = Saldo;
            eventos = Evento;
        }

        
//CORRECCIONES: Se necesita un método para agregar eventos y que sea este metodo el que calcule el saldo
    }
}
