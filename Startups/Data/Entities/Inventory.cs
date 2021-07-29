using System.ComponentModel.DataAnnotations;

namespace Startups.Data.Entities
{
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

       
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Stock { get; set; }

        public Product Product { get; set; }

    }
}
