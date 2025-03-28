using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Chofer : IPiloto
    {
        public string Nombre { get ; set; }
        public int Edad { get ; set; }
        public string TipoLicencia { get ; set; }

        public Chofer(string name, int LaEdad, string LicenciaT)
        {
            Nombre = name;
            Edad = LaEdad;
            TipoLicencia = LicenciaT;
        }

        public void mostrarInformacion()
        {
            Console.WriteLine("El piloto es {0}",Nombre);
            Console.WriteLine("Licencia tipo {0}",TipoLicencia);
            
        }
    }
}
