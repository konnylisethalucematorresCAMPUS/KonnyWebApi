using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("Genero");

        builder.Property(p =>p.IdGenero)
            .HasAnnotation("MySql:ValueGenerationStrategy",  MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Genero") 
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p =>p.NombreGenero)
            .HasColumnName("NombreGenero")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

    }
}
