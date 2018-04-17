using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arriendo
    {
        String cliente;
        Vehiculo vehiculo;
        Accesorios accesorio;
        DateTime fechaInicio;
        DateTime fechaFinal;

        public Arriendo(string cliente, Vehiculo vehiculo, DateTime fechaInicio, DateTime fechaFinal)
        {
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            
        }
        public void Rent(Cliente cliente, Vehiculo vehiculo, Accesorios accesorios, DateTime fechaInicio, DateTime fechaFinal)
        {
            int costo = Accesorios.precio + Vehiculo.precio;
        }

    }
}
