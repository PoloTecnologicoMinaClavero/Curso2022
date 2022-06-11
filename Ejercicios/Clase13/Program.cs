/* Clase 13: Ejercicio - Billetera
Eugenio Serrano
•
Ayer
100 puntos
Fecha de entrega: 22 jun
Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes) */



/*******************************************************************************************************
*  ZAPPIA, JULIAN MARCELO | Ejercicio 13 | Curso C#.NET | Polo Tecnológico Mina Clavero                *
********************************************************************************************************
*  Descripción: Program.cs de Ejercicio 13. "Billetera". Usando Espacios de nombres, clases, métodos.  *
*  Autor:       Julián Marcelo Zappia.                                                                 *
*  Fecha:       10/06/2022 al 11/06/2022                                                               *
********************************************************************************************************/


using static Clase13.GrupoBilletera;


// VS2022 arrojaba Error CS 5001 e indicaba que faltaba un punto de inicio de programa por falta de Main().
// Obligado a ponerlo sin entender el por qué. Solo quedan advertencias en compilación.


static void Main()
{
    int nada = 0;

}

// Inicializo variables de entorno.

string VarNombre = " ";
double VarNumero = 0;
double V1        = 0;
double V2        = 0;
        

// Cargo valores de Billetera.

Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine("A continuación, ingrese la cantidad de billetes que posee la billetera de Julián según denominación.");
Console.WriteLine(" ");
Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.WriteLine(" ");


Console.Write("Ingrese la cantidad de billetes de 10 pesos:   ");
BilletesDe10   = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de billetes de 20 pesos:   ");
BilletesDe20   = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de billetes de 50 pesos:   ");
BilletesDe50   = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de billetes de 100 pesos:  ");
BilletesDe100  = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de billetes de 200 pesos:  ");
BilletesDe200  = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de billetes de 500 pesos:  ");
BilletesDe500  = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de billetes de 1000 pesos: ");
BilletesDe1000 = int.Parse(Console.ReadLine());


// Muestro total de Billetes.

string NomB = "La Billetera de Julián tiene un total de: ";
int NumB    = BilletesDe10 + BilletesDe20 + BilletesDe50 + BilletesDe100 + BilletesDe200 + BilletesDe500 + BilletesDe1000;

Console.WriteLine(" ");
Console.WriteLine(Clase13.mBillete.TotalBilletes(NomB, NumB)); 


//Muestro mensajes.

if (NumB >= 50)
{
    Console.WriteLine(" ");
    Console.WriteLine("Parece que esa billetera está GoRDiTa Eh! Pagate unas birras!");
    Console.WriteLine(" ");
   
}

if (NumB < 50)
{
    Console.WriteLine(" ");
    Console.WriteLine("Esa billetera está re flaca papá!");
    Console.WriteLine(" ");
   
}


// Muestro monto total en pesos de la Billetera.

NomB = "La Billetera de Julián tiene un monto total de $ ";
NumB = (BilletesDe10*10) + (BilletesDe20*20) + (BilletesDe50*50) + (BilletesDe100*100) + (BilletesDe200*200) + (BilletesDe500*500) + (BilletesDe1000*1000);

Console.WriteLine(Clase13.mBillete.TotalBilletera(NomB, NumB));


// Muestro mensajes.

if (NumB >= 1000) 
{
    Console.WriteLine("Vamos mejorando! Parece que tenés un buen SuElDo eH! Pagate dos Quilmes heladas!");
   
}

if (NumB < 1000)
{
    Console.WriteLine("Cada vez más croto! No tenés un mango papá! Y yo no invito! Me voy!");
   
}


// Muestro la cantidad de Billetes por Denominación que contiene la Billetera.

Console.WriteLine(" ");
Console.WriteLine(Clase13.mBillete.BilletesPorDenominacion());
Console.WriteLine(" ");


// Pausa.

Console.WriteLine("Presione una tecla para continuar.");
Console.ReadKey();


// Guardo Contenidos de Variables anteriores.

string mNombreAnt    = NomB;
double mNumeroAnt    = NumB;

// Inicio carga de nueva Billetera.

Console.WriteLine(" ");
Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.WriteLine(" ");
Console.WriteLine("A continuación, ingrese la cantidad de billetes que posee la billetera de Victoria y Agustina         ");
Console.WriteLine(" ");
Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.WriteLine(" ");


// Invoco el Método / Función para crear la nueva Billetera a Combinar.

Clase13.BilleteraNueva.CrearNuevaBilletera();
Console.WriteLine(" ");


// Invoco función que muestra el total de la Billetera Nueva.

Console.WriteLine(Clase13.mBillete.TotalBilleteraNueva(NomB, NumB));


// Guardo Total de Nueva Billetera.

V2 = Clase13.mBillete.TotalBilleteraNueva(NomB, NumB);


// Almaceno suma de valores de ambas Billeteras temporalmente antes de poner en cero.

double tempVarieble = Clase13.mBillete.AlmacenoBilleteras(V1, V2);


// Muestro el valor de la Combinación de Billeteras.

Console.WriteLine(Clase13.mBillete.CombinarBilleteras(mNumeroAnt, NumB));


Console.WriteLine("Presione una tecla para finalizar.");
Console.ReadKey();
