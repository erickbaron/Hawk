
using System.ComponentModel.DataAnnotations.Schema;

namespace Hawk.Domain.Entities
{
    public class Compra
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal ValorTotal { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal? Desconto { get; set; }
        public bool RegistroAtivo { get; set; }
        
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public Carrinho Carrinho { get; set; }
        public int CarrinhoId { get; set; }
    }
}
