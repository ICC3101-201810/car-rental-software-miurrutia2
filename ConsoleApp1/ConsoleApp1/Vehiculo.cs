using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculo
    {
        public enum Tipos
        {
            Auto,
            Acuatico,
            Moto,
            Camion,
            Bus,
            MaquinariaPesada,
        }
        static void main()
        {
            Tipos tipos = Tipos.Auto | Tipos.Acuatico | Tipos.Moto | Tipos.Camion | Tipos.Bus | Tipos.MaquinariaPesada;

            Console.WriteLine(tipos);
            Console.ReadKey();

        }

        public static implicit operator string(Vehiculo v)
        {
            throw new NotImplementedException();
        }
    }
}
