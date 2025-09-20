using Microsoft.EntityFrameworkCore;
using ProjectCrud.Models;

namespace ProjectCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Person> ProjectCrud { get; set; }
    }
}