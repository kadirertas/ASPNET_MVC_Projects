using CoffeApp.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoffeApp.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {


        }



        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Products { get; set; }


        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasKey(u => u.ProductId);
            modelBuilder.Entity<Users>().HasKey(u => u.UserId);
        }








    }
}
