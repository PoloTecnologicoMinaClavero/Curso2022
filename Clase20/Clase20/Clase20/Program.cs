using Clase20.Clases;

var p = new Persona
{
    Nombre = "Juan",
    Apellido = "Perez"
};

var miArray = new int[] { 1, 2, 3, 4, 5 };

var p2 = new Persona();
p2.Nombre = "Juan";
p2.Apellido = "Perez";

var p3 = new Persona("Juan", "Perez");

var pr = new Proveedor("Eugenio", "Perez");
Console.WriteLine(pr.CalcularCredito());

var miTexto = "Cuantas-palabras-tiene-este-texto?";
Console.WriteLine(miTexto.ContarPalabras('-'));

// Tipos anonimos
var auto1 = new
{
    Marca = "Ford",
    Modelo = "Mustang",
    Anio = "1969"
};

//Console.WriteLine(auto1.Marca);
//Console.WriteLine(auto1.Modelo);


var pr2 = new 
{
    pr.Nombre,
    pr.Apellido,
    TipoProveedor = "Limpieza",
    Edad = 23,
    FechaAlta = new DateTime(2022,6,30)
};

//Console.WriteLine(pr2.Nombre);
//Console.WriteLine(pr2.Apellido);
//Console.WriteLine(pr2.TipoProveedor);
//Console.WriteLine(pr2.FechaAlta);


// Expresiones lambda
// Ejemplo 1
int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
int numerosImpares = numeros.Count(numero => numero % 2 == 1);

Console.WriteLine(numerosImpares);

// Ejemplo 2
List<Persona> misClientes = new List<Persona>();
misClientes.Add(new Persona { Apellido = "Perez", Nombre = "Juan" });
misClientes.Add(new Persona { Apellido = "De Tal", Nombre = "Fulano" });

//IEnumerable<Persona> juanes = misClientes.Where(
//    cadaCliente => cadaCliente.Nombre == "Juan");

var juanes = misClientes.Where(
    cadaCliente => cadaCliente.Nombre == "Juan");

foreach (var item in juanes)
{
    Console.WriteLine(item.Nombre);
}
