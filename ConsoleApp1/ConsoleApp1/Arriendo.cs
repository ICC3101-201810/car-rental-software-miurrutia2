using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arriendo
    {
        Cliente cliente;
        Vehiculo vehiculo;
        Accesorios accesorio;
        DateTime fecha;
        int Total;

        public Arriendo(Cliente cliente, Vehiculo vehiculo, Accesorios accesorio, DateTime fecha, int total)
        {
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.accesorio = accesorio;
            this.fecha = fecha;
            Total = total;
        }
        public Cliente clientes
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Vehiculo vehiculos
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }
        public Accesorios accesorios
        {
            get { return accesorio; }
            set { accesorio = value; }
        }
        public DateTime fechas
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
