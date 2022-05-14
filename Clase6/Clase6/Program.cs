//Diferencia entre declaración implícita (var) y explícita (int u otro tipo de dato)

/* aquí comienza el comentario
 
int numero1, numero2, numero3;
//var numero4, numero5;

var miVariable = 0;

Console.WriteLine($"El contenido de mi variable es: {miVariable}");

var miVariable2 = "un texto";

Console.WriteLine($"El contenido de mi variable es: {miVariable2}");

...aquí termina */

//----------------------------------------------------------------------

/*
Escribir un programa que haga lo siguiente:

1) Borrar la pantalla.
2) Pedir el nombre de una persona. INGRESO DE DATOS
3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!" IMPRIMIR EN PANTALLA
4) Preguntar si se quiere continuar. CONDICIONAL "IF"
5) Si la respuesta es "S" repetir desde el punto 1. BUCLE
6) Si la respuesta es "N" finalizar el programa mostrando 
   un mensaje que diga "Programa finalizado correctamente". IMP. PANTALLA
7) Si la respuesta no es ni "S" ni "N" que tambien 
   finalice el programa, pero mostrando un mensaje 
   que diga "Opcion no valida". IMP. PANTALLA

*/

//Alternativa con While

/*
var opcionElegida = "S";

while (opcionElegida.ToUpper() == "S")
{
    //Borro la pantalla
    Console.Clear();

    //Pido el nombre de la persona
    Console.WriteLine("¡Buenas! Ingrese su nombre: ");
    var nombrePersona = Console.ReadLine();

    //Muestro el saludo
    //Console.WriteLine("¡Hola " + nombrePersona + "!");
    Console.WriteLine($"¡Hola {nombrePersona}!");

    Console.WriteLine("¿Desea continuar? S para sí, N para no.");
    opcionElegida = Console.ReadLine();
}

if(opcionElegida.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opción no válida.");
}
*/

//-------------------------------------------------------

//Alternativa con Do-While (hacer-mientras)
string opcionElegida;
do
{
    //Borro la pantalla
    Console.Clear();

    //Pido el nombre de la persona
    Console.WriteLine("¡Buenas! Ingrese su nombre: ");
    var nombrePersona = Console.ReadLine();

    //Muestro el saludo
    //Console.WriteLine("¡Hola " + nombrePersona + "!");
    Console.WriteLine($"¡Hola {nombrePersona}!");

    Console.WriteLine("¿Desea continuar? S para sí, N para no.");
    opcionElegida = Console.ReadLine();

    if (opcionElegida.ToUpper() == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
    else if(opcionElegida.ToUpper() != "S")
    {
        Console.WriteLine("Opción no válida.");
    }
}
while (opcionElegida.ToUpper() == "S");