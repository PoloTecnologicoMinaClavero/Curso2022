/* Clase 13: Ejercicio - Billetera
Eugenio Serrano
•
Ayer
100 puntos
Fecha de entrega: 22 jun
Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes) */



// Instrucciones en consola:
// dotnet new console
// dotnet new classlib -o Ejercicio13



/*******************************************************************************************************
*  ZAPPIA, JULIAN MARCELO | Ejercicio 13 | Curso C#.NET | Polo Tecnológico Mina Clavero                *
********************************************************************************************************
*  Descripción: Class1.cs de Ejercicio 13. "Billetera". Archivo de Clase.                              *
*  Autor:       Julián Marcelo Zappia.                                                                 *
*  Fecha:       10/06/2022 al 11/06/2022                                                               *
********************************************************************************************************/


using static Clase13.GrupoBilletera;

namespace Clase13
{
    // Clase generada automáticamente por el depurador de VS2022. Solamente le puse el nombre.
    public static class GrupoBilletera
    {
        // Arrojaba error Gravedad	Código	Descripción	Proyecto	Archivo	Línea	Estado suprimido
        // Error CS0116  Un espacio de nombres no puede contener directamente miembros como campos, métodos o instrucciones Clase13, StringLibrary  C:\Users\Usuario\Source\Repos\PoloTecnologicoMinaClavero\Curso2022\Ejercicios\Clase13\StringLibrary\Class1.cs	87	Activo
        // Por ello la definición public staric void.

        // Estas son las Propiedades de las Billeteras.
        // Los cambios de get y set fueron sugeridos por VS2022 debido a errores.
        
        public static int BilletesDe10 { get; set; }
        public static int BilletesDe20 { get; set; }
        public static int BilletesDe50 { get; set; }
        public static int BilletesDe100 { get; set; }
        public static int BilletesDe200 { get; set; }
        public static int BilletesDe500 { get; set; }
        public static int BilletesDe1000 { get; set; }


        // Creo Clase Billetera.
        public static class Billetera
        {
            public static void ConstructorBilletera()
            {
                Console.WriteLine(" ");
                Console.WriteLine("Se ha inicializado el contructor ConstructorBilletera()");
                Console.WriteLine(" ");
                Console.WriteLine("Se documentan errores de inicio de clase.");
                Console.WriteLine();
                Console.WriteLine("Se ha inicializado una Clase StringLibrary (forzada por VS2022) renombrada a Billeteras.");
                Console.WriteLine("Se ha inicializado un Contructor BilleterasConstructor().");
                Console.WriteLine("Ni idea para qué sirve.");
                Console.WriteLine(" ");

            }

        }

    }

    public static class BilleteraNueva
    {
        // Genero una nueva clase "BilleteraNueva".
        // Ingreso valores a la nueva Billetera con un Método / Función / Procedimiento.
        public static void CrearNuevaBilletera()
        {
            Console.WriteLine(" ");

            public BilleteraNueva.Nomb = "El monto de la billetera de Victoria y Agustina es de $ ";
            public BilleteraNueva.NumB = 0;
            
            BilletesDe10               = 0;
            BilletesDe20               = 0;
            BilletesDe50               = 0;
            BilletesDe100              = 0; 
            BilletesDe200              = 0;
            BilletesDe500              = 0;
            BilletesDe1000             = 0;
            
            Console.Write("Ingrese la cantidad de billetes de 10 pesos:   ");
            BilletesDe10 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de billetes de 20 pesos:   ");
            BilletesDe20 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de billetes de 50 pesos:   ");
            BilletesDe50 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de billetes de 100 pesos:  ");
            BilletesDe100 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de billetes de 200 pesos:  ");
            BilletesDe200 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de billetes de 500 pesos:  ");
            BilletesDe500 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de billetes de 1000 pesos: ");
            BilletesDe1000 = int.Parse(Console.ReadLine());

            NumB = (BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) + (BilletesDe100 * 100) + (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000);

            
        }

    }

    // Genero clase para Métodos.
    public static class mBillete
    {
        // Aquí, pude retornar una variable declarada. 
        public static string TotalBilletes(string nombreBilletera, int numeroBilletes)
        {
            string NombreBilletera = nombreBilletera;
            int NumeroBilletes     = numeroBilletes;
            Console.WriteLine(" ");
            string Retorno         = NombreBilletera + NumeroBilletes.ToString() + " billetes.";
            
            return Retorno;

        }

        // Cantidad de Billetes por denominación.
        // Aquí, pude retornar una variable declarada. 
        public static string BilletesPorDenominacion()
        {
            Console.WriteLine(" ");
            string Devuelvo = "Total de Billetes por denominación." + "\n" + "\n" + "Billetes de 10 pesos: " + BilletesDe10.ToString() + "\n" + "Billetes de 20 pesos: " + BilletesDe20.ToString() + "\n" + "Billetes de 50 pesos: " + BilletesDe50.ToString() + "\n" + "Billetes de 100 pesos: " + BilletesDe100.ToString() + "\n" + "Billetes de 500 pesos: " + GrupoBilletera.BilletesDe500.ToString() + "\n" + "Billetes de 1000 pesos: " + GrupoBilletera.BilletesDe1000.ToString();

            return Devuelvo;

        }


        // Total de la Billetera.
        // No pude lograr una variable de retorno String.
        // No puedo convertir valor double a string.
        public static string TotalBilletera(string nombre, double num)
        {
            string mNombre = nombre;
            double mNumero = num;
            Console.Write(mNombre);
            Console.WriteLine(mNumero);
           // Console.WriteLine(" ");

            return "";

        }


        // Total de la nueva Billetera (código redundante).
        public static double TotalBilleteraNueva(string nombre, double num)
        {
            
            return ((BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) + (BilletesDe100 * 100) + (BilletesDe200 * 200) + ((BilletesDe500 * 500) + (BilletesDe1000 * 100)));

        }
                

        // Genero Método / Función para almacenar los totales de billeteras antes de ponerlas en 0.
        public static double AlmacenoBilleteras(double V1, double V2)
        {
            double totalBilletera1    = V1;
            double totalBilletera2    = V2;
            double TotalDosBilleteras = totalBilletera1 + totalBilletera2;

            Console.WriteLine(" ");
            return 0000000000000000000000000000000000000000000000000000000000000000000000000000;
            Console.WriteLine(" ");

        }

    
        // Esta es la combinación de Billeteras. No puedo convertir tipo double a string.
        public static double CombinarBilleteras(double T1, double T2)
        {
            double BilleteraCombinada = T1 + T2;
            T1                        = 0;
            T2                        = 0;
            Console.Write("La Combinación de las Billeteras de Julián y Victoria / Agustina arroja un total de $ ");

            return BilleteraCombinada;

            Console.WriteLine("Ambas billeteras quedaron vacías");
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para finalizar.");
            Console.ReadKey();

        }

           

    }

}   
