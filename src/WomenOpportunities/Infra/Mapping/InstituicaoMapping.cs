using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WomenOpportunities.Domain.Entities;

namespace WomenOpportunities.Infra.Mapping;

public class InstituicaoMapping : IEntityTypeConfiguration<Instituicao>
{
    public void Configure(EntityTypeBuilder<Instituicao> builder)
    {
        builder.HasKey(u => u.Id);

        builder.ToTable("Instituicoes");

        builder.Property(i => i.Nome)
            .HasColumnName("Nome")
            .HasColumnType($"varchar({Instituicao.Max})");

        builder.OwnsOne(x => x.Contato, contato =>
        {
            contato.Property(c => c.Email).HasColumnName("Email").HasMaxLength(50);
            contato.Property(c => c.Telefone).HasColumnName("Telefone").HasMaxLength(20);
        });

        builder.OwnsOne(x => x.Login, login =>
        {
            login.Property(l => l.Email).HasColumnName("EmailLogin").HasMaxLength(50);
            login.Property(l => l.Senha).HasColumnName("SenhaLogin").HasMaxLength(8);
        });
    }
}