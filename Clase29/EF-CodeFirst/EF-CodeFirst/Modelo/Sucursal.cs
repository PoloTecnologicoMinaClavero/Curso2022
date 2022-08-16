using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Modelo
{
    public class Sucursal : EntidadBase
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        //public Domicilio Domicilio { get; set; }

        public List<Deposito> Depositos { get; set; }
    }
}
