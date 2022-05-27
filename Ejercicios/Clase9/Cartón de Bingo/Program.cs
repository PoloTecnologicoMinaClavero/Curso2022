/*Clase 9: Ejercicio 2
Eugenio Serrano 13:04(Última modificación: 13:24)
100 puntos
Fecha de entrega: 9 jun
Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla */


Console.Clear();
Console.WriteLine(" ");

Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("*    Ejercicio Clase 9 (#2) | Classroom | Cartón de bingo y otros...     *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("*   Autor: Julián M. Zappia. Fecha 25/05/2022. Reinventado 26/05/2022.   *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");


Console.WriteLine(" ");


// Declaro variables, matriz y vectores.

Random varRandom   = new Random();

string varSeguir     = "S";

int CicloBucle       = 0;
int valorCompara     = 0;
int varOrdenar       = 0;

int[,] MatrizBingo   = new int[3, 9];
int[] Ordenar1       = new int[9];
int[] Ordenar2       = new int[9];
int[] Ordenar3       = new int[9];


Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("*           Bienvenido al Bingo MatriX | Con mucho cariño                *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");


Console.WriteLine(" ");


while (varSeguir == "S")
{

    // Inicializo matriz con ceros para después reiniciar valores en bucle.

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            MatrizBingo[i, j] = 0;

        }

    }


    // Recorrida por la matriz para generar los números y validación de no repitencia de valores.

    for (int filaMatriz = 0; filaMatriz < 3; filaMatriz++)
    {
        for (int coluMatriz = 0; coluMatriz < 9; coluMatriz++)
        {
            if (coluMatriz == 0)
            {
                valorCompara = varRandom.Next(1, 9);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(1, 9);

                            }

                        }

                    }

                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 1)
            {
                valorCompara = varRandom.Next(9, 19);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(9, 19);

                            }

                        }

                    }

                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 2)
            {
                valorCompara = varRandom.Next(20, 29);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(20, 29);

                            }

                        }

                    }

                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 3)
            {
                valorCompara = varRandom.Next(30, 39);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(30, 39);

                            }

                        }

                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 4)
            {
                valorCompara = varRandom.Next(40, 49);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(40, 49);

                            }

                        }
                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 5)
            {
                valorCompara = varRandom.Next(50, 59);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(50, 59);

                            }

                        }
                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 6)
            {
                valorCompara = varRandom.Next(60, 69);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(60, 69);

                            }

                        }
                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 7)
            {
                valorCompara = varRandom.Next(70, 79);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(70, 79);

                            }

                        }
                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 8)
            {
                valorCompara = varRandom.Next(80, 89);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(80, 89);

                            }

                        }
                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }

            if (coluMatriz == 9)
            {
                valorCompara = varRandom.Next(90, 99);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (MatrizBingo[i, j] == valorCompara)
                        {
                            while (MatrizBingo[i, j] == valorCompara)
                            {
                                valorCompara = varRandom.Next(90, 99);

                            }

                        }
                    }
                }

                MatrizBingo[filaMatriz, coluMatriz] = valorCompara;

            }
        }

    }


    Console.WriteLine(" ");


    // Ordeno matriz por columnas. Utilizo resultado anterior de ordenar por filas.

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            varOrdenar = j;

            if (i == 0)
            {
                Ordenar1[varOrdenar] = MatrizBingo[i, j];

            }

            if (i == 1)
            {
                Ordenar2[varOrdenar] = MatrizBingo[i, j];

            }

            if (i == 2)
            {
                Ordenar3[varOrdenar] = MatrizBingo[i, j];

            }

        }

    }


    // Asigno variables y vectores axiliares temporarios para el ordenamiento correcto.

    int VectorLongitud1 = Ordenar1.Length;
    int VectorLongitud2 = Ordenar2.Length;
    int VectorLongitud3 = Ordenar3.Length;
    int LongitudTemp = (VectorLongitud1 + VectorLongitud2 + VectorLongitud3);
    int bucleOrdenar = 0;


    // Intento con Array.Sort().

    Array.Sort(Ordenar1);
    Array.Sort(Ordenar2);
    Array.Sort(Ordenar3);



    // Intento con método burbuja (Bubble Sort).
    // Ordeno columnas (ya las filas estaban ordenadas).

    int CambioValor = 0;

    for (int i = 0; i < 3; i++)
    {
        bucleOrdenar = 0;

        for (int j = 0; j < 9; j++)
        {
            if (i == 0)
            {
                MatrizBingo[i, j] = Ordenar1[j];

            }

            if (i == 1)
            {
                if (MatrizBingo[i, j] > MatrizBingo[i - 1, j])
                {
                    MatrizBingo[i, j] = Ordenar2[j];

                }

                if (MatrizBingo[i, j] <= MatrizBingo[i - 1, j])
                {
                    while (MatrizBingo[i, j] <= MatrizBingo[i - 1, j])
                    {
                        CambioValor = MatrizBingo[i, j] + 1;
                        MatrizBingo[i, j] = CambioValor;

                    }

                }

            }

            if (i == 2)
            {
                if (MatrizBingo[i, j] > MatrizBingo[i - 1, j])
                {
                    MatrizBingo[i, j] = Ordenar3[j];

                }

                if (MatrizBingo[i, j] <= MatrizBingo[i - 1, j])
                {
                    while (MatrizBingo[i, j] <= MatrizBingo[i - 1, j])
                    {
                        CambioValor = MatrizBingo[i, j] + 1;
                        MatrizBingo[i, j] = CambioValor;

                    }

                }

                bucleOrdenar++;
            }
        }

    }


    // Agrego espacios de acuerdo a formato de cartón y concateno valores y caracteres especiales.
    // Muestro "cartón" de Bingo.
    
    Console.WriteLine(" ");

    Console.WriteLine("**************************************************************************");
    Console.WriteLine("*                                                                        *");
    Console.WriteLine("*                    Este es el cartón del Bingo!                        *");
    Console.WriteLine("*                                                                        *");
    Console.WriteLine("**************************************************************************");

    Console.WriteLine(" ");

    string espacio      = " █ ";
    string CadenaPrevia = "────────────────────────────────────────────────────────────────────" + "\n" + "\n" + " "; 
    int PosFila         = 0;
    int PosColu         = 0;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            CadenaPrevia = CadenaPrevia + MatrizBingo[i, j].ToString() + " │ ";
            PosFila      = i;
            PosColu      = j;

            if (PosFila == 0)
            {
                if (PosColu == 0 || PosColu == 3 || PosColu == 4 || PosColu == 7)
                {
                    CadenaPrevia = CadenaPrevia + espacio + " │ ";
                }

            }

            if (PosFila == 1)
            {
                if (PosColu == 0 || PosColu == 1 || PosColu == 3 || PosColu == 6)
                {
                    CadenaPrevia = CadenaPrevia + espacio + " │ ";
                }


            }

            if (PosFila == 2)
            {
                if (PosColu == 1 || PosColu == 2 || PosColu == 5 || PosColu == 8)
                {
                    CadenaPrevia = CadenaPrevia + espacio + " │ ";
                }

            }


        }


        Console.Write(CadenaPrevia + "\n" + "\n" + "────────────────────────────────────────────────────────────────────" + "\n" + "\n");
        CadenaPrevia = " ";
     
    }


    Console.WriteLine(" ");

    // Contador para el nÚmero de carton generado.
    CicloBucle++;

    Console.WriteLine(" ");

    Console.WriteLine("N° de Cartón generado: " + CicloBucle);

    Console.WriteLine(" ");
    Console.Write("¿Desea otro cartón? (S/N): ");
    varSeguir = Console.ReadLine();
    varSeguir = varSeguir.ToUpper();
    Console.WriteLine(" ");

}


Console.WriteLine("Bingo finalizado! Presione una tecla para salir.");
Console.ReadKey();




