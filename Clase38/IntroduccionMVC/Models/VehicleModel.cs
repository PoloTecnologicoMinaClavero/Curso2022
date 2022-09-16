using System.ComponentModel.DataAnnotations;

namespace IntroduccionMVC.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El dominio del vehículo es un campo obligatorio.")]
        [StringLength(7,ErrorMessage = "El dominio debe contener 6 o 7 caracteres",MinimumLength = 6)]
        public string Dominio { get; set; }

        [Required(ErrorMessage = "El número de chasis es un campo obligatorio.")]
        public string NumeroChasis { get; set; }

        [Required(ErrorMessage = "El propietario es un campo obligatorio.")]
        public string Propietario { get; set; }

        [Required(ErrorMessage = "El año de fabricación es un campo obligatorio.")]
        public int AnioFabricacion { get; set; }
    }
}
