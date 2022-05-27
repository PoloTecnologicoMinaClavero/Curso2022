/*Clase 9: Ejercicio
Eugenio Serrano - 25/05/2022 12:25
100 puntos
Fecha de entrega: 9 jun

Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1) Pedir al usuario la longitud de un vector.

2) Crear el vector del tama�o ingresado.

3) Llenar el mismo con datos aleatorios.

4) Mostrar el vector por pantalla

5) Invertir el vector, de manera que el primer elemento quede al �ltimo y el �timo en el primero; 
el segundo en ante�ltimo, el ante�ltimo en el segundo y as� sucesivamente. 

En otra palabras si el vector es de 5 posiciones y el usuario ingres�: 10, 20, 30, 40, 50, 
una vez invertido, el vector debe quedar as�: 50, 40, 30, 20, 10.
Se debe usar solo lo visto en clase hasta ahora y no los m�todos que trae C# para estas cuestiones.

6) Mostrar el vector nuevamente. */

Console.Clear();
Console.WriteLine(" ");

Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|     Ejercicio Clase 9 | Classroom | Invertir valores de un vector.     |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|          Autor: Juli�n Marcelo Zappia. CORREGIDO 27/05/2022            |");
Console.WriteLine("|                                                                        |");
Console.WriteLine("|------------------------------------------------------------------------|");


Console.WriteLine(" ");

Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                   Ingresamos dimensi�n del vector.                     |");
Console.WriteLine("|------------------------------------------------------------------------|");

Console.WriteLine(" ");
Console.Write("Ingrese el valor para determinar la longitud del vector: ");
int IngresoUsuario    = int.Parse(Console.ReadLine());


// Inicio de variables y vectores (principales y auxiliares). M�todo Random.

int[] VectorNormal    = new int[IngresoUsuario];

Random NumAleatorio   = new Random();

string CadenaMensaje  = " ";

int ValorBucle        = 0;

int ValorBucleInverso = IngresoUsuario;
int VMatriz1          = 0;
int VMatriz2          = 0;


// Inicializo vector con ceros (por repetici�n de valores).

for (int i = 0; i < VectorNormal.Length; i++)
{
    ValorBucle      = ValorBucle + 1;
    VectorNormal[i] = 0;

}


// Cargo vector con n�meros aleatorios.

for (int i = 0; i < VectorNormal.Length; i++)
{
    ValorBucle      = ValorBucle + 1;
    VectorNormal[i] = NumAleatorio.Next(((i + 1) * 100));
    
}


Console.WriteLine(" ");

Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                    Mostramos contenido del vector.                     |");
Console.WriteLine("|------------------------------------------------------------------------|");

Console.WriteLine(" ");


for (int j = 0; j < VectorNormal.Length; j++)
{

    CadenaMensaje = "Valor en vector, posici�n " + j.ToString() + ": " + VectorNormal[j].ToString();
    Console.WriteLine(CadenaMensaje);

}


Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para continuar...");
Console.WriteLine(" ");
Console.ReadKey();


// Inicio nueva inversi�n de vector con variables auxiliares.
// Asignado como correcci�n por el Profesor Eugenio el 26/05/2022.
// No se usa vector auxiliar.


for (int j = 0; j < VectorNormal.Length / 2; j++)
{

    ValorBucleInverso               = (VectorNormal.Length - (j + 1));
    VMatriz1                        = VectorNormal[j];
    VMatriz2                        = VectorNormal[ValorBucleInverso];

    VectorNormal[j]                 = VMatriz2;
    VectorNormal[ValorBucleInverso] = VMatriz1;

}


Console.WriteLine("|------------------------------------------------------------------------|");
Console.WriteLine("|                      Mostramos vector invertido.                       |");
Console.WriteLine("|------------------------------------------------------------------------|");

Console.WriteLine(" ");

for (int k = 0; k < VectorNormal.Length; k++)
{

    CadenaMensaje = "Valor en vector INVERTIDO, posici�n " + k.ToString() + ": " + VectorNormal[k].ToString();
    Console.WriteLine(CadenaMensaje);
}

Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para finalizar.");
Console.WriteLine(" ");

Console.ReadKey();
