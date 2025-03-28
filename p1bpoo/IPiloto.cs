using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo
{
    internal interface IPiloto
    {
        string Nombre { get; set; }

        int Edad { get; set; }

        String TipoLicencia { get; set; } // a,b,c,m

        void mostrarInformacion();
    }
}
