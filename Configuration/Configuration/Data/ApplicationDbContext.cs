using Microsoft.EntityFrameworkCore;
using MinimumToStart.Data.Entities;

namespace MinimumToStart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
