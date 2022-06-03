var bingo = new int[3, 9];

var columnas1 = 3;
var columnas2 = 6;
int[] filas = new int[3];
filas[0] = 0;
filas[1] = 0;
filas[2] = 0;

//for (int i = 0; i < 9; i++)
//{
//    var min = 0;
//    var max = 0;
//    switch (i)
//    {
//        case 0:
//            min = 1;
//            max = 10;
//            break;
//        case 8:
//            min = 80;
//            max = 91;
//            break;
//        default:
//            min = i * 10;
//            max = i * 20;
//            break;
//    }

//    var columna = new Random().Next(1, 3);
//    if (columna == 1 && columnas1 > 0)
//    {
//        columnas1--;
//    }
//    else
//    {
//        columnas2--;
//    }
//}



for (int i = 0; i < 9; i++)
{
    var min = 0;
    var max = 0;

    int maxValue = filas.Max();
    int maxIndex = filas.ToList().IndexOf(maxValue);

    switch (i)
    {
        case 0:
            min = 1;
            max = 10;
            break;
        case 8:
            min = 80;
            max = 91;
            break;
        default:
            min = i * 10;
            max = i * 20;
            break;
    }

    var columna = new Random().Next(1, 3);
    if (columna == 1 && columnas1 > 0)
    {

        columnas1--;

        var fila = new Random().Next(0, 3);

        while (filas[fila] == 5 || fila == maxIndex)
        {
            fila = new Random().Next(0, 3);
        }
        filas[fila]++;

        var valor = new Random().Next(min, max);

        bingo[fila, i] = valor;
    }
    else
    {
        if (i == 8)
        {
            Console.WriteLine();
        }
        columnas2--;

        var fila = new Random().Next(0, 3);
        while (filas[fila] == 5 || fila == maxIndex)
        {
            fila = new Random().Next(0, 3);
        }
        filas[fila]++;


        var valor = new Random().Next(min, max);

        bingo[fila, i] = valor;

        var fila2 = new Random().Next(0, 3);
        while (filas[fila2] == 5 || fila2 == maxIndex)
        {
            fila2 = new Random().Next(0, 3);
        }
        filas[fila2]++;


        var valor2 = new Random().Next(min, max);

        bingo[fila2, i] = valor2;

    }
}

for (int i = 0; i < 3; i++)
{
    for (int x = 0; x < 9; x++)
    {
        Console.WriteLine($"{i} {x} = " + bingo[i, x]);
    }
    Console.WriteLine();
}