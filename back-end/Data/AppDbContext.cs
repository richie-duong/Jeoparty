// Using Entity Framework Core to create a database connection layer
// AppDbContext inherits from DbContext, and will be used as a "manager" that talks to the database

using Microsoft.EntityFrameworkCore;
using back_end.Models;

namespace back_end.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Question> Questions { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

    }
}