using Microsoft.EntityFrameworkCore;
using MoviesMvc.Models;

namespace MoviesMvc.Contexts;

public class MyBootcampDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MyBootcamp;Trusted_Connection=True;TrustServerCertificate=True;");
    }

}
