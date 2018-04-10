using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculo
    {
        internal static int precio;
        int año;
        String Modelo;
        String Marca;
        int Precio;

        public Vehiculo(int año, string modelo, string marca, int precio)
        {
            this.año = año;
            Modelo = modelo;
            Marca = marca;
            Precio = precio;
        }
    }
}
