
using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

Chofer piloto1 = new Chofer("Monica", 25, "A");
Chofer piloto2 = new Chofer("Andrea", 21, "M");

Vehiculo sedan = new Vehiculo(2025, "Azul", "Honda");


String respuesta;
//sedan.acelerar();

respuesta = sedan.asignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);
sedan.acelerar(25);

Moto honda = new Moto(2025,"Rojo", "Honda");
Console.WriteLine(honda.asignarPiloto(piloto2));