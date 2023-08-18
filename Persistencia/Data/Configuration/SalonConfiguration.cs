using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class SalonConfiguration : IEntityTypeConfiguration<Salon>
{
    public void Configure(EntityTypeBuilder<Salon> builder)
    {
       builder.ToTable("Salon");

       builder.Property(p => p.IdSalon)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdSalon")
            .HasColumnType("Int")
            .IsRequired();

        builder.Property(p => p.NombreSalon)
            .HasColumnName("NombreSalon")
            .HasColumnType("varchar")
            .HasMaxLength(25)
            .IsRequired();

        builder.Property(p => p.Capacidad)
            .HasColumnName("Capacidad")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
    }
}
