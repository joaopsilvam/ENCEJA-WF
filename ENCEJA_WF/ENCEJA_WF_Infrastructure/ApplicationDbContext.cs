using ENCEJA_WF_Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().ToTable("Alunos");
        modelBuilder.Entity<Aluno>().HasKey(a => a.Id);
    }
}