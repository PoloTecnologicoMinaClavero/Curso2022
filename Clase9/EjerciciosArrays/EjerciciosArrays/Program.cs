//Se dispone de un array de n números aleatorios (Usar la clase Random). 
//Diseñar un programa que permita insertar un valor x en el lugar k-ésimo del array

Console.WriteLine("Ingrese el tamaño deseado para el listado:");
var dato = Console.ReadLine();
int n = int.Parse(dato);

int[] miVector = new int[n];

Random aleatorio = new Random();

for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = aleatorio.Next(100);
}

var contador = 0;
foreach (var i in miVector)
{
    contador++;
    Console.WriteLine(contador + ": " + i + " ");
}

Console.WriteLine();
Console.WriteLine("Ingrese posición a modificar:");
var k = int.Parse(Console.ReadLine());

if (k > miVector.Length || k < 0)
{
    Console.WriteLine("Indice incorrecto");
}
else
{
    Console.WriteLine("Ingrese nuevo valor:");

    while (true) // Bucle infinito
    {
        var nuevoValor = int.Parse(Console.ReadLine());
        if(nuevoValor>0 && nuevoValor < 100)
        {
            miVector[k-1] = nuevoValor;
            break; //Para salir del bucle infinito
        }
        else
        {
            Console.WriteLine("Recuerde que el valor debe ser positivo menor que 100");
        }
    }

    contador = 0;
    foreach (var i in miVector)
    {
        contador++;
        Console.WriteLine(contador + ": " + i + " ");
    }
}
