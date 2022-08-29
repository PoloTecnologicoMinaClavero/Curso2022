using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Modelo
{
    public class Producto : EntidadBase
    {
        //Usamos DataAnnotations para darle atributos de mapeo a las propiedades
        
        public int Codigo { get; set; }

        [MaxLength(50)]
        [Required]
        public string Descripcion { get; set; }

        public int Peso { get; set; }
        public DateTime FechaElaboracion { get; set; }

        public Marca Marca { get; set; }
    }
}
