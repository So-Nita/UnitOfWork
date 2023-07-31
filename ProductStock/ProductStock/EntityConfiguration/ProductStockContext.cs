using Microsoft.EntityFrameworkCore;
using ProductStock.Model.Product;
using System.Reflection;

namespace ProductStock.EntityConfiguration
{
    public class ProductStockContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductStockContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
