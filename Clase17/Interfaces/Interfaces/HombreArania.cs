using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class HombreArania : Entidad, IHombre, IArania
    {        

        public string Nombre { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string Apellido { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public void Cazar()
        {
            throw new NotImplementedException();
        }

        public void HacerTela()
        {
            throw new NotImplementedException();
        }

        public void Morir()
        {
            throw new NotImplementedException();
        }

        public void Nacer()
        {
            throw new NotImplementedException();
        }
    }
}
