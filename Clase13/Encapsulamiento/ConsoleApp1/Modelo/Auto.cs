using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelo
{
    internal class Auto
    {
        //Campos
        private string _tipoDeMotor;
        private string _anioDeFabricacion;

        private bool _bujiasOkey;
        
        public string TipoDeMotor
        {
            get { return _tipoDeMotor; }
            set 
            { 
                if(value == null || value == "")
                {
                    _tipoDeMotor = "Nafta";
                }
                else
                {
                    _tipoDeMotor = value;
                }
            } 
        }

        //Propiedades autoimplementadas
        public bool EstaEncendido { get; set; }
        public int AnioDeFabricacion { get; set; }
        public string Marca { get; set; }
    }
}
