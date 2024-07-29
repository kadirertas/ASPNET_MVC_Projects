using Ecommerce.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasKey(u => u.UserId);
        }
    }
    }

