using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departamento");

        builder.Property(p => p.IdDepartamento) 
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdDepartamento") 
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.NombreDepartamento)
            .HasColumnName("NombreDepartamento")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(p =>p.IdPais)
            .HasColumnType("IdPais")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Paises) 
            .WithMany(p => p.Departamentos) 
            .HasForeignKey(p => p.IdPais);




    }
}
