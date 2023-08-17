using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
       builder.ToTable ("Persona");

       builder.Property(p => p.IdPersona)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdPais")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombres)
            .HasColumnName("Nombres")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(p => p.Apellidos)
            .HasColumnName("Apellidos")
            .HasColumnType("varchar")
            .HasMaxLength(40)
            .IsRequired();

        builder.Property(p => p.IdGenero)
            .HasColumnName("IdGenero")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.IdCiudad)
            .HasColumnName("IdCiudad")
            .HasColumnType("int")
            .IsRequired();


        builder.HasOne(p => p.Ciudades)
            .WithMany(p => p.Personas)
            .HasForeignKey(p =>p.IdCiudad);
            

    }
}
