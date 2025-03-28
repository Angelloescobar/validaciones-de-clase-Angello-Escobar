using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Bus : Vehiculo
    {
        public int CapacidadPasajeros { get; }
        public int CantidadPasajerosActual { get; private set; }

        public Bus(int anio, string elColor, string elModelo, int capacidadPasajeros) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "B" };
            CapacidadPasajeros = capacidadPasajeros;
            CantidadPasajerosActual = 0;
        }

        public void SubirPasajeros(int cantidad)
        {
            Console.WriteLine("Esta es la cantidad de pasajeros.");
        }

        public void BajarPasajeros(int cantidad)
        {
            Console.WriteLine("Esta es la cantidad de pasajeros.");
        }
    }
}