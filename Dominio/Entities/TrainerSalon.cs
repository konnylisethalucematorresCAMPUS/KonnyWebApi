using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class TrainerSalon
    {
        [Key]
        public int IdPersona { get; set; }
        public Persona ? Personas { get; set; }
        public int IdSalon { get; set; }
        public Salon ? Salones { get; set; }
        
        
    }
