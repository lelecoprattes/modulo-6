using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TuorBrasil_API.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public int dataPedido { get; set; }
        public int numPedido { get; set; }
        public int ClienteId {  get; set; }
        public Cliente Cliente { get; set; }
        public int PassagemId { get; set; }
        public Passagem Passagem { get; set; }
    }
}
