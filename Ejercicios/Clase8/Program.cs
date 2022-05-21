/* 	
NUEVA TAREA
Clase 8: Ejercicio
Ejercicio

Crear un programa que cumpla con los siguientes pasos

1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios */


Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("======================================================");
Console.WriteLine("Ejercicio Clase 8 | Polo Tecnológico Mina Clavero | C#");
Console.WriteLine("Autor: Julián Marcelo Zappia");
Console.WriteLine("======================================================");

Console.WriteLine(" ");
Console.WriteLine("======================================================");
Console.WriteLine("  Comienza la definición de dimensiones de la matriz  ");
Console.WriteLine("======================================================");
Console.WriteLine(" ");

Console.Write("Ingrese la cantidad de filas de la matriz:    ");
int FilasMatriz    = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de columnas de la matriz: ");
int ColumnasMatriz = int.Parse(Console.ReadLine());

int[,] NuevaMatriz       = new int[FilasMatriz, ColumnasMatriz];
double[] PromediosMatriz = new double[FilasMatriz], M;

string CadenaMensaje     = " ";
int AcumulaValores       = 0;
int NumBucleColu         = 0;


Console.WriteLine(" ");
Console.WriteLine("======================================================");
Console.WriteLine("        Cargar valores numéricos a la matriz.         ");
Console.WriteLine("======================================================");
Console.WriteLine(" ");


for (int f = 0; f < FilasMatriz; f++)
{
    
    for (int c = 0; c < ColumnasMatriz; c++)
    {
        CadenaMensaje     = "Por favor, ingrese un valor numérico para la fila " + (f + 1).ToString() + " y la columna  " + (c + 1).ToString() + ": ";
        Console.Write(CadenaMensaje);
        int ValorIngreso  = int.Parse(Console.ReadLine());

        NuevaMatriz[f, c]  = ValorIngreso;
        AcumulaValores     = AcumulaValores + ValorIngreso;
        NumBucleColu       = NumBucleColu + 1;
        
    }

    PromediosMatriz[f] = (AcumulaValores / NumBucleColu);
    NumBucleColu       = 0;
    AcumulaValores     = 0;

    Console.WriteLine(" ");

}


Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para continuar.");
Console.ReadKey();


Console.WriteLine(" ");
Console.WriteLine("======================================================");
Console.WriteLine("                  Mostrar MatriX.                     ");
Console.WriteLine("======================================================");
Console.WriteLine(" ");
Console.WriteLine(" ");


for (int f1 = 0; f1 < FilasMatriz; f1++)
{
  
    for (int c1 = 0; c1 < ColumnasMatriz; c1++)
    {
        string CadenaMostrar = "El valor cargado en la MatriX, fila " + (f1 + 1).ToString() + ", columna " + (c1 + 1).ToString() + " es: " + NuevaMatriz[f1, c1].ToString();
        Console.WriteLine(CadenaMostrar);

    }

    Console.WriteLine(" ");

}


Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para continuar.");
Console.ReadKey();


Console.WriteLine(" ");
Console.WriteLine("======================================================");
Console.WriteLine("       Promedios de las columnas de la MatriX.        ");
Console.WriteLine("======================================================");
Console.WriteLine(" ");
Console.WriteLine(" ");


for (int f2 = 0; f2 < FilasMatriz; f2++)
{
    string CadenaMostrarUno = "El promedio de las columnas de la fila " + (f2 + 1).ToString() + " de la matriz es: ";
    Console.Write(CadenaMostrarUno);
    Console.WriteLine("{0:N2}", PromediosMatriz[f2]);

}


Console.WriteLine(" ");
Console.WriteLine("Presione una tecla para finalizar.");
Console.ReadKey();


// No me sale mostrar los decimales correctos.
// Los promedios los calcula bien pero muestra, por ejemplo, 17,00 en lugar de 17,50.
// Consulté las formas posibles a aplicar (una M después de la definición y la máscara en el WriteLine, y nada.
// Se los dejo como consulta.
// Muchas gracias. Saludos.


