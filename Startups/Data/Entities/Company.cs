using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Startups.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "Empresa")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        [Display(Name = "Telefono")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Phone { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Address { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "Imagen")]
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
           ? null
           : $"https://TDB.azurewebsites.net{ImageUrl.Substring(1)}";

        public int CityId { get; set; }

        public int CountryId { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
