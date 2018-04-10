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
        Sucursal sucursal;
        Accesorios accesorio;
        DateTime fechaInicio;
        DateTime fechaFinal;
        int Total;

        public Arriendo(Cliente cliente, Vehiculo vehiculo, Sucursal sucursal, Accesorios accesorio, DateTime fechaInicio, DateTime fechaFinal, int total)
        {
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.accesorio = accesorio;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            Total = total;
        }
        public void Rent(Sucursal sucursal, Cliente cliente, Vehiculo vehiculo, Accesorios accesorios, DateTime fechaInicio, DateTime fechaFinal)
        {
            int costo = Accesorios.precio + Vehiculo.precio;
        }

    }
}
