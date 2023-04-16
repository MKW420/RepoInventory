using APIPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPractice.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //for the many to many reltionships between the tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many reltionship between travellers and bookings

            base.OnModelCreating(modelBuilder);

        }


        public virtual DbSet<Brand> brands { get; set; }
    }
}
