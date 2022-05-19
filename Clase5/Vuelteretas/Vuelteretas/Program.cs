// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Cuantas vueltas quiere dar?");

//var respuesta = "S";
//var contador = 0;

//while (respuesta.ToUpper()!="N")
//{
//    contador++; //contador = contador + 1;
//    Console.WriteLine("Seguimos dando vueltas, vuelta numero: " + contador);

//    Console.WriteLine("Seguimos? (S/N)");
//    respuesta = Console.ReadLine();
//}



//   decl.             cond.          paso
for (var cantCara = 0; cantCara <= 12; cantCara+=2)
{



    Console.Clear();

Console.WriteLine("Ingrese su nombre completo por favor:: ";
string nombrePersona  = Console.ReadLine():

//Opción 1
Console.WriteLine("!Hola + nombrePersona");

//Opción 2
Console.WriteLine($"!Hola {nombrePersona});

Console.Write("Desea continuar (S/N): ");
string varSigue          = Console.ReadLine();
string varMayuscula = varSigue.ToUpper();

if varMayuscula == "S"
{
     Console.Clear();
     Console.WriteLine("Ingrese su nombre completo por favor:: ";
     string nombrePersona  = Console.ReadLine():

    //Opción 1
    Console.WriteLine("!Hola + nombrePersona");

    //Opción 2
    Console.WriteLine($"!Hola {nombrePersona});

    Console.Write("Desea continuar (S/N): ");
    string varSigue          = Console.ReadLine();
    string varMayuscula = varSigue.ToUpper();
}
else
{  
  if varMayuscula == "N"
  {
     Console.WriteLine("Programa finalizado correctamente");
   }
   else
   {
     Console.WriteLine("Programa finalizado. Opción no válida");
   }
}


    Console.WriteLine($"Mi bolsita tiene {cantCara} caramelos");
    //RECORDAR !!!! el paso lo hace al finalizar la ejecución
}
