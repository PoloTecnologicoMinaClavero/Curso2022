Console.WriteLine("Ingrese cantidad de numeros primos deseados:");
var n = int.Parse(Console.ReadLine()); 

int[] primos = new int[n];
List<int> primos2 = new List<int>();


int posicion = 0;
int aux = 0;
int numero = 1;

while(posicion < n)
{
    aux = 0;
    for(var i = 1; i <= numero; i++)
    {
        if(numero % i == 0)
        {
            aux++;
        }
    }
    if (aux == 2)
    {
        primos[posicion] = numero;
        posicion++;
    }
    numero++;
}
foreach(var i in primos)
{
    Console.WriteLine(i);
}
Console.ReadKey();