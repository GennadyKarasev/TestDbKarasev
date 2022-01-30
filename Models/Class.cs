using Microsoft.EntityFrameworkCore;

namespace TestDbKarasev.Models
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public ProductsContext (DbContextOptions <ProductsContext> options)
            : base (options)
        {
            Database.EnsureCreated();
        }

    }
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
