using System;
using System.Text.RegularExpressions;

string respuesta = "S";

while (respuesta == "S")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre: ");
    string nombre = Console.ReadLine().ToUpper();

    if (Regex.IsMatch(nombre, @"^[0-9]+|[^\w ]$") || nombre.Contains(" ") || nombre == null || nombre.Length == 0)
    {
        Console.WriteLine("Debe ingresar un nombre válido");
    }
    else
    {
        Console.WriteLine($"¡Hola {nombre}!");           
    }

    Console.WriteLine("Desea continuar? (S/N)");
    respuesta = Console.ReadLine().ToUpper();
        
    if (respuesta == "N")
    {
        Console.WriteLine("Programa finalizado correctamaente");
    }
    else if (respuesta != "N" || respuesta != "S")
    {
        Console.WriteLine("Opción no válida");
    } 
    
}
