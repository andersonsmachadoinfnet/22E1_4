using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        public string Marca { get; set; }
        
        [Required] 
        public string Processador { get; set; }
        
        [Required] 
        public string PlacaMae { get; set; }
        
        [Required] 
        public int Memoria { get; set; }
        
        [Required] 
        public int HD { get; set; }
        
        [Required] 
        public int NumeroPatrimonio { get; set; }
        
        [Required] 
        public DateOnly DataCompra { get; set; }
    }
}
