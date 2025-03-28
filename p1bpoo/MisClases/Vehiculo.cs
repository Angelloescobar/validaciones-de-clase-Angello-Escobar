using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;

        //atributos nuevos
        protected List<string> tiposLicenciaAceptados = new List<string> { "A", "B", "C" };

        private Chofer piloto = null;

        private int estadoVehiculo = 0; // 0= apagado, 1=encendido, 2= en movimiento

        public string asignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }
            if (tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado para este vehiculo";
            }
            if (piloto != null)
            {
                return "Ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado exitosamente";
        }


        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }

        public string Encender()
        {
            if (piloto == null)
            {
                return "No puedes encender el carro sin piloto";
            }
            if (estadoVehiculo == 1)
            {
                estadoVehiculo = 1;
                return "El carro ya esta encendido";
            }
            return "ups, ya estaba encendido";
            {

            }
        }


        public virtual void acelerar(int cuanto)
        {
            if (estadoVehiculo == 1) { }
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);


            Console.WriteLine("No se puede acelerar un carro apagado");
        }
    }
}
