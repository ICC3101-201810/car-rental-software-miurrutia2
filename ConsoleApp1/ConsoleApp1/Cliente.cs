using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cliente:Persona
    {
        Persona persona;
        String Empresa;
        String Organizacion;
        String Institucion;
        String Licencia;

        public Cliente(Persona persona, string licencia, Vehiculo vehiculo, string tipoLicencia, string empresa, string organizacion, string institucion) : base(licencia, vehiculo, tipoLicencia)
        {
            this.persona = persona;
            Empresa = empresa;
            Organizacion = organizacion;
            Institucion = institucion;
            Licencia = licencia;
        }
    }
}
