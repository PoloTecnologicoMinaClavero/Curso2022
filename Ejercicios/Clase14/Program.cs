/*Clase 14: Ejercicio - Cartas españolas
Eugenio Serrano • 9 jun
100 puntos
Fecha de entrega: 30 jun

Ejercicio de cartas españolas orientado a objetos:

Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y un palo (espadas, bastos, oros y copas)
La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

Las operaciones que podrá realizar la baraja son:

Barajar():
  Cambia de posición todas las cartas aleatoriamente.

SiguienteCarta():
  Devuelve la siguiente carta que está en la baraja, cuando no haya más o se haya llegado al final, se indica al usuario que no hay más cartas.

CartasDisponibles():
  Indica el número de cartas que aún puede repartir

DarCartas(int cantidad):
  Dado un número de cartas que nos pidan, le devolveremos ese número de cartas (piensa que puedes devolver). En caso de que haya menos cartas que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.

CartasMonton():
  Mostramos aquellas cartas que ya han salido, si no ha salido ninguna indicárselo al usuario.

MostrarBaraja():
  Muestra todas las cartas hasta el final. Es decir, si se saca una carta y luego se llama al método, este no mostrara esa primera carta.


Escribir un programa que dentro de un bucle vaya mostrando las opciones que querramos, por ejemplo

1 - Barajar
2 - Mostrar siguiente carta
3 - Mostrar cartas disponibles
4 - Dar cartas
5 - Mostrar cartas del monton
6 - Mostrar baraja
7 - Salir*/



/*******************************************************************************************************
*  ZAPPIA, JULIAN MARCELO | Ejercicio 14 | Curso C#.NET | Polo Tecnológico Mina Clavero                *
********************************************************************************************************
*  Descripción: Program.cs de Ejercicio 14. "Barajas españolas". Con Espacios de Nombres, Clases, etc. *
*  Autor:       Julián Marcelo Zappia.                                                                 *
*  Fecha:       12/06/2022 al 15/06/2022                                                               *
********************************************************************************************************/

// Uso Espacio de nombre namespace Clase14


using Clase14;


// Incializo tres vectores: uno para las numeraciones, otro para los palos y el restante iniciado
// y cargado con valores temporales.

int CartasContador = 0;

string[] MazoCompleto;
string[] MazoNumeros;
string[] MazoPalos;
string[] Mazo;
string[] MazoTemp;
string[] MazoMezclado;
string[] MazoMezcladoNuevo;
string[] MazoInicio;


MazoCompleto         = new string[40];
MazoNumeros          = new string[12];
MazoPalos            = new string[4];
Mazo                 = new string[48];
MazoTemp             = new string[40];
MazoMezclado         = new string[40];
MazoMezcladoNuevo    = new string[40];
MazoInicio           = new string[40];


for (int i = 0; i < 40; i++)
{
    MazoMezclado[i]      = 0.ToString();
    MazoMezcladoNuevo[i] = 0.ToString();
  

}

// Invoco a funciones de Espacio.Clase.Método/Función y paso vectores como parámetros.
// Los "recargo" con el retorno de los Métodos/Funciones.

MazoCompleto = Clase14.Class14.CargarVector1(MazoCompleto);
MazoNumeros  = Clase14.Class14.CargarVector2(MazoNumeros);
MazoPalos    = Clase14.Class14.CargarVector3(MazoPalos);


// Muestro resultados al azar para comprobar la correcta carga de vectores y hago pausa.
// Esta parte de código será anulada.

// Console.WriteLine(MazoCompleto[2]);
// Console.WriteLine(MazoNumeros[10]);
// Console.WriteLine(MazoPalos[2]);

// Console.ReadKey();


// Cargo arreglo final del Mazo (por ejemplo: 3 - Oro).

Class14.InicializarNMazo(Mazo);
int Carta1    = 0;
int Carta2    = 0;
int Palo      = 0;
bool VoF      = false;
Mazo          = Class14.ArmarMazo(Carta1, Carta2, Palo, MazoNumeros, MazoPalos, Mazo);


// Muestro contenido de Mazo Temporal. El código siguiente será anulado.

//for (int i = 0; i < 48; i++)
//{
//    Console.WriteLine(Mazo[i]);
//
//
//}

// Console.ReadKey();
// Console.Clear();


// Limpio los ceros del mazo generado en IncicializarMazo.

Class14.LimpiarMazo(Mazo, MazoCompleto);
MazoInicio = MazoCompleto;


// Muestro contenido de Mazo final. Temporal. Será anulado.

//for (int i = 0; i < 40; i++)
//{
//    Console.WriteLine(MazoCompleto[i]);
//
//
//}

//Console.ReadKey();
//Console.Clear();


// Desordeno aleatoriamente el vector.

Class14.Barajar(MazoCompleto, MazoTemp, MazoMezclado, MazoMezcladoNuevo, VoF); ;


// Muestro contenido de Mazo Barajado. Temporal. Será anulado.

//for (int i = 0; i < 40; i++)
//{
//    Console.WriteLine(MazoMezclado[i]);
//
//
//}

//Console.ReadKey();
//Console.Clear();


// Realizo una nueva "mezcla" del contenido del vector de cartas.

Class14.BarajarDeNuevo(MazoCompleto, MazoTemp, MazoMezclado, MazoMezcladoNuevo, VoF);


// Muestro contenido de Mazo Barajado nuevamente. Temporal. Será anulado.

//for (int i = 0; i < 40; i++)
//{
//    Console.WriteLine(MazoMezcladoNuevo[i]);
//
//
//}

//Console.ReadKey();
//Console.Clear();


// Paso los Mazos de Cartas a Listas.

List<string> ListaMazo              = new List<string>();
List<string> ListaMazoMezclado      = new List<string>();
List<string> ListaMazoMezcladoNuevo = new List<string>();

Class14.MazoToLista(MazoCompleto, MazoMezclado, MazoMezcladoNuevo, ListaMazo, ListaMazoMezclado, ListaMazoMezcladoNuevo);


// Muestro Listas. Código temporal a anular.

//foreach (var elemento in MazoCompleto)
//{
//    Console.WriteLine(elemento);

//}

//Console.ReadKey();
//Console.Clear();

//foreach (var elemento in MazoMezclado)
//{
//    Console.WriteLine(elemento);

//}

//Console.ReadKey();
//Console.Clear();

//foreach (var elemento in MazoMezcladoNuevo)
//{
//    Console.WriteLine(elemento);
//
//}

//Console.ReadKey();
//Console.Clear();



// Paso los Mazos de Cartas a Stack.

Stack<string> StackMazoCompleto      = new Stack<string>(MazoCompleto.ToArray());
Stack<string> StackMazoMezclado      = new Stack<string>(MazoMezclado.ToArray());
Stack<string> StackMazoMezcladoNuevo = new Stack<string>(MazoMezcladoNuevo.ToArray());


Class14.MazoToPila(MazoCompleto, MazoMezclado, MazoMezcladoNuevo, StackMazoCompleto, StackMazoMezclado, StackMazoMezcladoNuevo);


// Muestro contenido de Pilas. Temporal. El código será anulado.

//foreach (string carta in StackMazoCompleto)
//{
//    Console.WriteLine(carta);

//}

//Console.ReadKey();
//Console.Clear();


//foreach (string carta in StackMazoMezclado)
//{
//    Console.WriteLine(carta);

//}

// Console.ReadKey();
// Console.Clear();


//foreach (string carta in StackMazoMezcladoNuevo)
//{
//    Console.WriteLine(carta);
//
//}

//Console.ReadKey();
//Console.Clear();


var OpcionUsuario           = 0;
bool Opcion1                = false;
bool Opcion2                = false;   

while (OpcionUsuario != 8)
{
    OpcionUsuario = 0;
    
    Console.Clear();
    Console.WriteLine(" ");
    Console.WriteLine("Seleccione la opción a realizar: ");
    Console.WriteLine(" ");
    Console.WriteLine("1 - Mezclar.");
    Console.WriteLine("2 - Barajar.");
    Console.WriteLine("3 - Mostrar siguiente carta.");
    Console.WriteLine("4 - Mostrar cartas disponibles.");
    Console.WriteLine("5 - Dar cartas.");
    Console.WriteLine("6 - Mostrar cartas del montón.");
    Console.WriteLine("7 - Mostrar baraja.");
    Console.WriteLine("8 - Salir.");
    Console.WriteLine(" ");
    Console.Write("Ingrese la opción deseada: ");
    
    OpcionUsuario = int.Parse(Console.ReadLine());
    
    switch (OpcionUsuario)
    {
        case 1:
            // Mezclar mazo.
            var nVeces         = 0;
            string[] nMazoTemp = new string[MazoMezcladoNuevo.Length];

            Console.WriteLine(" ");
            Console.Write("¿Cuántas veces desea mezclar el mazo?: ");
            nVeces = int.Parse(Console.ReadLine());

            if (nVeces != 0)
            {
                for (var i = 0; i < nVeces + 1; i++)
                {
                    nMazoTemp = Class14.Barajar(MazoInicio, MazoTemp, MazoMezclado, MazoMezcladoNuevo, false);
                    nMazoTemp = Class14.BarajarDeNuevo(MazoInicio, MazoTemp, MazoMezclado, MazoMezcladoNuevo, false);

                }

                Console.WriteLine(" ");
                Console.WriteLine("Se muestra el mazo mezclado " + nVeces.ToString() + " veces.");

                string Cadena = "";
                MazoMezcladoNuevo = nMazoTemp;

                for (int i = 0; i < MazoMezcladoNuevo.Length; i++)
                {
                    Cadena = Cadena + MazoMezcladoNuevo[i].ToString() + "\n";

                }

                Console.WriteLine();
                Console.WriteLine(Cadena);
                Console.ReadKey();
                Console.WriteLine("Presione una tecla para continuar.");
                Opcion1 = true;
                break;


            }
            

            if (nVeces == 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ingreso no válido. Imposible mezclar las cartas 0 (cero) veces");
                Console.WriteLine("Presione una tecla pata continuar.");
                Console.ReadKey();


            }
            break; // Lo solicitó el compilador por error CS0163.


        case 2:
            // Barajar.
            if (Opcion1 == true)
            {
                int nPersonas          = 0;
                int nCartasPorPersona  = 0;
                                
                Console.WriteLine(" ");
                Console.Write("¿Cuántas personas juegan?: ");
                nPersonas = int.Parse(Console.ReadLine());
                Console.Write("¿Cuántas cartas por persona?: ");
                nCartasPorPersona = int.Parse(Console.ReadLine());

                CartasContador = Class14.mBarajar(nPersonas, nCartasPorPersona, MazoInicio, MazoMezclado, MazoMezcladoNuevo, MazoTemp);
                Opcion2        = true;

                break;


            }

            if (Opcion1 == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Debe mezclar las cartas antes de repartir (Opción 1).");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;


            }
            break; // Lo solicitó el compilador por error CS0163.


        case 3:
            // Mostrar siguiente carta.
            if (Opcion1 == true)
            {
                Console.WriteLine(" ");
                Console.Write("La siguiente carta del mazo es: ");
                Console.WriteLine(Class14.mMostrarSiguiente(CartasContador, MazoMezcladoNuevo, MazoTemp));
                Console.WriteLine(" ");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;



            }

            if (Opcion1 == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Debe mezclar las cartas antes de mostrar la siguiente carta (Seleccionar Opción 1).");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;



            }
            break; // Lo solicitó el compilador por error CS0163.


        case 4:
            // Mostrar cartas disponibles.
            if (Opcion1 == true && Opcion2 == true)
            {
               Class14.mCartasDisponibles(CartasContador, MazoMezcladoNuevo, MazoTemp);
              
               break;


            }

            if (Opcion1 == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Debe mezclar las cartas y repartirlas antes de mostrar las que quedan disponibles (Seleccionar Opción 1, luego Opción 2).");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;



            }
            break; // Lo solicitó el compilador por error CS0163.


        case 5:
            // Dar cartas.
            if (Opcion1 == true)
            {
                int nPersonas1 = 0;
                int nCartasPorPersona1 = 0;
                Class14.BarajarDeNuevo(MazoInicio, MazoTemp, MazoMezclado, MazoMezcladoNuevo, false);
                Console.WriteLine("Se realizó una nueva mezcla de cartas antes de dar de nuevo.");
                Console.WriteLine(" ");
                Console.Write("¿Cuántas personas juegan?: ");
                nPersonas1 = int.Parse(Console.ReadLine());
                Console.Write("¿Cuántas cartas por persona?: ");
                nCartasPorPersona1 = int.Parse(Console.ReadLine());

                CartasContador = Class14.mBarajar(nPersonas1, nCartasPorPersona1, MazoInicio, MazoMezclado, MazoMezcladoNuevo, MazoTemp);

                break;



            }
            
            if (Opcion1 == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Debe mezclar las cartas antes de repartir (Seleccionar Opción 1).");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;



            }
            break; // Lo solicitó el compilador por error CS0163.


        case 6:
            //Mostrar cartas del montón.
            if (Opcion1 == true)
            {
                Class14.mMostrarMonton(CartasContador, MazoMezcladoNuevo);

                break;

            

            }
            
            if (Opcion1 == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Debe mezclar las cartas antes de mostrar el montón (Seleccionar Opción 1, después Opción 2).");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;



            }
            break; // Lo solicitó el compilador por error CS0163.


        case 7:
            // Mostrar baraja.
            if (Opcion1 == true)
            {
                Class14.mMostrarBaraja(CartasContador, MazoMezcladoNuevo);

                break;



            }
            

            if (Opcion1 == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Debe mezclar las cartas antes de mostrar la baraja (Seleccionar Opción 1).");
                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();

                break;


            }
            break; // Lo solicitó el compilador por error CS0163.


        case 8:
            // Salir.
            break;
        
        default:
            
            Console.WriteLine(" ");
            Console.WriteLine("Opción no válida.");
            Console.WriteLine("Presione una tecla para continuar. Si desea salir, después seleccione la opción 8.");
            Console.ReadKey();
            break;



    }
    
    if (OpcionUsuario == 8)
    {
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine("Chau! Chau!");
        Console.WriteLine("Chau! Chau!");
        Console.WriteLine("Chau! Chau!");
        Console.WriteLine(" ");
        break;

    }



}








