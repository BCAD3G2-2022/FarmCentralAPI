using Microsoft.EntityFrameworkCore;
using FarmCentralAPI;

namespace FarmCentralAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Product> ProductTypes { get; set; }

        public DbSet<FarmCentralAPI.ProductType>? ProductType { get; set; }
    }
}
