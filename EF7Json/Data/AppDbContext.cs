using EF7Json.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF7Json.Data;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-DK57UNP\\SQLEXPRESS;Initial Catalog=Efc7DB;Integrated Security=True;TrustServerCertificate=True;");
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().OwnsOne(x => x.Endereco, options =>
        {
            options.ToJson();
        });
    }

    public DbSet<Aluno> Alunos { get; set; }
}
