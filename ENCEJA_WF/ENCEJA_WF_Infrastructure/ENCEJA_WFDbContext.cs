using ENCEJA_WF_Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class ENCEJA_WFDbContext : DbContext
{
    public DbSet<Aluno> Alunos { get; set; }

    public ENCEJA_WFDbContext(DbContextOptions<ENCEJA_WFDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>().ToTable("Alunos");
        modelBuilder.Entity<Aluno>().HasKey(a => a.Id);
    }
}