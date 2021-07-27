using Microsoft.EntityFrameworkCore;

namespace Startups.Data.Entities
{
    public class DataContext : DbContext
	{
		public DbSet<City> Cities { get; set; }

		public DbSet<Country> Countries { get; set; }

		public DbSet<Company> Companies { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<ProductImage> ProductImages { get; set; }


		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
	}

}
