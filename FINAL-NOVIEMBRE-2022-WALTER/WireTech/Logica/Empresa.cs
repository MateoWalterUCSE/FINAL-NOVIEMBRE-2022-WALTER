using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Empresa
    {
        List<Entidad> Entidades = new List<Entidad>();
        List<Cliente> Clientes = new List<Cliente>();
        List<Pago> Pagos = new List<Pago>();
        List<Proveedor> Proveedores = new List<Proveedor>();

        //Ejercicio 1
        public void CargarCliente(int Dni, string Nombre, string Apellido, DateTime FechaNacimiento)
        {
            int Nivel = ValidarNivelUsuario(Dni);
            Cliente NuevoCliente = new Cliente(Dni, Nombre, Apellido, FechaNacimiento, Nivel);
            Clientes.Add(NuevoCliente);
        }
        public int ValidarNivelUsuario(int Dni)
        {
            int Nivel = 0;
            int CantidadEntidadesRegistradas = 0;
            //CORRECCIONES: En este código se repiten las entidades si pagó mas de una vez una entidad
            foreach (Pago pago in Pagos)
            {
                if (pago.dni == Dni)
                {
                    foreach (Entidad entidad in Entidades)
                    {
                        if (entidad.codigoEntidad == pago.codigoEntidad)
                        {
                            CantidadEntidadesRegistradas++;
                        }
                    }
                }
            }
            if (CantidadEntidadesRegistradas > 0 && CantidadEntidadesRegistradas <= 3)
            {
                Nivel = 1;
            }
            else if (CantidadEntidadesRegistradas > 3)
            {
                Nivel = 2;
            }
            return Nivel;
        }
        //Ejercicio 2
        public void CargarEntidad(string Nombre, string Descripcion, int CodigoProveedor, string Categoria)
        {
            int CodigoEntidad = Entidades.Count + 1;
            //CORRECCIONES: INCORRECTO. Esto debe resolverse por abstracción, utilizando la herencia realizada.
            switch (Categoria)
            {
                case "Servicios Eléctricos":
                    ServicioElectrico NuevaEntidadServiciosElectricos = new ServicioElectrico(CodigoEntidad, Nombre, Descripcion, Vencimiento, CodigoProveedor, Categoria);
                    Entidades.Add(NuevaEntidadServiciosElectricos);
                    break;
                case "Comunicación":
                    Comunicacion NuevaEntidadComunicacion = new Comunicacion(CodigoEntidad, Nombre, Descripcion, Vencimiento, CodigoProveedor, Categoria);
                    Entidades.Add(NuevaEntidadComunicacion);
                    break;
                default:
                    Entidad NuevaEntidad = new Entidad(CodigoEntidad, Nombre, Descripcion, Vencimiento, CodigoProveedor, Categoria);
                    Entidades.Add(NuevaEntidad);
                    break;
            }
        }
        //Ejercicio 3
        public void CargarPago(int Dni, int CodigoEntidad, int Monto)
        {
            int Nivel = ValidarNivelUsuario(Dni);
            //CORRECCIONES: No es la carga del pago, es la carga a la agenda, todavía no hay pago.
            DateTime FechaPago = DateTime.Today;
            DateTime FechaCreacion = DateTime.Today;
            Pago NuevoPago = new Pago(Dni, CodigoEntidad, FechaCreacion, FechaPago, Monto);
        }
        //Ejercicio 4
        public List<string> Reporte(Proveedor.Paises Pais)
        {
            List<string> DevolverReportes = new List<string>();
            for (int i = 0; i < Entidades.Count; i++)
            {
                string NuevoReporte = "La entidad " + Entidades[i].nombre + "está gestionada por ";
                for (int x = 0; x < Proveedores.Count; x++)
                {
                    //CORRECCIONES: Estas agregando todos los proveedores, solo tenes que agregar el proveedor de esa entidad.
                    NuevoReporte += Proveedores[x].nombre;
                }
                DevolverReportes.Add(NuevoReporte);
            }
            return DevolverReportes;
        }
        //Ejercicio 5
        public void BuscarUltimoRegistroNoPagado(int Dni, int CodigoEntidad)
        {
            int UltimoRegistroPosicion = 0;
            DateTime UltimoRegistroValor = DateTime.Today;

            //CORRECCIONES: No es para nada optimo, vimos muchas herramientas para mejroar esto.
            for (int i = 0; i < Pagos.Count; i++)
            {
                if(Pagos[i].dni == Dni && Pagos[i].codigoEntidad == CodigoEntidad)
                {
                    if (i == 0)
                    {
                        UltimoRegistroPosicion = i;
                        UltimoRegistroValor = Pagos[i].fechaCreacion;
                    }
                    else
                    {
                        if (Pagos[i].fechaCreacion < UltimoRegistroValor)
                        {
                            UltimoRegistroPosicion = i;
                            UltimoRegistroValor = Pagos[i].fechaCreacion;
                        }
                    }
                }
            }
            Pagos[UltimoRegistroPosicion].fechaPago = DateTime.Today;
            for (int i = 0; i < Entidades.Count; i++)
            {
                if(Entidades[i].codigoEntidad == Pagos[UltimoRegistroPosicion].codigoEntidad)
                {
                    for (int x = 0; x < Proveedores.Count; x++)
                    {
                        if(Proveedores[x].codigo == Entidades[i].codigoProveedor)
                        {
                            //CORRECCIONES: El proveedor deberia recibir un evento, agregarlo y calcular el saldo (comentario en la clase proveedor)
                            Proveedores[x].saldo += Pagos[UltimoRegistroPosicion].monto;
                            string Tipo = "Pago";
                            DateTime FechaEvento = DateTime.Today;
                            Evento NuevoEvento = new Evento(Tipo, Pagos[UltimoRegistroPosicion].monto ,FechaEvento);

                            Proveedores[x].eventos.Add(NuevoEvento);
                            break;
                        }
                    }
                }
            }
        }
    }
}
