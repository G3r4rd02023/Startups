using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Startups.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Empresa")]
        public int CompanyId { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Categoría")]
        public int CategoryId { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public Category Category { get; set; }

        public Company Company { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }

    }
}
