using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Clases
{
    public partial class Persona
    {
        public Persona()
        {
            Nombre = "";
            Apellido = "";
        }

        public string Nombre { get; set; }

        public partial int CaludarEdad();
    }
}
