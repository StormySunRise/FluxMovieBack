using MoviePreferencesAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace MoviePreferencesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Generos> Genres { get; set; }

        public DbSet<Sugerencia> sugerencias { get; set; }

        public DbSet<Movies> movies { get; set; }
    }
}
