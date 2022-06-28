using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelo
{
    public sealed class Empleado : Persona
    {
        private int _salarioBruto;

        public string Ocupacion { get; set; }
        public string Empresa { get; set; }
        public string ObraSocial { get; set; }

        public int SalarioBruto 
        {
            set => _salarioBruto = value;
        }

        public int SalarioNeto { get => ObtenerSalarioNeto(); }

        private int ObtenerSalarioNeto()
        {
            var salarioNeto = _salarioBruto * 0.85;
            return (int)salarioNeto;
        }
    }
}
