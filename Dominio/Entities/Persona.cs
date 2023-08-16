using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Persona{

        [Key]
        public int IdPersona { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public int IdGenero { get; set; }
        public Genero ? Generos { get; set; }
        public int IdCiudad { get; set; }
        public Ciudad ? Ciudades { get; set; }  
        public int IdTipoPersona { get; set; }
        public TipoPersona ? TipoPersonas { get; set;}
        public ICollection<Matricula> ? Matriculas { get; set; } 
        public ICollection<TrainerSalon> ? TrainerSalones { get; set; }
        public ICollection<Direccion> ? Direcciones { get; set; }
                     
    }
