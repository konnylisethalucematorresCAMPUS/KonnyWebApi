using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
{
    public void Configure(EntityTypeBuilder<TipoPersona> builder)
    {
        builder.ToTable("TipoPersona");

        builder.Property(p => p.IdTipoPersona)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("IdTipoPersona")
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.Descripcion)
        .HasColumnName("Descripcion")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();
    }
}
