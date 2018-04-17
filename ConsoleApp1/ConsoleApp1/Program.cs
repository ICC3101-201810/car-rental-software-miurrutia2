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
                Console.WriteLine("Hola, bienvenido");
                Console.WriteLine("1.-Arrendar Vehiculo");
                Console.WriteLine("2.-Recibir Vehiculo");
                Console.WriteLine("3.-Salir");
                string y = Console.ReadLine();

                if (y == "1")
                {

                    Console.WriteLine("ingrese el nombre del cliente");
                    string cliente1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el año del vehiculo");
                    int año1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el modelo");
                    string modelo1 = Console.ReadLine();
                    Console.WriteLine("Ingrese la marca");
                    string marca1 = Console.ReadLine();
                    Console.WriteLine("ingrese el precio");
                    int precio1 = Convert.ToInt32(Console.ReadLine());
                    Vehiculo V1 = new Vehiculo(año1, modelo1, marca1, precio1);
                    Console.WriteLine("Ingrese la fecha de arriendo");
                    DateTime fechai = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("ingrese Fecha de entrega");
                    DateTime fechaf = Convert.ToDateTime(Console.ReadLine());
                    Arriendo A1 = new Arriendo(cliente1, V1,fechai, fechaf);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Beep();
                    Console.WriteLine("Arriendo fue ingresado");
                }

                else if (y == "2")
                {
                    List<Vehiculo> vehiculo1 = new List<Vehiculo>();
                    Console.WriteLine("Ingrese el año del vehiculo");
                    int año1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el modelo");
                    string modelo1 = Console.ReadLine();
                    Console.WriteLine("Ingrese la marca");
                    string marca1 = Console.ReadLine();
                    Console.WriteLine("ingrese el precio");
                    int precio1 = Convert.ToInt32(Console.ReadLine());
                    Vehiculo V1 = new Vehiculo(año1, modelo1, marca1, precio1);
                    
                    foreach (Vehiculo vehiculo in vehiculo1)
                    {
                        if (V1 != vehiculo1[vehiculo])
                        {
                            vehiculo1.Add(V1);
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Beep();
                            Console.WriteLine("El vehiculo fue ingresado");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Beep();
                            Console.Beep();
                            Console.WriteLine("Vehiculo fue ingresado anteriormente");
                        }
                    }
                    
                }
                else if (y == "3")
                {
                    break;
                }
            }


        }
    }
}
