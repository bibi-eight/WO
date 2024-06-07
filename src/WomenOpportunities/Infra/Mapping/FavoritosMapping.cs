using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WomenOpportunities.Domain;

namespace WomenOpportunities.Infra.Mapping;

public class FavoritosMapping : IEntityTypeConfiguration<Favoritos>
{
    public void Configure(EntityTypeBuilder<Favoritos> builder)
    {
        builder.ToTable("Favoritos");

        builder.HasKey(x => new { x.UsuarioId, x.OportunidadeId });
        
    }
}