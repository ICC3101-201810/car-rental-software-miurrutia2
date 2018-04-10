using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        String Licencia;
        private Vehiculo licencia;
        Vehiculo vehiculo;
        String TipoLicencia;
        private Vehiculo tipolicencia;

        public Persona(string licencia, Vehiculo vehiculo, string tipoLicencia, Vehiculo tipolicencia)
        {
            Licencia = licencia;
            this.vehiculo = vehiculo;
            TipoLicencia = tipoLicencia;
            this.tipolicencia = tipolicencia;
        }
        public bool RevisarLicencia()
        {
            if(licencia == tipolicencia)
            {
                return true;
            }
            return false;
        }
    }
}
