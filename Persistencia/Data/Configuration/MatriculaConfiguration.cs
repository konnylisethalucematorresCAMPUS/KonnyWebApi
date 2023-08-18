using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
       builder.ToTable ("Matricula");
       
       builder.Property(p => p.IdMatricula)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdMatricula") 
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.IdPersona)
            .HasColumnName("IdPersona")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Personas) 
            .WithMany(p => p.Matriculas) 
            .HasForeignKey(p => p.IdPersona);
        
        builder.Property(p => p.IdSalon)
            .HasColumnName("IdSalon")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Salones)
            .WithMany(p => p.Matriculas)
            .HasForeignKey(p => p.IdSalon);

    }
}
