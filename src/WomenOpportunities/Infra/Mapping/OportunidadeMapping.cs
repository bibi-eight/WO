using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Infra.Mapping;

public class OportunidadeMapping : IEntityTypeConfiguration<Oportunidade>
{
    public void Configure(EntityTypeBuilder<Oportunidade> builder)
    {
        builder.HasKey(u => u.Id);

        builder.ToTable("Oportunidades");

        builder.Property(o => o.Titulo)
            .HasColumnName("Titulo")
            .HasColumnType($"varchar({Oportunidade.Max})");

        builder.Property(o => o.Descricao)
            .HasColumnName("Descricao")
            .HasColumnType($"varchar({Oportunidade.Max})");
        
        builder.OwnsOne(x => x.Contato, contato =>
        {
            contato.Property(c => c.Email).HasColumnName("Email").HasMaxLength(50);
            contato.Property(c => c.Telefone).HasColumnName("Telefone").HasMaxLength(20);
        });
        
        builder.Property(o => o.Publicado).HasDefaultValueSql("0");

    }
}