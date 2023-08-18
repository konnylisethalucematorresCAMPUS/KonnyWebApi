using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Direccion
    {
        [Key]
        public int IdDireccion { get; set; }
        public string ? TipoVia { get; set; }
        public int Numero { get; set;}
        public string ? Letra { get; set; }
        public string ? SufijoCardinal { get; set; }
        public int  NumeroViaSecundaria { get; set; }
        public string ? LetraViaSecundaria { get; set; }
        public string ? SufijoCardinalViaSecundaria { get; set;}
        public int IdPersona { get; set; }
        public Persona ? Personas {get; set;}

    }
