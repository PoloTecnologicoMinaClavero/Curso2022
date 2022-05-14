Console.Clear();

Console.WriteLine("Ingrese su nombre completo por favor:: ";
string nombrePersona  = Console.ReadLine():

//Opción 1
Console.WriteLine("!Hola + nombrePersona");

//Opción 2
Console.WriteLine($"!Hola {nombrePersona!");

Console.Write("Desea continuar (S/N): ");
string varSigue     = Console.ReadLine();
string varMayuscula = varSigue.ToUpper();

if varMayuscula == "S"
{
     Console.Clear();
     Console.WriteLine("Ingrese su nombre completo por favor:: ";
     string nombrePersona  = Console.ReadLine():

    //Opción 1
    Console.WriteLine("!Hola + nombrePersona");

    //Opción 2
    Console.WriteLine($"!Hola {nombrePersona}!";

    Console.Write("Desea continuar (S/N): ");
    string varSigue     = Console.ReadLine();
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