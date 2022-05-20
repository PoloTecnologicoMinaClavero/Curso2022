// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//string[] Cars = { "Ford", "Fiat", "BMW", "Toyota" };

//Console.WriteLine(Cars[0]);

//string[] frutas = new string[4];

//frutas[0] = "Pera";
//frutas[1] = "Manzana";
//frutas[2] = "Banana";
//frutas[3] = "Kiwi";

////frutas[4] = "Naranja";

//Console.WriteLine(frutas[2]);
//Console.WriteLine(frutas[3]);
//Console.WriteLine("");
//Console.WriteLine(frutas[4]);

int[] numeros = new int[5];
Console.WriteLine($"el array tine tantas posiciones: {numeros.Length} ");
Console.WriteLine("por favor ingrese numeros");
//numeros[0] = int.Parse(Console.ReadLine());
//numeros[1] = int.Parse(Console.ReadLine());
//numeros[2] = int.Parse(Console.ReadLine());
//numeros[3] = int.Parse(Console.ReadLine());
//numeros[4] = int.Parse(Console.ReadLine());

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"por favor ingrse el numero: {i+1}" );
    numeros[i] =int.Parse(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    //suma += numeros[i];
    suma = suma + numeros[i];
}
Console.WriteLine($"valor de suma = {suma}");

Console.WriteLine("los valores son: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

foreach (var item in numeros)
{
    Console.WriteLine(item);
}


