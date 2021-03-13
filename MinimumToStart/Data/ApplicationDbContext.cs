using Microsoft.EntityFrameworkCore;
using MinimumToStart.Data.Entities;

namespace MinimumToStart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MinimumToStart");
        }
    }
}
