
Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectangulo");
Console.WriteLine();

//decimal v = decimal.Parse("222");

//string baseRectanguloTexto = Console.ReadLine();
//double baseRectangulo = double.Parse(baseRectanguloTexto);

Console.WriteLine("Ingrese la base del rectangulo");
double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectangulo");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo =
    baseRectangulo * alturaRectangulo;

Console.Write("La superficie del rectangulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    // Mostrar mensaje solamente si es mayor a diez
    Console.WriteLine("La superficie del rectangulo es mayor a 10");
}

//string cualquiercosa = "hola";

Console.ReadKey();
