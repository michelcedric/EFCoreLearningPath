using Microsoft.EntityFrameworkCore;
using MinimumToStart.Data;
using MinimumToStart.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MinimumToStart
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var applicationOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            applicationOptionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Configuration");

            var context = new ApplicationDbContext(applicationOptionsBuilder.Options);

            await context.Database.EnsureDeletedAsync();

            //await context.Database.EnsureCreatedAsync();

            //var person = new Person
            //{
            //    Name = "Cédric Michel"
            //};

            //await context.Persons.AddAsync(person);
            //await context.SaveChangesAsync();

            //var dataBasePerson = context.Persons.FirstOrDefault();

            //Console.WriteLine(dataBasePerson.Name);

        }
    }
}
