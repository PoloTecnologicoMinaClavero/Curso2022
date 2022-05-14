// Programa Ejercicio Clase 6

// Arroja error. Solicita cambiar a "var".
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

int numeroIngreso = 0;
int numeroIntentos = 0;

var valorDecide = "S";


while (numeroIngreso != numeroSecreto)
{
    // No pude realizar un && en el While. Arroja error.agregandi && (numeroIngreso == numeroSecreto). Dice que son tipos diferentes.
    Console.WriteLine("Este programa es para averiguar el número secreto");
    Console.Write("Por favor, ingrese un valor numérico del 1 al 20:  ");

    numeroIngreso = int.Parse(Console.ReadLine());

    numeroIntentos = numeroIntentos++;

    if (numeroIngreso == numeroSecreto)

    {
        Console.WriteLine("Genio!! Descubriste el número secreto");
        Console.WriteLine("El número secreto es : " + numeroIngreso);
        Console.WriteLine($"Lo averiguaste en {numeroIntentos} intentos");
    }
    else
    {
        if (numeroIngreso > numeroSecreto)
        {
            Console.Write("Número equivocado. Es MAYOR al número secreto. ¿Desea intentarlo nuevamente? (S/N) ");
            valorDecide = Console.ReadLine();

            // No toma el operador ||. Arroja error.No permite validar Null.La variable valorDecide no es reconocida.
            if ((valorDecide.ToUpper() = "N") || (valorDecide = "")) ;
            {
                break;
            }
        }
        else
        {
            Console.Write("Número equivocado. Es MENOR al número secreto. ¿Desea intentarlo nuevamente? (S/N) ");
            valorDecide = Console.ReadLine();

            // No toma el operador ||. Arroja error.No permite validar Null.La variable valorDecide no es reconocida.
            if ((valorDecide.ToUpper() = "N") || (valorDecide = "")) ;
            {
                break;
            }
        }

    }

}
Console.WriteLine("Programa finalizado...");
Console.ReadKey();

//Por favor, necesito nueva explicación de condiciones múltiples con los distintos operadores lógicos y diferentes tipos de datos.
// No pude hacer el while con dos condiciones. Por eso elegí agregar el "if".
//¿Por qué no se reconoce la variable "valorDecide" declarándola tanto como string o var?
// El error para varDecide es Gravedad	Código	Descripción	Proyecto
// Archivo	Línea	Estado suprimido
// Error CS0131	La parte izquierda de una asignación debe ser una variable, una propiedad o un indizador	Clase6	C:\Users\Usuario\Documents\GitHub\PoloTecnologicoMinaClavero\Curso2022\Ejercicios\Clase6\Ejercicio_Clase6_Zappia_Julián_1.cs    37  Activo



