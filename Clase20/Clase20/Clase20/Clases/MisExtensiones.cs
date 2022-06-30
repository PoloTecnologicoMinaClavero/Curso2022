using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Clases
{
    public static class MisExtensiones
    {
        public static int CalcularCredito(this Proveedor p)
        {
            if (p.Nombre == "Juan")
                return 100;
            
            return 0;
        }

        public static int ContarPalabras(this string s, char separador = ' ')        
        {
            return s.Split(separador).Length;
        }

        //public static int ContarPalabras(this string s, string separador)
        //{
        //    return s.Split(separador).Length;
        //}

      
    }
}
