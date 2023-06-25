using APIPractice.Models;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //for the many to many reltionships between the tables
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //one to many reltionship between travellers and bookings

        // base.OnModelCreating(modelBuilder);

        //  }

    
        public DbSet<Brand> brand { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<Supplier> suppliers { get; set; }

        public DbSet<Product> product { get; set; }

    }
}
