using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        public int Carga { get; private set; }
        public int CargaMaxima { get; }

        public Camion(int anio, string elColor, string elModelo, int cargaMaxima) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
            CargaMaxima = cargaMaxima;
            Carga = 0;
        }

        public void Cargar(int cantidad)
        {
            Console.WriteLine("Esta es la cantidad de carga.");
        }

        public void Descargar(int cantidad)
        {
            Console.WriteLine("Esta es la cantidad de carga.");
        }

        public override void acelerar(int cuanto)
        {
            Console.WriteLine("El trailer acelera con -3 de decremento.");
        }
    }
}