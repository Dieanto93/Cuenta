using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Ejecucion
    {
        public static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.setNombre("Wilson");
            persona.setApellido("Coronel");
            persona.setEdad(29);
            persona.setIdentificacion("1724525801");
            persona.ImprimirDatos();
            Persona persona2 = new Persona();
            persona2.setNombre("Marco Vinicio");
            persona2.setApellido("Cevallos");
            persona2.setEdad(44);
            persona2.setIdentificacion("171661445");
            persona2.ImprimirDatos();

        }
    }
}
