using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona: Vehiculo
    {
        String Licencia;
        private string licencia;
        Vehiculo vehiculo;
        String TipoLicencia;
        private Vehiculo tipolicencia;

        public Persona(string licencia, Vehiculo vehiculo, string tipoLicencia)
        {
            Licencia = licencia;
            this.vehiculo = vehiculo;
            TipoLicencia = tipoLicencia;
        }
        public String licencias
        {
            get { return licencia; }
            set
            {
                if (tipolicencia == vehiculo)
                licencia = vehiculo;
            }
        }
    }
}
