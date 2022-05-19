/* Clase 7:  Ejercicio 
Eugenio Serrano
100 puntos
Fecha de entrega: 25 may
Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
 
Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
Pueden adjuntarnos el archivo .cs, o el codigo como texto.*/

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("Ejercicio C# | Clase 7 | Julián Marcelo Zappia");

Console.WriteLine("Presione una tecla para continuar");
var tecla = Console.ReadKey();
Console.Write("Ud. presionó la tecla: ");
Console.WriteLine(tecla);
Console.WriteLine(" ");
Console.WriteLine("Microsoft sugiere no presionar la misma tecla para el cuidado de los dedos.");

Console.WriteLine(" ");
Console.WriteLine("Comienza el ejercicio");

int[] ArrayDeNumeros = new int[10];

int bucles = 0;

int AcumIngreso = 0;
int SumaIngreso = 0;
int MaxIngreso = 0;
int MinIngreso = 1000000;
double PromIngreso = 0;

string CadenaSalida = "";

for (int i = 0; i < ArrayDeNumeros.Length; i++)
{
    bucles = bucles + 1;
    CadenaSalida = "Ingrese el valor Nº " + bucles.ToString() + " de 10: ";
    Console.Write(CadenaSalida);

    int datoIngreso = int.Parse(Console.ReadLine());
    ArrayDeNumeros[i] = datoIngreso;

    AcumIngreso = AcumIngreso + datoIngreso;
    SumaIngreso = SumaIngreso + datoIngreso;

    if (datoIngreso > MaxIngreso)
    {
        MaxIngreso = datoIngreso;

    }

    if (datoIngreso < MinIngreso)
    {
        MinIngreso = datoIngreso;

    }
}

PromIngreso = AcumIngreso / ArrayDeNumeros.Length;

Console.WriteLine("Los números ingresados fueron los siguientes: ");
for (int i = 0; i < ArrayDeNumeros.Length; i++)
{
    Console.WriteLine(ArrayDeNumeros[i]);
}

Console.WriteLine(" ");

Console.WriteLine($"La sumatoria de los números ingresados es igual a: { SumaIngreso.ToString() }");
Console.WriteLine($"El promedio de los valores ingresados es:  { PromIngreso.ToString() }");
Console.WriteLine($"El valor máximo de los valores ingresados es: { MaxIngreso.ToString() }");
Console.WriteLine($"El valor mínimo ingresado es: { MinIngreso.ToString() }");

Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para finalizar.");
Console.ReadKey();



