using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IHombre: IEntidad
    {
        public string Nombre { get; set; }        
        public string Apellido { get; set; }
        void Nacer();
        void Morir();
        
    }
}
