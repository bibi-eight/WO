using Microsoft.EntityFrameworkCore;
using WomenOpportunities.Domain;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Infra.Data;

public class WOContext : DbContext
{
    public WOContext(DbContextOptions<WOContext> options) : base(options) { }
    
    public DbSet<Instituicao> Instituicaos { get; set; }
    public DbSet<Oportunidade> Oportunidades { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Favoritos> Favoritos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WOContext).Assembly);
    }
}