using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("Ciudad");

        builder.Property(p => p.IdCiudad) 
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdCiudad") 
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.NombreCiudad)
            .HasColumnName("NombreCiudad")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.IdDepartamento)
            .HasColumnName("IdDepartamento")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Departamentos)       // La tabla Ciudad esta recibiendo en esta linea de codigo la informacion mandada de la tabla Departamentos 
            .WithMany(p => p.Ciudades)             //La tabla Departamentos esta mandando en esta linea de codigo la informacion a la tabla Ciudades
            .HasForeignKey(p => p.IdDepartamento); // La propiedad que recibe esta informacion es el IdDepartamento que se encuentra en la tabla Ciudad

    }
}
