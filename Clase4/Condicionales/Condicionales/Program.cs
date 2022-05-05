/* Ejemplo de condional If  */

////Le pedimos al usuario que ingrese su edad
//Console.Write("Ingrese su edad: "); 
////Obtenemos la edad por teclado
//int edad = int.Parse(Console.ReadLine()); 

//Console.Write("Ingrese su equipo de futbol: ");
//string equipo = Console.ReadLine();

//Console.WriteLine("La edad ingresada es: " + edad);

///*
//    AND -> && (Y)
//    OR -> || (O)
//    Igual que -> ==
//    Distinto que -> !=
//*/

//bool condicion = edad < 18 && equipo == "River";

////Evaluamos la edad
//if (condicion) 
//{
//    //Intrucciones si se cumple la condicion evaluada
//    Console.WriteLine("Usted es menor de edad.");
//    Console.WriteLine("Prohibida la entrada");
//}
//else
//{
//    //Instrucciones si no se cumple la condicion evaluada
//    Console.WriteLine("Usted es mayor de edad.");
//}


/* Ejemplo if-elseif-else */

//Console.Write("Ingrese la edad: ");
//int edad = int.Parse(Console.ReadLine());

//if (edad < 0 || edad > 110)
//{
//    Console.WriteLine("La edad no es valida.");
//}
//else if (edad < 12)
//{
//    Console.WriteLine("Va a la primaria.");
//}
//else if (edad < 18)
//{
//    Console.WriteLine("Va al secundario.");
//}
//else if (edad < 28)
//{
//    Console.WriteLine("Va a la facultad.");
//}
//else
//{
//    Console.WriteLine("A trabajar no queda otra.");
//}

/* Ejemplo del switch */

Console.WriteLine("Ingrese el primer numero: ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicacion");
Console.WriteLine("4 - Division");

Console.WriteLine("Ingrese la operacion a realizar");
string  operacion = Console.ReadLine();

double resultado = 0;

switch (operacion)
{
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 != 0:
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Ingreso una opcion no valida");
        break;
}

Console.WriteLine("El resultado es: " + resultado);


//Lo que continue.....





















