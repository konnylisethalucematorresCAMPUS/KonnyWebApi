using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;

    public class KonnyContext : DbContext{
        public KonnyContext(DbContextOptions<KonnyContext> options) : base(options){

        }

        public DbSet<Ciudad> Ciudades { get; set; } = null!;
        public DbSet<Departamento> Departamentos { get; set; } = null!; 
        public DbSet<Direccion> Direccions { get; set; } = null!;
        public DbSet<Genero> Generos { get; set; } = null!;
        public DbSet<Matricula> Matriculas { get; set; } = null!;
        public DbSet<Pais> Paises { get; set; } = null!;
        public DbSet<Persona> Personas { get; set; } = null!;
        public DbSet<Salon> Salones { get; set; } = null!;
        public DbSet<TipoPersona> TipoPersonas { get; set; } = null!;
        public DbSet<TrainerSalon> TrainerSalones { get; set; } = null!;
        







        protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
