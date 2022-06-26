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
* Programa: nIncializarBase.cs                                                                               *
**************************************************************************************************************
* Descripción: Clase 16 - Resolución de ejercicio - Archivo externo - Polo Tecnológico Mina Clavero - C#     *
* Autor      : Julián Marcelo Zappia                                                                         *
* Fecha      : 25/06/2022                                                                                    *
*************************************************************************************************************/

/* Area Cuadrilátero            = base * altura.
 * Area Cualquier Paralelogramo = base * altura.
 * Area Rombo                   = (diagonal1 * diagonal2) / 2.
 * Trapecio                     = ((base1 + base2) * 2) / altura.
 * Cuadrado                     = base * altura.
 * Triángulo                    = (base * altura) / 2
 */


namespace nInicio
{
    public abstract class Inicializar
    {
        
        int nBase       = 0;
        int nAltura     = 0;
        int nBase1      = 0;
        int nBase2      = 0;
        int nDiagonal1  = 0;
        int nDiagonal2  = 0;
        int nOpcion     = 0;

        double nRetorno = 0;

        public int nA;
        public int nB;
        public int nC;
        public int nD;
        public int nE;
        public int nF;
        public int nR;
        
        public int nResultado = 0;
        public int nTecla     = 0;
                

        public void Iniciar(int nBase, int nAltura, int nBase1, int nBase2, int nDiagonal1, int nDiagonal2, int nOpcion, int nRetorno)
        {
            this.nBase      = nBase;
            this.nAltura    = nAltura;
            this.nBase1     = nBase1;
            this.nBase2     = nBase2;
            this.nDiagonal1 = nDiagonal1;
            this.nDiagonal2 = nDiagonal2;
            this.nOpcion    = nOpcion;
            this.nRetorno   = nRetorno;


        }


    }
    

    
}
    







