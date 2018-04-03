using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Accesorios
    {
        public enum accesorios
        {
            RadioBluetooth,
            Gps,
            RuedasRepuesto,
            CortinasVentanas,
            SillasInfantiles
        }
        static void main()
        {
            accesorios tipos = accesorios.RadioBluetooth | accesorios.Gps | accesorios.RuedasRepuesto | accesorios.CortinasVentanas | accesorios.SillasInfantiles;

            Console.WriteLine(tipos);
            Console.ReadKey();

        }

    }
}
