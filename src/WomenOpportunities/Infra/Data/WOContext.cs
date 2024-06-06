using Microsoft.EntityFrameworkCore;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Infra.Data;

public class WOContext : DbContext
{
    public WOContext(DbContextOptions<WOContext> options) : base(options) { }
    
    public DbSet<Instituicao> Instituicaos { get; set; }
    public DbSet<Oportunidade> Oportunidades { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}