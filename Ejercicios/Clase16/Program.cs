/*Clase 16: Ejercicio - Cuadriláteros
Eugenio Serrano
•
17 jun (Última modificación: 17 jun)
100 puntos


Diseñe la siguiente jerarquía para las clases:

Cuadrilátero.
Trapecio.
Rectángulo.
Cuadrado.

Use la clase Cuadrilátero como la clase base de la jerarquía, 
que debe ser abstracta.

Los datos privados de la clase base deben ser las coordenadas x-y 
de los cuatro vértices de la figura y debe contener un método abstracto 
para calcular el área.

Agregue un constructor a cada clase para inicializar sus datos 
e invoque el constructor de la clase base desde el constructor 
de cada clase derivada.

Escriba un programa que instancie objetos de cada una de las clases 
y calcule el área correspondiente. 

Investigue las fórmulas para calcular el área de cada figura.*/


/*************************************************************************************************************
* Programa: Program.cs                                                                                       *
**************************************************************************************************************
* Descripción: Clase 16 - Resolución de ejercicio - Polo Tecnológico Mina Clavero - Curso C#                 *
* Autor      : Julián Marcelo Zappia                                                                         *
* Fecha      : 25/06/2022                                                                                    *
*************************************************************************************************************/

/* Area Cuadrilátero            = base * altura.
 * Area Cualquier Paralelogramo = base * altura.
 * Area Rombo                   = (diagonal1 * diagonal2) / 2.
 * Trapecio                     = ((base1 + base2) * 2) / altura.
 * Cuadrado                     = base * altura.
 * Triángulo                    = (base * altura) / 2.
 */
 

using System;
using nInicio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


var varInicial = nInicio.Inicializar.ReferenceEquals;


MenuCalculos(true);


static void MenuCalculos(bool OpcionLogica)
{
    int nCorte     = 1;
    int nResultado = 0;

    while (OpcionLogica)
    {
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("* Ejercicio Clase 16 - Cálculos de Area / Superficie de polígonos.                                           *");
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine("*                                                                                                            *");
        Console.WriteLine("* Ingrese la opción del cálculo de superficie que desea realizar.                                            *");
        Console.WriteLine("*                                                                                                            *");
        Console.WriteLine("**************************************************************************************************************");
        Console.WriteLine(" ");
        Console.WriteLine("(1) - Cálculo de superficie de un Cuadrado.");
        Console.WriteLine("(2) - Cálculo de superficie de un Triángulo.");
        Console.WriteLine("(3) - Calculo de superficie de un Trapecio.");
        Console.WriteLine("(4) - Cálculo de superficie de un Rectángulo.");
        Console.WriteLine("(5) - Salir.");
        Console.WriteLine(" ");
        Console.Write("Ingrese la Opción deseada: ");
        
        int nTecla = 0;
        
        nTecla = int.Parse(Console.ReadLine());

        if (nTecla >= 5 || nTecla == 0)
        {
            nCorte = 0;

        }


        if (nCorte == 0)
        {
            OpcionLogica = false;

        }


        if (nTecla > 0 && nTecla < 5)
        {
            DefineClases.iCalculando.Calculando(nTecla, nResultado);


        }

        
    }


}


namespace DefineClases
{
    public interface iCalculando
    {
        public static void Calculando(int nTecla, int nResultado)
        {
            string[] Leyenda  = new string[4];
            string[] Ecuacion = new string[4];
            
            Leyenda[0]        = "Seleccionó el cálculo de superficie de un Cuadrado.";
            Leyenda[1]        = "Seleccionó el cálculo de superficie de un Triángulo.";
            Leyenda[2]        = "Seleccionó el cálculo de superficie de un Trapecio.";
            Leyenda[3]        = "Seleccionó el cálculo de superficie de un Rectángulo.";

            Ecuacion[0]       = "nBase * nBase";
            Ecuacion[1]       = "(nBase * nAltura) / 2";
            Ecuacion[2]       = "((nBase1 + nBase2) * 2) / altura";
            Ecuacion[3]       = "nBase * nAltura";

            nResultado    = 0;

            Console.WriteLine(" ");
            Console.WriteLine(Leyenda[nTecla - 1]);

            
            if (nTecla == 1)
            {
                int nBase = 0;
                
                Console.WriteLine(" ");
                Console.Write("Ingrese la longitud del lado (en Cm.): ");
                
                nBase      = int.Parse(Console.ReadLine());
                
                nResultado = (nBase * nBase);
                Console.WriteLine(" ");
                                

            }


            if (nTecla == 2)
            {
                int nBase   = 0;
                int nAltura = 0;
                
                Console.WriteLine(" ");
                Console.Write("Ingrese la longitud de la Base (en Cm.): ");
                nBase      = int.Parse(Console.ReadLine());
                
                Console.Write("Ingrese la longitud de la Altura (en Cm.): ");
                nAltura    = int.Parse(Console.ReadLine());
                
                nResultado = (nBase * nAltura) / 2;
                Console.WriteLine(" ");


            }


            if (nTecla == 3)
            {
                int nBase1  = 0;
                int nBase2  = 0;
                int nAltura = 0;
                
                Console.WriteLine(" ");
                Console.Write("Ingrese la longitud de la Base Primaria (en Cm.): ");
                nBase1     = int.Parse(Console.ReadLine());
                
                Console.Write("Ingrese la longitud de la Segunda Base (en Cm.): ");
                nBase2     = int.Parse(Console.ReadLine());
                                
                Console.Write("Ingrese la longitud de Altura (en Cm.): ");
                nAltura    = int.Parse(Console.ReadLine());
                
                nResultado = (((nBase1 * nBase2) * 2) * nAltura);
                Console.WriteLine(" ");


            }


            if (nTecla == 4)
            {
                int nBase   = 0;
                int nAltura = 0;
                
                Console.WriteLine(" ");
                Console.Write("Ingrese la longitud de la Base (en Cm.): ");
                nBase      = int.Parse(Console.ReadLine());
                
                Console.Write("Ingrese la longitud de Altura (en Cm.): ");
                nAltura    = int.Parse(Console.ReadLine());
                
                nResultado = (nBase * nAltura) / 2;


            }

            string CadenaSalida = ("La Superficie Calculada en Cms. es "); 
            Console.Write(CadenaSalida);
            Console.WriteLine(nResultado);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

    } 

    abstract class Cuadrilatero : DefineClases.iCalculando
    {
        int nTecla = 0;


    }

    
    class CualquierParalelogramo : Cuadrilatero
    {
        int nTecla = 0;


    }
    
    

    class Trapecio : Cuadrilatero
    {
        int nTecla = 0;


    }
    
        
    class Cuadrado : Cuadrilatero
    {
        int nTecla = 0;


    }

    
}



