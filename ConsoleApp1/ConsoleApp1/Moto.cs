using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Moto : Vehiculo
    {
        public Moto(int año, string modelo, string marca, int precio) : base(año, modelo, marca, precio)
        {
        }
    }
}
