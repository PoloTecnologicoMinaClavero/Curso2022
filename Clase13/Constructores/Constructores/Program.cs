using Constructores.Modelo;

var persona1 = new Persona("Ezequiel Etchecoin", "12312", 30, true);

Console.WriteLine(persona1.ObtenerSaludo());
Console.WriteLine(persona1.ObtenerSaludo("Carlos"));

var persona2 = new Persona { NombreCompleto = "Carlos Moscoso" };

//Esta clase también se incorpora desde el namespace Constructores.Modelo
var miOcupacion = new Ocupacion();