using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelo
{
    public abstract class Persona
    {
        private DateTime _fechaNacimiento;
        private int _numeroDeDocumento;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento
        {
            get
            {
                return _fechaNacimiento.ToString("dd/MM/yyyy");
            }
            set
            {
                _fechaNacimiento = Convert.ToDateTime(value);
            }
        }
        
        public string NumeroDeDocumento 
        {
            get
            {
                return _numeroDeDocumento.ToString();
            }
            set
            {
                int numeroDeDocumentoConvertido;
                var sePuedeConvertir = int.TryParse(value, out numeroDeDocumentoConvertido);
                if (!sePuedeConvertir)
                {
                    _numeroDeDocumento = 0;
                }
                else
                {
                    _numeroDeDocumento = numeroDeDocumentoConvertido;
                }
            } 
        }

        public int ObtenerEdad()
        {
            var fechaHoraActual = DateTime.Today;
            var edadDateTime = fechaHoraActual - _fechaNacimiento;

            return (int)edadDateTime.TotalDays / 365;
        }
    }
}
