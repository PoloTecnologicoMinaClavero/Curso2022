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

//Console.WriteLine("Ingrese el primer numero: ");
//double numero1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el segundo numero: ");
//double numero2 = double.Parse(Console.ReadLine());

//Console.WriteLine("1 - Suma");
//Console.WriteLine("2 - Resta");
//Console.WriteLine("3 - Multiplicacion");
//Console.WriteLine("4 - Division");

//Console.WriteLine("Ingrese la operacion a realizar");
//int operacion = int.Parse(Console.ReadLine());

//double resultado = 0;

//switch (operacion)
//{
//    case 1:
//        resultado = numero1 + numero2;
//        break;
//    case 2:
//        resultado = numero1 - numero2;
//        break;
//    case 3:
//        resultado = numero1 * numero2;
//        break;
//    case 4 when numero2 != 0:
//        resultado = numero1 / numero2;
//        break;
//    default:
//        Console.WriteLine("Ingreso una opcion no valida");
//        break;
//}

//Console.WriteLine("El resultado es: " + resultado);



/*  EJEMPLO If-Else anidados */


//int numero3; //Declaramos las variables

//Console.Write("Ingrese numero 1: ");
//var numero1 = int.Parse(Console.ReadLine()); //ingresamos el primer numero

//Console.Write("Ingrese numero 2: ");
//int numero2 = int.Parse(Console.ReadLine()); //Ingresamos el segundo numero

//Console.Write("Ingrese numero 3: ");
//numero3 = int.Parse(Console.ReadLine()); //Ingresamos el tercer numero

//if (numero1 > numero2) //numero1 es mayor
//{
//    //Instrucciones
//    if (numero1 > numero3) //numero1 es mayor
//    {
//        //Instrucciones
//        Console.WriteLine("El primer numero es el mayor: " + numero1);
//    }
//    else //numero3 es mayor
//    {
//        //Instrucciones
//        Console.WriteLine("El tercer numero es el mayor: " + numero3);
//    }
//}
//else //numero2 es mayor
//{
//    //Instrucciones
//    if (numero2 > numero3) //numero2 es mayor
//    {
//        //Instrucciones
//        Console.WriteLine("El segundo numero es el mayor: " + numero2);
//    }
//    else
//    {
//        //Instrucciones
//        Console.WriteLine("El tercer numero es el mayor: " + numero3);
//    }
//}


//Lo que continue.....

Console.WriteLine("Desea continuar? (S/N)");
var texto = Console.ReadLine();

if (texto.ToUpper() == "S")
{
    Console.WriteLine("Usted ingreso que SI");
}else if (texto.ToLower() == "n")
{
    Console.WriteLine("Usted ingreso que NO");
}
else
{
    Console.WriteLine("Usted no entendió nada");
}



















