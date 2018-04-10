using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.-Agregar Sucursal");
                Console.WriteLine("2.-Agregar Accesorios");
                Console.WriteLine("3.-Agregar Vehiculos");
                Console.WriteLine("4.-Agregar Clientes");
                string y = Console.ReadLine();

                if(y=="1")
                {
                    Sucursal s1 = new Sucursal();
                    Console.WriteLine("ingrese el nombre de la sucursal");
                    s1.nombre();
                    Console.WriteLine("ingrese la ubicacion de la sucursal");
                    s1.Ubicacion();

                }

            }
            


        }
    }
}
