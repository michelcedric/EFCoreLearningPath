using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MinimumToStart.Data;

namespace Configuration.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var applicationOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            applicationOptionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Configuration");
            var context = new ApplicationDbContext(applicationOptionsBuilder.Options);

            return context;
        }
    }
}
