using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
{
    public void Configure(EntityTypeBuilder<Direccion> builder)
    {
        builder.ToTable ("Direccion");

        builder.Property(p => p.IdDireccion) 
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdDireccion") 
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.TipoVia)
            .HasColumnName("TipoVia")
            .HasColumnType("varchar")
            .HasMaxLength (50)
            .IsRequired();

        builder.Property(p => p.Numero)
            .HasColumnName("Numero")
            .HasColumnType ("int")
            .IsRequired();

        builder.Property(p => p.Letra)
            .HasColumnName("Letra")
            .HasColumnType("varchar")
            .HasMaxLength(4)
            .IsRequired();

        builder.Property(p =>p.SufijoCardinal)
            .HasColumnName("SufijoCardinal")
            .HasColumnType("varchar")
            .HasMaxLength(0)
            .IsRequired();

        builder.Property(p => p.NumeroViaSecundaria)
            .HasColumnName("NumeroViaSecundaria")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.LetraViaSecundaria)
            .HasColumnName("LetraViaSecundaria")
            .HasColumnType("varchar")
            .HasMaxLength(4)
            .IsRequired();

        builder.Property(p => p.SufijoCardinalViaSecundaria)
            .HasColumnName("SufijoCardinalViaSecundaria")
            .HasColumnType("varchar")
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(p => p.IdPersona)
            .HasColumnName("IdPersona")
            .HasColumnType("int")
            .IsRequired();


        builder.HasOne(p => p.Personas)
            .WithMany(p => p.Direcciones)
            .HasForeignKey(p => p.IdPersona);

       
    }
}
