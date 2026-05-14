using EstoqueAPI.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace EstoqueAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ProductModel> Produtos { get; set; } 
    }
}
