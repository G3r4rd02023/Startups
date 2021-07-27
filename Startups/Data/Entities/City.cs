using System.ComponentModel.DataAnnotations;

namespace Startups.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
