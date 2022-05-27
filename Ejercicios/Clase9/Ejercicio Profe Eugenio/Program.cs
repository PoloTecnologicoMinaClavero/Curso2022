/*Clase 9: Ejercicio
Eugenio Serrano - 25/05/2022 12:25
100 puntos
Fecha de entrega: 9 jun

Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1) Pedir al usuario la longitud de un vector.

2) Crear el vector del tamaño ingresado.

3) Llenar el mismo con datos aleatorios.

4) Mostrar el vector por pantalla

5) Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; 
el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. 

En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, 
una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.
Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.

6) Mostrar el vector nuevamente. */

Console.Clear();
Console.WriteLine(" ");

Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|     Ejercicio Clase 9 | Classroom | Invertir valores de un vector.     |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|            Autor: Julián Marcelo Zappia. Fecha 25/05/2022              |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|------------------------------------------------------------------------|");


Console.WriteLine(" ");

Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                   Ingresamos dimensión del vector.                     |");
Console.WriteLine("|------------------------------------------------------------------------|");

Console.WriteLine(" ");
Console.Write("Ingrese el valor para determinar la longitud del vector: ");
int IngresoUsuario     = int.Parse(Console.ReadLine());

int ValorBucle         = 0;

int[] VectorNormal     = new int[IngresoUsuario];
int[] VectorInvertido  = new int[IngresoUsuario];

Random NumAleatorio    = new Random();

string CadenaMensaje   = " ";


for (int i = 0; i < VectorNormal.Length; i++)
{
    ValorBucle                                            = ValorBucle + 1;
    VectorNormal[i]                                       = NumAleatorio.Next(((i + 1)*100));
    VectorInvertido[VectorInvertido.Length - ValorBucle]  = VectorNormal[i];
}


Console.WriteLine(" ");

Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                    Mostramos contenido del vector.                     |");
Console.WriteLine("|------------------------------------------------------------------------|");

Console.WriteLine(" ");


for (int j = 0; j < VectorNormal.Length; j++)
{

    CadenaMensaje = "Valor en vector, posición " + j.ToString() + ": " + VectorNormal[j].ToString();
    Console.WriteLine(CadenaMensaje);

}


Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para continuar...");
Console.WriteLine(" ");
Console.ReadKey();


Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                      Mostramos vector invertido.                       |");
Console.WriteLine("|------------------------------------------------------------------------|");

Console.WriteLine(" ");

for (int k = 0; k < VectorNormal.Length; k++)
{

    CadenaMensaje = "Valor en vector INVERTIDO, posición " + k.ToString() + ": " + VectorInvertido[k].ToString();
    Console.WriteLine(CadenaMensaje);
}

Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para finalizar.");
Console.WriteLine(" ");

Console.ReadKey();
