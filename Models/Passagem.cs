using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TuorBrasil_API.Models
{
    public class Passagem
    {
        [Key]
        public int Id { get; set; }
        public string Data_compra { get; set; }
        public double Total_compra { get; set; }

        public int ClienteId { get; set; }
        public Cliente Clientes {get; set; }
        public int PedidoId { get; set; }
        public List<Pedido> Pedido { get; set; }
    }
}
