using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TuorBrasil_API.Models
{
    public class Cliente
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "nome é obrigatorio")]
        [MaxLength(60, ErrorMessage = "este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "este campo deve conter entre 3 e 60 caracteres")]
        public string mome { get; set; }
      
        public string contato { get; set; }
        
        public string pedido { get; set; }
        
        public List<Passagem> Passagem { get; set; }
    }

}
