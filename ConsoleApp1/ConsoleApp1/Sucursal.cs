using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sucursal
    {
        public String Nombre;
        List<Cliente> cliente;
        List<Vehiculo> vehiculo;
        List<Accesorios> accesorios;
        public String ubicacion;

        public Sucursal(string nombre, List<Cliente> cliente, List<Vehiculo> vehiculo, List<Accesorios> accesorios, string ubicacion)
        {
            Nombre = nombre;
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.accesorios = accesorios;
            this.ubicacion = ubicacion;
        }

        public Sucursal()
        {
        }

        public void nombre()
        {
            Nombre = Console.ReadLine();
        }
        public void Ubicacion()
        {
            ubicacion = Console.ReadLine();
        }
    }
}
