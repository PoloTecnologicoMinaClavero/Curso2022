using ConsoleApp1.Modelo;

Console.WriteLine("Estamos creando un nuevo Auto. Ingrese Tipo de Motor:");
var tipoMotor = Console.ReadLine();

var miAuto = new Auto();
miAuto.TipoDeMotor = tipoMotor;

Console.WriteLine(miAuto.TipoDeMotor);