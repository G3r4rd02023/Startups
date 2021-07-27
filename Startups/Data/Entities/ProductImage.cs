using System.ComponentModel.DataAnnotations;

namespace Startups.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        [Display(Name = "Imagen")]
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://myleasing.azurewebsites.net{ImageUrl.Substring(1)}";

        public Product Product { get; set; }

    }
}
