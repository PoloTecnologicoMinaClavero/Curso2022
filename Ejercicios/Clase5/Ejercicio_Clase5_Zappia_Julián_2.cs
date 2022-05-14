Console.Clear(); 
string varMayuscula = "S" 


while (varMayuscula == "S") 

{ 

    Console.WriteLine("Ingrese su nombre completo por favor:: ";

    string nombrePersona = Console.ReadLine();

    //Opción 1  

    Console.WriteLine("!Hola + nombrePersona" + "!"); 

 
    //Opción 2 

    Console.WriteLine($"!Hola {nombrePersona}!"); 


    Console.Write("Desea continuar (S/N): "); 

    string varSigue = Console.ReadLine(); 
    varMayuscula    = varSigue.ToUpper(); 

    if (varMayuscula == "N") 

    { 

       Console.WriteLine("Programa finalizado correctamente"); 

    } 

    else 

   { 

      if (varMayuscula != "N" && varMayuscula != "S") 

      { 

         Console.WriteLine("Opción no válida. Malfunction!!!!");

         break;

      } 

   } 

} 


// Aquí está realizado con un bucle "WHILE", tal como fue muy bien sugerido por el compañero Guillermo Velasco. // Con trampita incluida.