/*******************************************************************************************************
*  ZAPPIA, JULIAN MARCELO | Ejercicio 14 | Curso C#.NET | Polo Tecnológico Mina Clavero                *
********************************************************************************************************
*  Descripción: Class1.cs de Ejercicio 14. "Barajas españolas". Archivo de Clases.                     *
*  Autor:       Julián Marcelo Zappia.                                                                 *
*  Fecha:       12/06/2022 al 15/06/2022                                                               *
********************************************************************************************************/


// Using del Sistema. Muchos agregados automáticamente por VS2022.

using System;
using Baseline.ImTools;
//using ImTools;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using LamarCodeGeneration.Util;
using Baseline;


// Armo espacio.

namespace Clase14
{
    // Configuro Clase.

    public class Class14
    {
        //Inicializo Vector de Mazo Completo.

        public static string[] CargarVector1(string[] nMazoCompleto)
        {
            for (var i = 0; i < 40; i++)
            {
                nMazoCompleto[i] = (i + 1).ToString();


            }
            return nMazoCompleto;

        }


        // Inicializo vector de solo Números de Cartas.
        public static string[] CargarVector2(string[] nMazoNumeros)
        {
            for (var i = 0; i < 12; i++)
            {
                nMazoNumeros[i] = (i + 1).ToString();


            }
            return nMazoNumeros;

        }


        // Incializo vector de Palos de Cartas.
        public static string[] CargarVector3(string[] nMazoPalos)
        {
            nMazoPalos[0] = " - Espadas.";
            nMazoPalos[1] = " - Oros.   ";
            nMazoPalos[2] = " - Copas.  ";
            nMazoPalos[3] = " - Bastos. ";

            return nMazoPalos;

        }

        // Inicializo vector temporal para intercambio.

        public static bool InicializarNMazo(string[] nMazoTemp)
        {
            for (int i = 1; i < 48; i++)

            {
                nMazoTemp[i] = 0.ToString();

            }

            return true;
        }


        // Genero Mazo Comnpleto ---> Numero de Carta + Palo.

        public int Bucle { get; set; }
       
        public static string[] ArmarMazo(int nCartaBucleNumero, int nCartaBuclePalo, int nPalo, string[]? nMazoNumeros, string[]? nMazoPalos, string[]? nMazo)
        {

            for (int Bucle = 0; Bucle < 48; Bucle++)
            {

                nCartaBucleNumero = nCartaBucleNumero + 1;

                if (nCartaBucleNumero is not 8 and not 9)
                {
                    nMazo[Bucle] = nCartaBucleNumero.ToString() + nMazoPalos[nCartaBuclePalo];


                }


                if (nCartaBucleNumero > 11)
                {
                    nCartaBucleNumero = 0;
                    nCartaBuclePalo = (nCartaBuclePalo + 1);


                }




            }

            return nMazo;



        }


        // Limpio Mazo de 8 y 9.

        public static int Bucle1 = 0;
        public static int Bucle2 = 0;
        public static bool ExpresionLogica = false;


        public static string[] LimpiarMazo(string[]? Mazo, string[]? MazoLimpio)
        {
            for (Bucle1 = 0; Bucle1 < 48; Bucle1++)
            {
                ExpresionLogica = (Mazo[Bucle1] == 0.ToString());

                if (!ExpresionLogica)
                {
                    MazoLimpio[Bucle2] = Mazo[Bucle1];
                    Bucle2 = Bucle2 + 1;


                }


            }

            Bucle1 = 0;
            Bucle2 = 0;

            return MazoLimpio;

        }


        // Mezclo / Barajo cartas (mezcla inicial).

        public static string[] Barajar(string[]? MazoInicio, string[]? MazoTemp, string[]? MazoMezclado, string[]? MazoMezcladoNuevo, bool VoF)
        {
            int indice    = 0;
            int LongArray = MazoInicio.Length;
            int Jota      = 0;
            int Ka        = 0;

            Random Algoritmo = new Random();
            Algoritmo.Next(1, LongArray);

            
            for (int z = 0; z < LongArray; z++)
            {
                MazoTemp[z]          = MazoInicio[z];
                MazoMezclado[z]      = MazoInicio[z];
                MazoMezcladoNuevo[z] = MazoInicio[z];


            }


            indice = Algoritmo.Next(1, LongArray);
            Jota = 0;
            Ka = 0;


            for (Ka = 0; Ka < 3; Ka++)
            {
                while (Jota < LongArray && indice > 0 && indice < LongArray)
                {

                    VoF       = (MazoMezcladoNuevo[Jota] != 0.ToString());
                    Algoritmo = new Random();
                    indice    = Algoritmo.Next(1, LongArray);


                    if (VoF)
                    {
                        MazoMezcladoNuevo[Jota] = MazoTemp[indice];
                        Algoritmo               = new Random();
                        indice                  = Algoritmo.Next(1, LongArray);


                    }

                    if (Jota < 40)
                    {
                        Jota = Jota + 1;


                    }

                    if (Jota > 40)
                    {
                        break;


                    }

                }


            }
            return MazoMezcladoNuevo;

        }

        
        // Mezclo / Barajo Cartas (para nuevas mezclas).

        public static string[] BarajarDeNuevo(string[]? MazoLimpio, string[]? MazoTemp, string[]? MazoMezclado, string[]? MazoMezcladoNuevo, bool VoF)
        {
            int indice    = 0;
            int LongArray = MazoLimpio.Length;
            int Jota      = 0;
            int Ka        = 0;

            Random Algoritmo = new Random();
            Algoritmo.Next(1, LongArray);

            
            for (int z = 0; z < LongArray; z++)
            {
                MazoTemp[z]          = MazoLimpio[z];
                MazoMezclado[z]      = MazoLimpio[z];
                MazoMezcladoNuevo[z] = MazoLimpio[z];


            }


            indice = Algoritmo.Next(1, LongArray);
            Jota = 0;
            Ka = 0;


            for (Ka = 0; Ka < 5; Ka++)
            {
                while (Jota < LongArray && indice > 0 && indice < LongArray)
                {

                    VoF       = (MazoMezcladoNuevo[Jota] != 0.ToString());
                    Algoritmo = new Random();
                    indice    = Algoritmo.Next(1, LongArray);


                    if (VoF)
                    {
                        MazoMezcladoNuevo[Jota] = MazoTemp[indice];
                        Algoritmo               = new Random();
                        indice                  = Algoritmo.Next(1, LongArray);


                    }

                    if (Jota < 40)
                    {
                        Jota = Jota + 1;


                    }

                    if (Jota > 40)
                    {
                        break;


                    }

                }



            }
            return MazoMezcladoNuevo;



        }

        // Convierto Arrays en Listas.
        public static void MazoToLista(string[] MazoCompleto, string[] MazoMezclado, string[] MazoMezcladoNuevo, List<string> ListaMazo, List<string> ListaMazoMezclado, List <string> ListaMazoMezcladoNuevo)
        {
            ListaMazo              = MazoCompleto.ToList();
            ListaMazoMezclado      = MazoMezclado.ToList();
            ListaMazoMezcladoNuevo = MazoMezcladoNuevo.ToList();

            ListaMazo.AddRange(MazoCompleto);
            ListaMazoMezclado.AddRange(MazoMezclado);
            ListaMazoMezcladoNuevo.AddRange(MazoMezcladoNuevo);


            for (int i = 0; i < MazoCompleto.Length; i++)
            {
                ListaMazo.Add(MazoCompleto[i]);
                ListaMazoMezclado.Add(MazoMezclado[i]);
                ListaMazoMezcladoNuevo.Add(MazoMezcladoNuevo[i]);


            }
            
            

        }


        public static void MazoToPila(string[] MazoCompleto, string[] MazoMezclado, string[] MazoMezcladoNuevo, Stack<string> ListaMazo, Stack<string> ListaMazoMezclado, Stack<string> ListaMazoMezcladoNuevo)
        {
            // No necesita código. Conversión en Program.cs



        }


        public static int mBarajar(int nPersonas, int nCartasPorPersona, string[]? MazoInicio, string[]? MazoMezclado, string[]? MazoMezcladoNuevo, string[]? MazoTemp)
        {
            int ContadorCartas    = 0;
            var MazoTempTemp      = new string("");
            
            for (int i = 0; i < nPersonas; i++)
            {
                for (int k = 0; k < nCartasPorPersona; k++)
                {
                    ContadorCartas = ContadorCartas + 1;
                    MazoTemp[k]    = "Al jugador Nº " + (i + 1).ToString() + " le tocó la carta " + MazoMezcladoNuevo[ContadorCartas];


                }
                
                Console.WriteLine(" ");
                Console.WriteLine("Se muestra lo repartido hasta el momento.");
                Console.WriteLine(" ");

                for (int j = 0; j < MazoTemp.Length; j++)
                {
                    MazoTempTemp = MazoTemp[j];

                    if (MazoTempTemp != 0.ToString())
                    {
                        string MazoTempTempTemp = MazoTemp[j].Substring(0, 2);

                        if (MazoTempTempTemp == "Al")
                        {
                            Console.WriteLine(MazoTemp[j]);

                        }


                    }
                    
                                       
                }

                Console.WriteLine("Presione una tecla para continuar.");
                Console.ReadKey();
                Console.WriteLine(" ");

                

            }
            
            for (int m = 0; m < MazoTemp.Length; m++)
            {

                MazoTemp[m] = 0.ToString();


            }
            return ContadorCartas;


        }


        public static string mMostrarSiguiente(int CartasContador, string[]? MazoMezcladoNuevo, string[]? MazoTemp)
        {

            return MazoTemp[CartasContador + 1];


        }


        public static void mCartasDisponibles(int CartasContador, string[]? MazoMezcladoNuevo, string[]? MazoTemp)
        {
            string Sale = "";

            for (int i = (CartasContador + 1); i < MazoMezcladoNuevo.Length; i++)
            {
                Sale = Sale + MazoMezcladoNuevo[i] + "\n";
                

            }
            Console.WriteLine(" ");
            Console.WriteLine("Cartas disponibles en el mazo después de repartir.");
            Console.WriteLine(" ");
            Console.WriteLine(Sale);
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();


        }


        public static void mDarCartas(int nPersonas1, int nCartasPorPersona1, string[]? MazoMezcladoNuevo)
        {
            // Se utilizó el mismo procedimiento que el de Opción 2.


        }


        public static void mMostrarBaraja(int CartasContador, string[]? MazoMezcladoNuevo)
        {
            string SalidaDatos = "";

            for (int i = MazoMezcladoNuevo.Length - CartasContador; i < MazoMezcladoNuevo.Length; i++)
            {
                SalidaDatos = SalidaDatos + MazoMezcladoNuevo[i] + "\n";


            }

            Console.WriteLine(" ");
            Console.WriteLine("Las cartas restantes en el mazo que ya fueron mezcladas son: ");
            Console.WriteLine(" ");
            Console.WriteLine(SalidaDatos);
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();


        }


        public static void mMostrarMonton(int CartasContador, string[]? MazoMezcladoNuevo)
        {
            string SalidaDatos1 = "";

            for (int i = 0; i < MazoMezcladoNuevo.Length; i++)
            {
                SalidaDatos1 = SalidaDatos1 + MazoMezcladoNuevo[i] + "\n";


            }

            Console.WriteLine(" ");
            Console.WriteLine("Acá está todo el montón de cartas!");
            Console.WriteLine(" ");
            Console.WriteLine(SalidaDatos1);
            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();


        }




    }




}








         






