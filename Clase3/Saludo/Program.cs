
// Borra la pantalla
Console.Clear();

// Pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, Ingrese su nombre:");

// Leemos el nombre del usuario
string nombre = Console.ReadLine();

// Pedimos al usuario que introduzca su apellido
Console.WriteLine("Ahora por favor ingrese su apellido:");

string apellido = Console.ReadLine();

// Mostramos el nombre
Console.Write("Hola " + nombre);
Console.WriteLine(", este es mi segundo programa.");

Console.WriteLine("Pulse una tecla para finalizar.");
Console.ReadKey();

